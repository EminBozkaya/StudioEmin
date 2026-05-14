using System;
using System.IO;

namespace PhotoEmin.Services
{
    /// <summary>
    /// Sistem hatalarını ve önemli olayları dosyaya kaydetmek için basit bir loglama servisi.
    /// </summary>
    public static class LogService
    {
        private static readonly string LogDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");

        static LogService()
        {
            if (!Directory.Exists(LogDirectory))
            {
                Directory.CreateDirectory(LogDirectory);
            }
        }

        /// <summary>
        /// Bilgilendirme mesajlarını kaydeder.
        /// </summary>
        public static void LogInfo(string message)
        {
            WriteLog("INFO", message);
        }

        /// <summary>
        /// Beklenmeyen hataları kaydeder.
        /// </summary>
        public static void LogError(Exception ex, string context = "")
        {
            string message = string.IsNullOrEmpty(context) 
                ? $"{ex.Message}\nStack Trace: {ex.StackTrace}" 
                : $"[{context}] {ex.Message}\nStack Trace: {ex.StackTrace}";

            WriteLog("ERROR", message);
        }

        private static void WriteLog(string level, string message)
        {
            try
            {
                string logFile = Path.Combine(LogDirectory, $"SystemLog_{DateTime.Now:yyyy-MM-dd}.txt");
                string logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{level}] {message}\n{new string('-', 50)}\n";
                
                File.AppendAllText(logFile, logEntry);
            }
            catch
            {
                // Loglama işlemi kendi içinde hata fırlatmamalı (Sessizce yutulur)
            }
        }
    }
}
