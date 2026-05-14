using System.Drawing.Imaging;

namespace PhotoEmin.Services
{
    public static class ImageService
    {
        private static readonly string[] SupportedExtensions = [".jpg", ".jpeg", ".png", ".bmp", ".gif"];

        public static bool IsImageFile(string extension)
            => SupportedExtensions.Contains(extension.ToLowerInvariant());

        public static string? FindFirstImage(string directory)
        {
            // Önce "a.jpg" / "a.jpeg" ara
            foreach (var name in new[] { "a.jpg", "a.jpeg" })
            {
                var path = Path.Combine(directory, name);
                if (File.Exists(path)) return path;
            }
            // Sonra herhangi bir desteklenen resim dosyası
            foreach (var ext in SupportedExtensions)
            {
                var files = Directory.GetFiles(directory, $"*{ext}");
                if (files.Length > 0) return files[0];
            }
            return null;
        }

        public static byte[] ResizeImage(string imagePath, int targetWidth, int targetHeight)
        {
            using Image image = Image.FromFile(imagePath);

            if (image.Width <= targetWidth && image.Height <= targetHeight)
            {
                using MemoryStream ms = new();
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }

            using Bitmap resizedImage = new(targetWidth, targetHeight);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.DrawImage(image, 0, 0, targetWidth, targetHeight);
            }

            using MemoryStream msResized = new();
            resizedImage.Save(msResized, image.RawFormat);
            return msResized.ToArray();
        }

        public static void SavePhotoDataAsJpeg(byte[]? photoData, string filePath, DateTime createDate)
        {
            try
            {
                if (photoData != null && photoData.Length > 0)
                {
                    using MemoryStream ms = new(photoData);
                    using Image image = Image.FromStream(ms);
                    image.Save(filePath, ImageFormat.Jpeg);
                    File.SetCreationTime(filePath, createDate);
                }
                else
                {
                    CreateFallbackFolder(filePath, createDate);
                }
            }
            catch (Exception)
            {
                CreateFallbackFolder(filePath, createDate);
            }
        }

        private static void CreateFallbackFolder(string filePath, DateTime createDate)
        {
            string directoryPath = Path.GetDirectoryName(filePath)!;
            string folderName = Path.GetFileNameWithoutExtension(filePath);
            string newFolderPath = Path.Combine(directoryPath, folderName);

            if (!Directory.Exists(newFolderPath))
            {
                Directory.CreateDirectory(newFolderPath);
                Directory.SetCreationTime(newFolderPath, createDate);
            }
        }
    }
}
