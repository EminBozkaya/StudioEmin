namespace PhotoEmin.Services
{
    public interface IBackupService
    {
        void RunBackup(string filePath = "", string? backUpName = null);
        void RunRestore(string tarFilePath);
    }
}
