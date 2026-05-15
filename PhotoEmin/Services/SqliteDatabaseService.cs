using Microsoft.Data.Sqlite;
using PhotoEmin.Helpers;
using PhotoEmin.Model;
using System.Data;
using System.Globalization;

namespace PhotoEmin.Services
{
    public class SqliteDatabaseService : IDatabaseService
    {
        private readonly string _dbPath;
        private readonly string _connectionString;

        public SqliteDatabaseService()
        {
            _dbPath = ResolveDbPath(AppConfig.SqliteConnectionString);
            // Mode=ReadWrite: file must already exist — prevents accidental recreation after deletion.
            // CreateDatabase() uses Mode=ReadWriteCreate explicitly.
            _connectionString = $"Data Source={_dbPath};Mode=ReadWrite";
        }

        private static string ResolveDbPath(string connectionString)
        {
            // "Data Source=dbphoto.db" → absolute path under app base dir
            var builder = new SqliteConnectionStringBuilder(connectionString);
            string dataSource = builder.DataSource;
            if (!Path.IsPathRooted(dataSource))
                dataSource = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, dataSource);
            return dataSource;
        }

        // ──────────────────────────────────────────────
        //  VERİTABANI YÖNETİMİ
        // ──────────────────────────────────────────────

        public bool CheckDatabaseExists()
        {
            if (!File.Exists(_dbPath)) return false;
            try
            {
                using var conn = new SqliteConnection(_connectionString);
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM sqlite_master WHERE type='table' AND name IN ('customers','customer_photos');";
                var count = (long)cmd.ExecuteScalar()!;
                return count == 2;
            }
            catch
            {
                return false;
            }
        }

        public void CreateDatabase()
        {
            // ReadWriteCreate: creates the file if it doesn't exist.
            using var conn = new SqliteConnection($"Data Source={_dbPath};Mode=ReadWriteCreate");
            conn.Open();
        }

        public void CreateTable()
        {
            using var conn = new SqliteConnection(_connectionString);
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText =
                "CREATE TABLE IF NOT EXISTS customers (" +
                "id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                "fullname TEXT NOT NULL, " +
                "foldername TEXT, " +
                "createdate TEXT, " +
                "insertdate TEXT, " +
                "updatedate TEXT);" +
                "CREATE TABLE IF NOT EXISTS customer_photos (" +
                "customer_id INTEGER PRIMARY KEY REFERENCES customers(id) ON DELETE CASCADE, " +
                "photodata BLOB NOT NULL);";
            cmd.ExecuteNonQuery();
        }

        public void RemoveDatabase()
        {
            SqliteConnection.ClearAllPools();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            if (File.Exists(_dbPath)) File.Delete(_dbPath);
            // Clean up WAL/SHM journal files if present
            string wal = _dbPath + "-wal";
            string shm = _dbPath + "-shm";
            if (File.Exists(wal)) File.Delete(wal);
            if (File.Exists(shm)) File.Delete(shm);
        }

        // ──────────────────────────────────────────────
        //  MÜŞTERİ KAYIT İŞLEMLERİ (CRUD)
        // ──────────────────────────────────────────────

        public DataTable SearchCustomers(string searchText)
        {
            using var conn = new SqliteConnection(_connectionString);
            conn.Open();

            string sql = "SELECT id, fullname AS \"Ad Soyad\" FROM customers " +
                         "WHERE UPPER(REPLACE(REPLACE(fullname, 'i', 'İ'), 'ı', 'I')) LIKE @searchText " +
                         "ORDER BY CASE WHEN UPPER(REPLACE(REPLACE(fullname, 'i', 'İ'), 'ı', 'I')) = @searchText " +
                         "THEN 0 ELSE 1 END, fullname";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

            var dt = new DataTable();
            using var reader = cmd.ExecuteReader();
            dt.Load(reader);
            return dt;
        }

        public (string? folderName, byte[]? photoData) GetCustomerDetail(int id)
        {
            using var conn = new SqliteConnection(_connectionString);
            conn.Open();

            using var cmd = new SqliteCommand(
                "SELECT c.foldername, cp.photodata FROM customers c " +
                "LEFT JOIN customer_photos cp ON c.id = cp.customer_id WHERE c.id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string? folderName = reader.IsDBNull(0) ? null : reader.GetString(0);
                byte[]? photoData = reader.IsDBNull(1) ? null : (byte[])reader.GetValue(1);
                return (folderName, photoData);
            }
            return (null, null);
        }

