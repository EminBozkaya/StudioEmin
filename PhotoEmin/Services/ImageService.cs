using ImageMagick;

namespace PhotoEmin.Services
{
    public static class ImageService
    {
        private static readonly string[] SupportedExtensions =
        [
            // Yaygın formatlar
            ".jpg", ".jpeg", ".png", ".bmp", ".gif", ".jfif",
            // Modern formatlar
            ".webp", ".avif", ".heic", ".heif",
            // Profesyonel / tarayıcı
            ".tiff", ".tif",
            // RAW formatları (Canon, Nikon, Sony, genel)
            ".raw", ".cr2", ".cr3", ".nef", ".arw", ".dng"
        ];

        public static bool IsImageFile(string extension)
            => SupportedExtensions.Contains(extension.ToLowerInvariant());

        public static string? FindFirstImage(string directory)
        {
            foreach (var name in new[] { "a.jpg", "a.jpeg" })
            {
                var path = Path.Combine(directory, name);
                if (File.Exists(path)) return path;
            }
            foreach (var ext in SupportedExtensions)
            {
                var files = Directory.GetFiles(directory, $"*{ext}");
                if (files.Length > 0) return files[0];
            }
            return null;
        }

        public static byte[] ResizeImage(string imagePath, int targetWidth, int targetHeight)
        {
            using var image = new MagickImage(imagePath);

            if (image.Width <= (uint)targetWidth && image.Height <= (uint)targetHeight)
            {
                image.Format = MagickFormat.Jpeg;
                return image.ToByteArray();
            }

            var geometry = new MagickGeometry((uint)targetWidth, (uint)targetHeight)
            {
                IgnoreAspectRatio = true
            };
            image.Resize(geometry);
            image.Format = MagickFormat.Jpeg;
            return image.ToByteArray();
        }

        public static void SavePhotoDataAsJpeg(byte[]? photoData, string filePath, DateTime createDate)
        {
            try
            {
                if (photoData != null && photoData.Length > 0)
                {
                    using var image = new MagickImage(photoData);
                    image.Format = MagickFormat.Jpeg;
                    image.Write(filePath);
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
