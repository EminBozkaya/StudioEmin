using PhotoEmin.Helpers;

namespace PhotoEmin.Services
{
    public static class DatabaseServiceFactory
    {
        public static IDatabaseService CreateDatabaseService()
            => AppConfig.DatabaseProvider.ToUpperInvariant() switch
            {
                "SQLITE" => new SqliteDatabaseService(),
                _ => new PostgreSqlDatabaseService()
            };

        public static IBackupService CreateBackupService()
            => AppConfig.DatabaseProvider.ToUpperInvariant() switch
            {
                "SQLITE" => new SqliteBackupService(),
                _ => new PostgreSqlBackupService()
            };
    }
}
