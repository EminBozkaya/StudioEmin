using System.Text.Json;
using PhotoEmin.Model;

namespace PhotoEmin.Helpers
{
    public static class LanguageManager
    {
        private static Dictionary<string, string> _strings = new();
        private static string _currentLanguage = "tr";

        private static string ConfigFilePath =>
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "language.config");

        private static string LanguagesFolderPath =>
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Languages");

        public static string CurrentLanguage => _currentLanguage;

        public static void Initialize()
        {
            _currentLanguage = ReadLanguageConfig();
            LoadLanguage(_currentLanguage);
        }

        public static string GetString(string key)
        {
            if (_strings.TryGetValue(key, out string? value))
                return value;
            return key;
        }

        public static List<LanguageInfo> GetAvailableLanguages()
        {
            var languages = new List<LanguageInfo>();

            if (!Directory.Exists(LanguagesFolderPath))
                return languages;

            foreach (string file in Directory.GetFiles(LanguagesFolderPath, "*.json"))
            {
                try
                {
                    string json = File.ReadAllText(file, System.Text.Encoding.UTF8);
                    using var doc = JsonDocument.Parse(json);
                    var root = doc.RootElement;

                    string code = root.TryGetProperty("_languageCode", out var codeEl)
                        ? codeEl.GetString() ?? Path.GetFileNameWithoutExtension(file)
                        : Path.GetFileNameWithoutExtension(file);

                    string name = root.TryGetProperty("_languageName", out var nameEl)
                        ? nameEl.GetString() ?? code
                        : code;

                    languages.Add(new LanguageInfo
                    {
                        Code = code,
                        Name = name,
                        FilePath = file
                    });
                }
                catch { }
            }

            return languages;
        }

        public static void SetLanguage(string langCode)
        {
            _currentLanguage = langCode;
            File.WriteAllText(ConfigFilePath, langCode, System.Text.Encoding.UTF8);
        }

        private static string ReadLanguageConfig()
        {
            if (File.Exists(ConfigFilePath))
            {
                string saved = File.ReadAllText(ConfigFilePath, System.Text.Encoding.UTF8).Trim();
                if (!string.IsNullOrEmpty(saved))
                    return saved;
            }
            return "tr";
        }

        private static void LoadLanguage(string langCode)
        {
            _strings.Clear();

            if (!Directory.Exists(LanguagesFolderPath))
                return;

            string targetFile = Path.Combine(LanguagesFolderPath, langCode + ".json");

            if (!File.Exists(targetFile))
            {
                string fallback = Path.Combine(LanguagesFolderPath, "tr.json");
                if (!File.Exists(fallback))
                    return;
                targetFile = fallback;
            }

            try
            {
                string json = File.ReadAllText(targetFile, System.Text.Encoding.UTF8);
                using var doc = JsonDocument.Parse(json);
                foreach (var prop in doc.RootElement.EnumerateObject())
                {
                    if (!prop.Name.StartsWith("_"))
                        _strings[prop.Name] = prop.Value.GetString() ?? prop.Name;
                }
            }
            catch { }
        }
    }
}
