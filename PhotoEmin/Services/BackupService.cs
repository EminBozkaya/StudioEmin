using System.Diagnostics;
using PhotoEmin.Helpers;

namespace PhotoEmin.Services
{
    public class PostgreSqlBackupService : IBackupService
    {
        public void RunBackup(string filePath = "", string? backUpName = null)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                string defaultFolderPath = @"C:\PostgreSQLBackUpFiles";
                if (!Directory.Exists(defaultFolderPath))
                    Directory.CreateDirectory(defaultFolderPath);
                filePath = defaultFolderPath;
            }

            backUpName = string.IsNullOrEmpty(backUpName)
                ? DateTime.Now.ToString("ddMMyyyyHHmmss") + "_backup.tar"
                : DateTime.Now.ToString("ddMMyyyyHHmmss") + backUpName + ".tar";

            string backupFilePath = Path.Combine(filePath, backUpName);
            string pgDumpPath = Path.Combine(FindPgBinPath(), "pg_dump.exe");
            string commandText = $"-U postgres -h localhost -p 5432 -F tar -f \"{backupFilePath}\" dbphoto";

            RunPgTool(pgDumpPath, commandText);
        }

        public void RunRestore(string tarFilePath)
        {
            string pgRestorePath = Path.Combine(FindPgBinPath(), "pg_restore.exe");
            string commandText = $"-U postgres -h localhost -p 5432 -d dbphoto \"{tarFilePath}\"";

            RunPgTool(pgRestorePath, commandText);
        }

        private void RunPgTool(string toolPath, string arguments)
        {
            ProcessStartInfo startInfo = new()
            {
                FileName = toolPath,
                Arguments = arguments,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using Process process = new();
            process.StartInfo = startInfo;
            process.StartInfo.Environment["PGPASSWORD"] = "postgres";
            process.Start();
            process.WaitForExit();
        }

        private string FindPgBinPath()
        {
            string postgreSQLPath = @"C:\Program Files\PostgreSQL";
            string[] versions = Directory.GetDirectories(postgreSQLPath);
            string version = versions.Any() ? Path.GetFileName(versions[0]) : "";
            return Path.Combine(postgreSQLPath, version, "bin");
        }
    }
}
