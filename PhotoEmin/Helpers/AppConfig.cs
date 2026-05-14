using System.Text.Json;

namespace PhotoEmin.Helpers
{
    public static class AppConfig
    {
        private static JsonDocument? _config;

        public static void Load()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");
            if (!File.Exists(path))
                throw new FileNotFoundException("appsettings.json bulunamadı!", path);

            var json = File.ReadAllText(path);
            _config = JsonDocument.Parse(json);
        }

        private static string Get(string section, string key)
            => _config!.RootElement.GetProperty(section).GetProperty(key).GetString()!;

        public static string ConnectionString => Get("ConnectionStrings", "Default");
        public static string MainConnectionString => Get("ConnectionStrings", "Main");
        public static string PasswordDBProcess => Get("Passwords", "DBProcess");
        public static string PasswordDelete => Get("Passwords", "Delete");
        public static string PasswordUpdate => Get("Passwords", "Update");
    }
}
