using Npgsql;
using NpgsqlTypes;
using PhotoEmin.Helpers;
using PhotoEmin.Model;
using System.Data;
using System.Diagnostics;

namespace PhotoEmin.Services
{
    /// <summary>
    /// Veritabanı (PostgreSQL) ile ilgili tüm CRUD ve yönetim işlemlerini
    /// Form1'den bağımsız olarak yürüten servis sınıfı.
    /// </summary>
    public class DatabaseService
    {
        private readonly string _connectionString;
        private readonly string _mainConnectionString;

        public DatabaseService()
        {
            _connectionString = AppConfig.ConnectionString;
            _mainConnectionString = AppConfig.MainConnectionString;
        }

        // ──────────────────────────────────────────────
        //  VERİTABANI YÖNETİMİ (CREATE / CHECK / DROP)
        // ──────────────────────────────────────────────

        /// <summary>
        /// 'dbphoto' veritabanının var olup olmadığını kontrol eder.
        /// </summary>
        public bool CheckDatabaseExists()
        {
            using var conn = new NpgsqlConnection(_mainConnectionString);
            try
            {
                conn.Open();
                using var cmd = new NpgsqlCommand(
                    "SELECT datname FROM pg_catalog.pg_database WHERE datname = 'dbphoto';", conn);
                var result = cmd.ExecuteScalar();
                Debug.WriteLine($"Sonuç: {result}");
                return result != null;
            }
            catch (NpgsqlException ex)
            {
                LogService.LogError(ex, LanguageManager.GetString("log_dbConnectionError"));
                return false;
            }
        }

