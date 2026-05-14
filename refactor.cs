using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class Program {
    static void Main() {
        string file = "PhotoEmin/Form1.cs";
        string content = File.ReadAllText(file, Encoding.UTF8);

        // Remove msSql regions
        content = Regex.Replace(content, @"#region msSql.*?#endregion", "", RegexOptions.Singleline);

        // Replace btnUpdateRecord password loop
        content = Regex.Replace(content, @"while\s*\(\s*true\s*\)\s*\{\s*using\s*\(\s*Form\s*passwordPromptDialog\s*=\s*new\s*Form\s*\(\s*\)\s*\)\s*\{.*?if\s*\(\s*passwordInput\s*==\s*pswUpdate\s*\)\s*\{([^}]*#region postgresql.*?#endregion.*?)\}\s*passwordPromptDialog\.Close\(\);\s*MessageBox\.Show\("Yanlýþ þifre[^"]*"[^\)]*\);\s*await\s*Task\.Delay\(304\);\s*\}\s*\}", 
            "if (PasswordDialog.Authenticate(this, pswUpdate)) {\n}", RegexOptions.Singleline);

        // Replace btnDeleteRecord password loop
        content = Regex.Replace(content, @"while\s*\(\s*true\s*\)\s*\{\s*Form\s*passwordPromptDialog\s*=\s*new\s*Form\s*\(\s*\);\s*passwordPromptDialog\.Text\s*=\s*"Þifre Giriþi";.*?if\s*\(\s*passwordInput\s*==\s*pswDelete\s*\)\s*\{\s*passwordPromptDialog\.Close\(\);\s*break;\s*\}\s*passwordPromptDialog\.Close\(\);\s*MessageBox\.Show\("Yanlýþ þifre[^"]*"[^\)]*\);\s*await\s*Task\.Delay\(304\);\s*\}", 
            "if (!PasswordDialog.Authenticate(this, pswDelete)) return;", RegexOptions.Singleline);

        // Replace btnDB_Click password loop
        content = Regex.Replace(content, @"while\s*\(\s*true\s*\)\s*\{\s*Form\s*passwordPromptDialog\s*=\s*new\s*Form\s*\(\s*\);\s*passwordPromptDialog\.Text\s*=\s*"Þifre Giriþi";.*?if\s*\(\s*passwordInput\s*==\s*pswDBprocess\s*\)\s*\{\s*passwordPromptDialog\.Close\(\);\s*pnlBorder\.Visible\s*=\s*true;\s*pnlDBprocess\.Visible\s*=\s*true;\s*break;\s*\}\s*passwordPromptDialog\.Close\(\);\s*MessageBox\.Show\("Yanlýþ þifre[^"]*"[^\)]*\);\s*await\s*Task\.Delay\(304\);\s*\}", 
            "if (PasswordDialog.Authenticate(this, pswDBprocess, "Veri tabaný iþlemleri için \\nlütfen yönetici þifresini giriniz:")) {\n                pnlBorder.Visible = true;\n                pnlDBprocess.Visible = true;\n            }", RegexOptions.Singleline);

        // Replace btnRemoveDB_Click password loop
        content = Regex.Replace(content, @"while\s*\(\s*true\s*\)\s*\{\s*Form\s*passwordPromptDialog\s*=\s*new\s*Form\s*\(\s*\);\s*passwordPromptDialog\.Text\s*=\s*"Þifre Giriþi";.*?if\s*\(\s*passwordInput\s*==\s*pswDelete\s*\)\s*\{\s*DialogResult\s*resultLast\s*=\s*MessageBox\.Show\("Veri tabanýnýz tamamen kaldýrýlacak.*?if\s*\(resultLast\s*==\s*DialogResult\.Yes\)\s*\{\s*passwordPromptDialog\.Close\(\);\s*break;\s*\}\s*else\s*return;\s*\}\s*passwordPromptDialog\.Close\(\);\s*MessageBox\.Show\("Yanlýþ þifre[^"]*"[^\)]*\);\s*await\s*Task\.Delay\(304\);\s*\}", 
            "if (!PasswordDialog.Authenticate(this, pswDelete)) return;\n                            DialogResult resultLast = MessageBox.Show("Veri tabanýnýz tamamen kaldýrýlacak, onaylýyor musunuz?", "Uyarý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);\n                            if (resultLast != DialogResult.Yes) return;", RegexOptions.Singleline);

        // Replace btnUploadDB_Click password loop
        content = Regex.Replace(content, @"while\s*\(\s*true\s*\)\s*\{\s*using\s*\(\s*Form\s*passwordPromptDialog\s*=\s*new\s*Form\s*\(\s*\)\s*\)\s*\{\s*passwordPromptDialog\.Text\s*=\s*"Þifre Giriþi";.*?if\s*\(\s*passwordInput\s*==\s*pswDelete\s*\)\s*\{([^}]*?BackupService\.RunRestore.*?break;\s*)\}\s*passwordPromptDialog\.Close\(\);\s*MessageBox\.Show\("Yanlýþ þifre[^"]*"[^\)]*\);\s*await\s*Task\.Delay\(304\);\s*\}\s*\}", 
            "if (PasswordDialog.Authenticate(this, pswDelete)) {}".Replace("break;", ""), RegexOptions.Singleline);

        // Remove ResizeImage
        content = Regex.Replace(content, @"public byte\[\] ResizeImage.*?^\s*\}\s*$", "", RegexOptions.Singleline | RegexOptions.Multiline);
        // Remove SavePhotoDataAsJPEG
        content = Regex.Replace(content, @"private void SavePhotoDataAsJPEG.*?^\s*\}\s*$", "", RegexOptions.Singleline | RegexOptions.Multiline);
        // Remove IsImageFile
        content = Regex.Replace(content, @"private bool IsImageFile.*?^\s*\}\s*$", "", RegexOptions.Singleline | RegexOptions.Multiline);

        // Replace method calls
        content = content.Replace("ResizeImage(", "ImageService.ResizeImage(");
        content = content.Replace("SavePhotoDataAsJPEG(", "ImageService.SavePhotoDataAsJpeg(");
        content = content.Replace("IsImageFile(", "ImageService.IsImageFile(");

        // Image search logic replacement
        string imgSearchPattern = @"string\[\] jpgFiles = Directory\.GetFiles\(subDir, "a\.jpg"\);.*?try\s*\{\s*if\s*\(jpgFiles\.Length\s*>\s*0\).*?\}\s*catch\s*\(Exception\)\s*\{\s*// Hata alýnan fullname'i listeye ekle\s*recordStatus\.faultyImageRecords\.Add\("\$\{errorFullName\}\(\{folderName\}\)"\);\s*\}";
        string imgSearchReplace = @"string? imagePath = ImageService.FindFirstImage(subDir);
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
                                        recordStatus.noImageRecords.Add($"{errorFullName}({folderName}): resim dosyasý bulunamadý!");
                                    }
                                }
                                catch (Exception)
                                {
                                    recordStatus.faultyImageRecords.Add($"{errorFullName}({folderName})");
                                }";
        content = Regex.Replace(content, imgSearchPattern, imgSearchReplace, RegexOptions.Singleline);

        File.WriteAllText(file, content, Encoding.UTF8);
    }
}
