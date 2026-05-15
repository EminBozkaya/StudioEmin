using Microsoft.Data.Sqlite;
using PhotoEmin.Helpers;

namespace PhotoEmin.Services
{
    public class SqliteBackupService : IBackupService
    {
        private readonly string _dbPath;

        public SqliteBackupService()
        {
            var builder = new SqliteConnectionStringBuilder(AppConfig.SqliteConnectionString);
            string dataSource = builder.DataSource;
            if (!Path.IsPathRooted(dataSource))
                dataSource = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, dataSource);
            _dbPath = dataSource;
        }

        public void RunBackup(string filePath = "", string? backUpName = null)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                string defaultFolderPath = @"C:\SQLiteBackUpFiles";
                if (!Directory.Exists(defaultFolderPath))
                    Directory.CreateDirectory(defaultFolderPath);
                filePath = defaultFolderPath;
            }

            string fileName = string.IsNullOrEmpty(backUpName)
                ? DateTime.Now.ToString("ddMMyyyyHHmmss") + "_backup.db"
                : DateTime.Now.ToString("ddMMyyyyHHmmss") + backUpName + ".db";

            string destPath = Path.Combine(filePath, fileName);

            SqliteConnection.ClearAllPools();
            File.Copy(_dbPath, destPath, overwrite: true);
        }

        public void RunRestore(string tarFilePath)
        {
            SqliteConnection.ClearAllPools();
            File.Copy(tarFilePath, _dbPath, overwrite: true);
        }
    }
}