        /// <summary>
        /// 'dbphoto' veritabanını oluşturur.
        /// </summary>
        public void CreateDatabase()
        {
            using var conn = new NpgsqlConnection(_mainConnectionString);
            try
            {
                conn.Open();
                using var cmd = new NpgsqlCommand(
                    "CREATE DATABASE dbphoto WITH OWNER = postgres ENCODING = 'UTF8';", conn);
                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                throw new InvalidOperationException(
                    $"Veri tabanı oluşturulurken bir hata oluştu: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// 'customers' tablosunu oluşturur.
        /// </summary>
        public void CreateTable()
        {
            using var conn = new NpgsqlConnection(_connectionString);
            try
            {
                conn.Open();
                using var cmd = new NpgsqlCommand(
                    "CREATE TABLE customers (id BIGSERIAL PRIMARY KEY, fullname TEXT NOT NULL, " +
                    "foldername TEXT, photodata BYTEA, createdate TIMESTAMP WITH TIME ZONE, " +
                    "insertdate TIMESTAMP WITH TIME ZONE);", conn);
                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                throw new InvalidOperationException(
                    $"Tablo oluşturulurken bir hata oluştu: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// 'dbphoto' veritabanını tamamen kaldırır. Bağlı tüm bağlantılar sonlandırılır.
        /// </summary>
        public void RemoveDatabase()
        {
            var builder = new NpgsqlConnectionStringBuilder(_mainConnectionString)
            {
                Database = "postgres"
            };

            using var conn = new NpgsqlConnection(builder.ConnectionString);
            conn.Open();

            using (var cmdTerminate = new NpgsqlCommand(
                "SELECT pg_terminate_backend(pg_stat_activity.pid) " +
                "FROM pg_stat_activity WHERE pg_stat_activity.datname = 'dbphoto' " +
                "AND pid <> pg_backend_pid();", conn))
            {
                cmdTerminate.ExecuteNonQuery();
            }

            using (var cmdDrop = new NpgsqlCommand("DROP DATABASE IF EXISTS dbphoto;", conn))
            {
                cmdDrop.ExecuteNonQuery();
            }
        }

        // ──────────────────────────────────────────────
        //  MÜŞTERİ KAYIT İŞLEMLERİ (CRUD)
        // ──────────────────────────────────────────────

        /// <summary>
        /// Müşteri adına göre arama yapar ve sonuçları DataTable olarak döner.
        /// Türkçe karakter duyarlı arama desteği sağlar.
        /// </summary>
        public DataTable SearchCustomers(string searchText)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();

            string sql = "SELECT id, fullname AS \"Ad Soyad\" FROM customers " +
                         "WHERE UPPER(REPLACE(REPLACE(fullname, 'i', 'İ'), 'ı', 'I')) LIKE @searchText " +
                         "ORDER BY CASE WHEN UPPER(REPLACE(REPLACE(fullname, 'i', 'İ'), 'ı', 'I')) = @searchText " +
                         "THEN 0 ELSE 1 END, fullname";

            using var command = new NpgsqlCommand(sql, connection);
            command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

            using var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        /// <summary>
        /// Belirtilen ID'ye sahip müşterinin klasör adı ve fotoğraf verisini döner.
        /// </summary>
        public (string? folderName, byte[]? photoData) GetCustomerDetail(int id)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();

            string sql = "SELECT foldername, photodata FROM customers WHERE id = @id";

            using var command = new NpgsqlCommand(sql, connection);
            command.Parameters.AddWithValue("@id", id);

            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                string? folderName = reader["foldername"]?.ToString();
                byte[]? photoData = !reader.IsDBNull(reader.GetOrdinal("photodata"))
                    ? (byte[])reader["photodata"]
                    : null;
                return (folderName, photoData);
            }
            return (null, null);
        }

        /// <summary>
        /// Belirtilen ID'ye sahip müşterinin adını günceller.
        /// </summary>
        public void UpdateCustomerName(int id, string newFullName)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();

            string sql = "UPDATE customers SET fullname = @fullname WHERE id = @id";

            using var command = new NpgsqlCommand(sql, connection);
            command.Parameters.AddWithValue("@fullname", newFullName);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Belirtilen ID'ye sahip müşteri kaydını siler.
        /// </summary>
        public void DeleteCustomer(int id)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();

            string sql = "DELETE FROM customers WHERE id = @id";

            using var command = new NpgsqlCommand(sql, connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
        }

        // ──────────────────────────────────────────────
        //  TOPLU KAYIT İŞLEMLERİ (Arşiv → DB)
        // ──────────────────────────────────────────────

        /// <summary>
        /// Verilen üst klasördeki alt klasörleri tarayarak müşteri kayıtlarını veritabanına ekler.
        /// Her alt klasör bir müşteri olarak ele alınır; klasör adı = müşteri adı.
        /// </summary>
        public RecordStatus RecordFoldersToDB(string folderPath, string[] subDirectories)
        {
            string errorFullName = "";
            string folderName = "";
            var recordStatus = new RecordStatus();
            recordStatus.totalInserts = subDirectories.Length;

            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();

            foreach (string subDir in subDirectories)
            {
                try
                {
                    var subDirInfo = new DirectoryInfo(subDir);
                    folderName = Path.GetFileName(folderPath);
                    string fullName = subDirInfo.Name;
                    errorFullName = subDirInfo.Name;

                    // Mükerrer kayıt kontrolü
                    string checkDuplicateQuery =
                        "SELECT COUNT(*) FROM customers WHERE fullname = @fullname AND foldername = @foldername";

                    using var checkCommand = new NpgsqlCommand(checkDuplicateQuery, connection);
                    checkCommand.Parameters.AddWithValue("@fullname", fullName);
                    checkCommand.Parameters.AddWithValue("@foldername", folderName);

                    long existingRecordsCount = (long)checkCommand.ExecuteScalar()!;

                    if (existingRecordsCount == 0)
                    {
                        string? imagePath = ImageService.FindFirstImage(subDir);
                        byte[]? photoData = null;
                        DateTime? creationDate = DateTime.UtcNow;
                        try
                        {
                            if (imagePath != null)
                            {
                                photoData = ImageService.ResizeImage(imagePath, 118, 118);
                                creationDate = File.GetCreationTimeUtc(imagePath);
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

                        string insertQuery =
                            "INSERT INTO customers (fullname, foldername, photodata, createdate, insertdate) " +
                            "VALUES (@fullname, @foldername, @photodata, @createdate, @insertdate)";

                        using var command = new NpgsqlCommand(insertQuery, connection);
                        command.Parameters.AddWithValue("@fullname", NpgsqlDbType.Text, fullName);
                        command.Parameters.AddWithValue("@foldername", NpgsqlDbType.Text, folderName);
                        command.Parameters.AddWithValue("@photodata", photoData ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@createdate", NpgsqlDbType.TimestampTz, creationDate);
                        command.Parameters.AddWithValue("@insertdate", NpgsqlDbType.TimestampTz, DateTime.UtcNow);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            recordStatus.successfulInserts++;
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

        /// <summary>
        /// Yedek dosyadaki kayıtları (dosya adı formatı: fullname_foldername.jpg) veritabanına ekler.
        /// </summary>
        public RecordStatus ImportSpareToArchive(string folderPath)
        {
            var recordStatus = new RecordStatus();
            var wrongFormatRecords = new List<string>();
            var notImages = new List<string>();

            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();

            string[] filesAndFolders = Directory.GetFileSystemEntries(folderPath);

            foreach (string fileOrFolder in filesAndFolders)
            {
                recordStatus.totalInserts++;
                string fullName = "";
                string folderName = "";
                string[] nameParts;
                byte[]? photoData = null;
                DateTime creationDate = DateTime.UtcNow;
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
                    creationDate = Directory.GetCreationTimeUtc(fileOrFolder).Date;
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
                    creationDate = File.GetCreationTimeUtc(fileOrFolder);

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
                    string checkDuplicateQuery =
                        "SELECT COUNT(*) FROM customers WHERE fullname = @fullname AND foldername = @foldername";

                    using var checkCommand = new NpgsqlCommand(checkDuplicateQuery, connection);
                    checkCommand.Parameters.AddWithValue("@fullname", fullName);
                    checkCommand.Parameters.AddWithValue("@foldername", folderName);

                    long existingRecordsCount = (long)checkCommand.ExecuteScalar()!;

                    if (existingRecordsCount == 0)
                    {
                        string insertQuery =
                            "INSERT INTO customers (fullname, foldername, photodata, createdate, insertdate) " +
                            "VALUES (@fullname, @foldername, @photodata, @createdate, @insertdate)";

                        using var command = new NpgsqlCommand(insertQuery, connection);
                        command.Parameters.AddWithValue("@fullname", NpgsqlDbType.Text, fullName);
                        command.Parameters.AddWithValue("@foldername", NpgsqlDbType.Text, folderName);
                        command.Parameters.AddWithValue("@photodata", photoData ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@createdate", NpgsqlDbType.TimestampTz, creationDate);
                        command.Parameters.AddWithValue("@insertdate", NpgsqlDbType.TimestampTz, DateTime.UtcNow);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            recordStatus.successfulInserts++;
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

            // Ekstra bilgileri RecordStatus'a ekleyelim (UI tarafında rapor olarak sunulacak)
            // wrongFormatRecords ve notImages'ı noImageRecords ve faultyImageRecords üzerinden raporluyoruz
            foreach (var item in wrongFormatRecords)
                recordStatus.faultyImageRecords.Add($"[Format Hatası] {item}");
            foreach (var item in notImages)
                recordStatus.noImageRecords.Add(item);

            return recordStatus;
        }

        /// <summary>
        /// Veritabanındaki tüm müşteri kayıtlarını dışa aktarma amacıyla okur.
        /// Her kayıt için fullname, foldername, photodata ve createdate bilgisi döner.
        /// </summary>
        public List<(string fullName, string folderName, byte[]? photoData, DateTime createDate)> ExportAllCustomers()
        {
            var results = new List<(string, string, byte[]?, DateTime)>();

            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();

            string sql = "SELECT fullname, foldername, photodata, createdate FROM customers";

            using var command = new NpgsqlCommand(sql, connection);
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                string fullName = !reader.IsDBNull(0) ? reader.GetString(0) : string.Empty;
                string folderName = !reader.IsDBNull(1) ? reader.GetString(1) : string.Empty;
                byte[]? photoData = !reader.IsDBNull(reader.GetOrdinal("photodata"))
                    ? (byte[])reader["photodata"]
                    : null;
                DateTime createDate = !reader.IsDBNull(reader.GetOrdinal("createdate"))
                    ? reader.GetDateTime(reader.GetOrdinal("createdate"))
                    : DateTime.UtcNow;

                results.Add((fullName, folderName, photoData, createDate));
            }

            return results;
        }
    }
}