        public void UpdateCustomerName(int id, string newFullName)
        {
            using var conn = new SqliteConnection(_connectionString);
            conn.Open();

            using var cmd = new SqliteCommand(
                "UPDATE customers SET fullname = @fullname, updatedate = @updatedate WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@fullname", newFullName);
            cmd.Parameters.AddWithValue("@updatedate", DateTime.Now.ToString("o"));
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        public void DeleteCustomer(int id)
        {
            using var conn = new SqliteConnection(_connectionString);
            conn.Open();

            using var pragma = new SqliteCommand("PRAGMA foreign_keys = ON;", conn);
            pragma.ExecuteNonQuery();

            using var cmd = new SqliteCommand(
                "DELETE FROM customers WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        // ──────────────────────────────────────────────
        //  TOPLU KAYIT İŞLEMLERİ
        // ──────────────────────────────────────────────

        public RecordStatus RecordFoldersToDB(string folderPath, string[] subDirectories)
        {
            string errorFullName = "";
            string folderName = "";
            var recordStatus = new RecordStatus();
            recordStatus.totalInserts = subDirectories.Length;

            using var connection = new SqliteConnection(_connectionString);
            connection.Open();

            foreach (string subDir in subDirectories)
            {
                try
                {
                    var subDirInfo = new DirectoryInfo(subDir);
                    folderName = Path.GetFileName(folderPath);
                    string fullName = subDirInfo.Name;
                    errorFullName = subDirInfo.Name;

                    using var checkCommand = new SqliteCommand(
                        "SELECT COUNT(*) FROM customers WHERE fullname = @fullname AND foldername = @foldername",
                        connection);
                    checkCommand.Parameters.AddWithValue("@fullname", fullName);
                    checkCommand.Parameters.AddWithValue("@foldername", folderName);

                    long existingRecordsCount = (long)checkCommand.ExecuteScalar()!;

                    if (existingRecordsCount == 0)
                    {
                        string? imagePath = ImageService.FindFirstImage(subDir);
                        byte[]? photoData = null;
                        DateTime creationDate = DateTime.Now;
                        try
                        {
                            if (imagePath != null)
                            {
                                photoData = ImageService.ResizeImage(imagePath, 118, 118);
                                creationDate = File.GetCreationTime(imagePath);
                            }
                            else
                            {
                                recordStatus.noImageRecords.Add(
                                    $"{errorFullName}({folderName}): resim dosyası bulunamadı!");
                            }
                        }
                        catch (Exception ex)
                        {
                            LogService.LogError(ex, string.Format(LanguageManager.GetString("log_fileReadError"), errorFullName, folderName));
                            recordStatus.faultyImageRecords.Add($"{errorFullName}({folderName})");
                        }

                        using var cmd = new SqliteCommand(
                            "INSERT INTO customers (fullname, foldername, createdate, insertdate) " +
                            "VALUES (@fullname, @foldername, @createdate, @insertdate) RETURNING id",
                            connection);
                        cmd.Parameters.AddWithValue("@fullname", fullName);
                        cmd.Parameters.AddWithValue("@foldername", folderName);
                        cmd.Parameters.AddWithValue("@createdate", creationDate.ToString("o"));
                        cmd.Parameters.AddWithValue("@insertdate", DateTime.Now.ToString("o"));

                        var newId = cmd.ExecuteScalar();
                        if (newId != null)
                        {
                            recordStatus.successfulInserts++;
                            if (photoData != null)
                            {
                                using var photoCmd = new SqliteCommand(
                                    "INSERT INTO customer_photos (customer_id, photodata) VALUES (@cid, @photodata)", connection);
                                photoCmd.Parameters.AddWithValue("@cid", (long)newId);
                                photoCmd.Parameters.AddWithValue("@photodata", photoData);
                                photoCmd.ExecuteNonQuery();
                            }
                        }
                    }
                    else
                    {
                        recordStatus.duplicateRecords.Add($"{fullName}({folderName})");
                    }
                }
                catch (Exception ex)
                {
                    LogService.LogError(ex, LanguageManager.GetString("log_photoInsertLoopError"));
                    recordStatus.errorFullNames.Add($"{errorFullName}({folderName}): {ex.Message}");
                }
            }

            return recordStatus;
        }

        public RecordStatus ImportSpareToArchive(string folderPath)
        {
            var recordStatus = new RecordStatus();
            var wrongFormatRecords = new List<string>();
            var notImages = new List<string>();

            using var connection = new SqliteConnection(_connectionString);
            connection.Open();

            string[] filesAndFolders = Directory.GetFileSystemEntries(folderPath);

            foreach (string fileOrFolder in filesAndFolders)
            {
                recordStatus.totalInserts++;
                string fullName = "";
                string folderName = "";
                string[] nameParts;
                byte[]? photoData = null;
                DateTime creationDate = DateTime.Now;
                string errorFullName = "";

                if (Directory.Exists(fileOrFolder))
                {
                    folderName = Path.GetFileName(fileOrFolder);
                    if (!folderName.Contains('_'))
                    {
                        wrongFormatRecords.Add(folderName);
                        continue;
                    }
                    notImages.Add(folderName);

                    nameParts = folderName.Split('_');
                    errorFullName = string.Join("_", nameParts);
                    fullName = nameParts[0];
                    folderName = nameParts[1];
                    creationDate = Directory.GetCreationTime(fileOrFolder).Date;
                }
                else if (File.Exists(fileOrFolder))
                {
                    string fileName = Path.GetFileNameWithoutExtension(fileOrFolder);

                    if (!fileName.Contains('_'))
                    {
                        wrongFormatRecords.Add(fileName);
                        continue;
                    }

                    nameParts = fileName.Split('_');
                    errorFullName = string.Join("_", nameParts);
                    fullName = nameParts[0];
                    folderName = nameParts[1];
                    creationDate = File.GetCreationTime(fileOrFolder);

                    string fileExtension = Path.GetExtension(fileOrFolder);
                    if (ImageService.IsImageFile(fileExtension))
                    {
                        photoData = File.ReadAllBytes(fileOrFolder);
                    }
                    else
                    {
                        notImages.Add(fileName);
                        continue;
                    }
                }

                try
                {
                    using var checkCommand = new SqliteCommand(
                        "SELECT COUNT(*) FROM customers WHERE fullname = @fullname AND foldername = @foldername",
                        connection);
                    checkCommand.Parameters.AddWithValue("@fullname", fullName);
                    checkCommand.Parameters.AddWithValue("@foldername", folderName);

                    long existingRecordsCount = (long)checkCommand.ExecuteScalar()!;

                    if (existingRecordsCount == 0)
                    {
                        using var cmd = new SqliteCommand(
                            "INSERT INTO customers (fullname, foldername, createdate, insertdate) " +
                            "VALUES (@fullname, @foldername, @createdate, @insertdate) RETURNING id",
                            connection);
                        cmd.Parameters.AddWithValue("@fullname", fullName);
                        cmd.Parameters.AddWithValue("@foldername", folderName);
                        cmd.Parameters.AddWithValue("@createdate", creationDate.ToString("o"));
                        cmd.Parameters.AddWithValue("@insertdate", DateTime.Now.ToString("o"));

                        var newId = cmd.ExecuteScalar();
                        if (newId != null)
                        {
                            recordStatus.successfulInserts++;
                            if (photoData != null)
                            {
                                using var photoCmd = new SqliteCommand(
                                    "INSERT INTO customer_photos (customer_id, photodata) VALUES (@cid, @photodata)", connection);
                                photoCmd.Parameters.AddWithValue("@cid", (long)newId);
                                photoCmd.Parameters.AddWithValue("@photodata", photoData);
                                photoCmd.ExecuteNonQuery();
                            }
                        }
                    }
                    else
                    {
                        recordStatus.duplicateRecords.Add(fullName);
                    }
                }
                catch (Exception ex)
                {
                    LogService.LogError(ex, LanguageManager.GetString("log_bulkInsertError"));
                    recordStatus.errorFullNames.Add($"{errorFullName}: {ex.Message}");
                }
            }

            foreach (var item in wrongFormatRecords)
                recordStatus.faultyImageRecords.Add($"[Format Hatası] {item}");
            foreach (var item in notImages)
                recordStatus.noImageRecords.Add(item);

            return recordStatus;
        }

        public List<(string fullName, string folderName, byte[]? photoData, DateTime createDate)> ExportAllCustomers()
        {
            var results = new List<(string, string, byte[]?, DateTime)>();

            using var connection = new SqliteConnection(_connectionString);
            connection.Open();

            using var cmd = new SqliteCommand(
                "SELECT c.fullname, c.foldername, cp.photodata, c.createdate " +
                "FROM customers c LEFT JOIN customer_photos cp ON c.id = cp.customer_id", connection);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string fullName = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                string folderName = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                byte[]? photoData = reader.IsDBNull(2) ? null : (byte[])reader.GetValue(2);
                DateTime createDate = reader.IsDBNull(3)
                    ? DateTime.Now
                    : DateTime.Parse(reader.GetString(3), null, DateTimeStyles.RoundtripKind);

                results.Add((fullName, folderName, photoData, createDate));
            }

            return results;
        }
    }
}
