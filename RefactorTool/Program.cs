using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string filePath = @"..\PhotoEmin\Form1.cs";
        string content = File.ReadAllText(filePath, Encoding.UTF8);

        // 1. Password Prompts
        // Match btnUpdateRecord_Click
        content = Regex.Replace(content,
            @"while\s*\(\s*true\s*\)\s*\{\s*using\s*\(\s*Form\s*passwordPromptDialog\s*=\s*new\s*Form\s*\(\s*\)\s*\).*?if\s*\(\s*passwordInput\s*==\s*pswUpdate\s*\)\s*\{\s*(try\s*\{.*?\})\s*break;\s*\}\s*passwordPromptDialog\.Close\(\);\s*MessageBox\.Show\([^;]*;\s*await\s*Task\.Delay\(\d+\);\s*\}\s*\}",
            "if (PasswordDialog.Authenticate(this, pswUpdate))\n                        {\n                            $1\n                        }", RegexOptions.Singleline);

        // Match btnDeleteRecord_Click
        content = Regex.Replace(content,
            @"while\s*\(\s*true\s*\)\s*\{\s*Form\s*passwordPromptDialog\s*=\s*new\s*Form\s*\(\s*\);.*?if\s*\(\s*passwordInput\s*==\s*pswDelete\s*\)\s*\{\s*passwordPromptDialog\.Close\(\);\s*break;\s*\}\s*passwordPromptDialog\.Close\(\);\s*MessageBox\.Show\([^;]*;\s*await\s*Task\.Delay\(\d+\);\s*\}",
            "if (!PasswordDialog.Authenticate(this, pswDelete))\n                                return;", RegexOptions.Singleline);

        // Match btnDB_Click
        content = Regex.Replace(content,
            @"while\s*\(\s*true\s*\)\s*\{\s*Form\s*passwordPromptDialog\s*=\s*new\s*Form\s*\(\s*\);.*?if\s*\(\s*passwordInput\s*==\s*pswDBprocess\s*\)\s*\{\s*passwordPromptDialog\.Close\(\);\s*pnlBorder\.Visible\s*=\s*true;\s*pnlDBprocess\.Visible\s*=\s*true;\s*break;\s*\}\s*passwordPromptDialog\.Close\(\);\s*MessageBox\.Show\([^;]*;\s*await\s*Task\.Delay\(\d+\);\s*\}",
            "if (PasswordDialog.Authenticate(this, pswDBprocess, \"Veri tabanı işlemleri için \\nlütfen yönetici şifresini giriniz:\"))\n            {\n                pnlBorder.Visible = true;\n                pnlDBprocess.Visible = true;\n            }", RegexOptions.Singleline);

        // Match btnRemoveDB_Click
        content = Regex.Replace(content,
            @"while\s*\(\s*true\s*\)\s*\{\s*Form\s*passwordPromptDialog\s*=\s*new\s*Form\s*\(\s*\);.*?if\s*\(\s*passwordInput\s*==\s*pswDelete\s*\)\s*\{\s*DialogResult\s*resultLast\s*=\s*MessageBox\.Show\([^;]*;\s*if\s*\(resultLast\s*==\s*DialogResult\.Yes\)\s*\{\s*passwordPromptDialog\.Close\(\);\s*break;\s*\}\s*else\s*return;\s*\}\s*passwordPromptDialog\.Close\(\);\s*MessageBox\.Show\([^;]*;\s*await\s*Task\.Delay\(\d+\);\s*\}",
            "if (!PasswordDialog.Authenticate(this, pswDelete))\n                            return;\n\n                        DialogResult resultLast = MessageBox.Show(\"Veri tabanınız tamamen kaldırılacak, onaylıyor musunuz?\", \"Uyarı\", MessageBoxButtons.YesNo, MessageBoxIcon.Question);\n                        if (resultLast != DialogResult.Yes)\n                            return;", RegexOptions.Singleline);

        // Match btnUploadDB_Click
        content = Regex.Replace(content,
            @"while\s*\(\s*true\s*\)\s*\{\s*using\s*\(\s*Form\s*passwordPromptDialog\s*=\s*new\s*Form\s*\(\s*\)\s*\)\s*\{.*?if\s*\(\s*passwordInput\s*==\s*pswDelete\s*\)\s*\{\s*(// Şifre doğruysa işlemi gerçekleştir.*?)\s*break;\s*\}\s*passwordPromptDialog\.Close\(\);\s*MessageBox\.Show\([^;]*;\s*await\s*Task\.Delay\(\d+\);\s*\}\s*\}",
            "if (PasswordDialog.Authenticate(this, pswDelete))\n                    {\n                        $1\n                    }", RegexOptions.Singleline);

        // 2. Remove Image Methods
        int resizeStart = content.IndexOf("public byte[] ResizeImage(");
        if (resizeStart > 0) {
            int resizeEnd = content.IndexOf("private void txtFullName_TextChanged", resizeStart);
            content = content.Remove(resizeStart, resizeEnd - resizeStart);
        }

        int saveStart = content.IndexOf("private void SavePhotoDataAsJPEG(");
        if (saveStart > 0) {
            int saveEnd = content.IndexOf("private async void btnSpareToArchive_Click", saveStart);
            content = content.Remove(saveStart, saveEnd - saveStart);
        }

        int isImageStart = content.IndexOf("private bool IsImageFile(");
        if (isImageStart > 0) {
            int isImageEnd = content.IndexOf("private void btnUpperArchiveFoldersToDB_Click", isImageStart);
            content = content.Remove(isImageStart, isImageEnd - isImageStart);
        }

        // Replace method calls
        content = content.Replace("ResizeImage(", "ImageService.ResizeImage(");
        content = content.Replace("SavePhotoDataAsJPEG(", "ImageService.SavePhotoDataAsJpeg(");
        content = content.Replace("IsImageFile(", "ImageService.IsImageFile(");

        // 3. FindFirstImage logic replace
        string searchImgPattern = @"string\[\] jpgFiles = Directory\.GetFiles\(subDir, ""a\.jpg""\);.*?try\s*\{\s*if\s*\(jpgFiles\.Length\s*>\s*0\).*?\}\s*catch\s*\(Exception\)\s*\{\s*// Hata alınan fullname'i listeye ekle\s*recordStatus\.faultyImageRecords\.Add\([^;]*\);\s*\}";
        
        string replaceImgLogic = @"string? imagePath = ImageService.FindFirstImage(subDir);
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
                                        recordStatus.noImageRecords.Add($""{errorFullName}({folderName}): resim dosyası bulunamadı!"");
                                    }
                                }
                                catch (Exception)
                                {
                                    recordStatus.faultyImageRecords.Add($""{errorFullName}({folderName})"");
                                }";
        content = Regex.Replace(content, searchImgPattern, replaceImgLogic, RegexOptions.Singleline);

        File.WriteAllText(filePath, content, Encoding.UTF8);
        Console.WriteLine("Refactoring completed.");
    }
}
