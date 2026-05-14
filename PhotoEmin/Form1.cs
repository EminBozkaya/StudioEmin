using PhotoEmin.Model;
using System.Data;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Globalization;
using PhotoEmin.Forms;
using PhotoEmin.Helpers;
using PhotoEmin.Services;

namespace PhotoEmin
{
    public partial class Form1 : Form
    {
        // Şifreler appsettings.json'dan okunur
        private static string pswDBprocess => AppConfig.PasswordDBProcess;
        private static string pswDelete => AppConfig.PasswordDelete;
        private static string pswUpdate => AppConfig.PasswordUpdate;

        // Servis katmanları
        private readonly DatabaseService _dbService = new();
        private readonly ReceiptService _receiptService = new();

        private bool isUpperArchiveBtn = false;
        private Receipt newReceipt = new();
        public Form1()
        {
            InitializeComponent();
            this.Load += (s, e) =>
            {

                // Formun genişlik ve yüksekliğini belirleyin (örneğin, 800x600)
                this.Width = 1720;
                this.Height = 975;
                textBoxFileLocation.Multiline = false;
                textBoxFileLocation.ScrollBars = ScrollBars.Vertical;

                //pnlReceipt.Visible = false;
                //pnlFindFolder.Visible = false;
                //flowLayoutPanelArchive.Visible = false;
                pictureBoxLoading.Visible = false; // Başlangıçta görünmez yapın
                pictureBoxLoadingArchive.Visible = false;
                pictureBoxAddFolderToArchive.Visible = false;
                pictureBoxLoadingDbToFolder.Visible = false;
                pictureBoxLoadingSpareToArchive.Visible = false;
                pnlBorder.Visible = false;


                ////kullanılacak olan kod:
                //ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
                //ManagementObject _disk = searcher.Get().Cast<ManagementObject>().First();
                //Debug.WriteLine("Disk Seri Numarası: " + _disk["SerialNumber"]);

                ////Terminal Kodu:
                ////wmic diskdrive where index = 0 get serialnumber

                //Auto backup:
                try
                {
                    if (_dbService.CheckDatabaseExists())
                    {
                        ////Oto back-up şimdilik iptal
                        //BackupManager.RunBackup();
                    }
                    else
                    {
                        _dbService.CreateDatabase();
                        _dbService.CreateTable();
                    }
                }
                catch (Exception)
                {

                    throw;
                }

            };

            // Form üzerinde herhangi bir yere tıklandığında
            this.Click += (s, e) =>
            {
                //pnlReceipt.Visible = false;
                //pnlFindFolder.Visible = false;
                //flowLayoutPanelArchive.Visible = false;
                pnlBorder.Visible = false;
            };
        }


        private void btnChooseFileLocation_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    textBoxFileLocation.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool result = SaveProcess();
        }

        private void btnCreateReceipt_Click(object sender, EventArgs e)
        {
            pnlBorder.Visible = true;
            pnlReceipt.Visible = true;
            pnlFindFolder.Visible = false;
            flowLayoutPanelArchive.Visible = false;
            pnlDBprocess.Visible = false;
        }

        private void flowLayoutPanelArchive_Click(object sender, EventArgs e)
        {
            pnlBorder.Visible = true;
            flowLayoutPanelArchive.Visible = true;
            pnlFindFolder.Visible = false;
            pnlReceipt.Visible = false;
            pnlArchiveContents.Visible = false;
            lblExplanation.Visible = false;
            lblEmpty.Visible = false;
            pnlDBprocess.Visible = false;
        }

        private void btnGoTheFolder_Click(object sender, EventArgs e)
        {
            string folderPath = Path.Combine(textBoxFileLocation.Text, lblFileLocation.Text);
            if (!String.IsNullOrEmpty(folderPath))
            {
                try
                {
                    // Dosya yolunu ilişkilendirilmiş uygulamayla aç
                    //Process.Start(folderPath);
                    Process.Start(new ProcessStartInfo { FileName = folderPath, UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Henüz bir kayıt işlemi gerçekleşmedi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnGoTheReceipt_Click(object sender, EventArgs e)
        {
            string folderPath = Path.Combine(textBoxFileLocation.Text, lblFileLocation.Text, lblReceiptName.Text);
            if (!String.IsNullOrEmpty(folderPath))
            {
                try
                {
                    // Dosya yolunu ilişkilendirilmiş uygulamayla aç
                    //Process.Start(folderPath);
                    Process.Start(new ProcessStartInfo { FileName = folderPath, UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Henüz bir kayıt işlemi gerçekleşmedi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void ClearTextBoxes(Control container)
        {
            // Belirtilen konteyner içindeki tüm TextBox ve RichTextBox kontrollerini temizle
            foreach (Control control in container.Controls)
            {
                if (control is TextBox || control is RichTextBox)
                {
                    ((TextBoxBase)control).Clear();
                }
                else if (control.HasChildren)
                {
                    ClearTextBoxes(control); // Eğer kontrol içinde alt kontrol varsa, bu metodu tekrar çağır
                }
            }
        }

        private void btnTrash_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(pnlReceiptInputs);
            textBoxFileLocation.Clear();
            lblReceiptName.Text = "";
            lblFileLocation.Text = "";
            newReceipt = new Receipt();
        }

        private void TextBoxesAmount_TextChanged(object sender, EventArgs e)
        {
            setVisibleAfterSaveProcess(true);//kayıt işleminden sonra butonları göster

            // Hangi TextBox'ın değiştiğini kontrol et
            TextBox changedTextBox = (TextBox)sender;

            string text = changedTextBox.Text.Replace(",", ".");

            // Girilen değeri kontrol et ve decimal'e çevir
            if (String.IsNullOrEmpty(text)) text = "0";
            if (decimal.TryParse(text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal value))
            {
                decimal total = 0;
                if (decimal.TryParse(txtTotalAmount.Text.Replace(",", "."), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out total)) { }
                decimal received = 0;
                if (decimal.TryParse(txtReceivedAmount.Text.Replace(",", "."), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out received)) { }

                decimal remaining = total - received;
                txtRemainingAmount.Text = remaining.ToString(CultureInfo.InvariantCulture);

                txtTotalAmount.Text = txtTotalAmount.Text.Replace(".", ",");
                txtReceivedAmount.Text = txtReceivedAmount.Text.Replace(".", ",");
                txtRemainingAmount.Text = txtRemainingAmount.Text.Replace(".", ",");
                if (changedTextBox.Name == "txtReceivedAmount" && txtTotalAmount.Text.EndsWith(",")) txtTotalAmount.Text += "0";
                if (changedTextBox.Name == "txtTotalAmount" && txtReceivedAmount.Text.EndsWith(",")) txtReceivedAmount.Text += "0";
            }
            else
            {
                // Girilen değerler decimal'e çevrilemiyorsa veya herhangi bir hata varsa, işlemi gerçekleştirme
                txtRemainingAmount.Text = "Geçersiz";
            }
        }

        private void TextBox_LostFocus(object sender, EventArgs e)
        {
            TextBox lostFocusTextBox = (TextBox)sender;
            if (lostFocusTextBox.Text.EndsWith(","))
            {
                if (lostFocusTextBox.Name == "txtReceivedAmount" && txtReceivedAmount.Text.EndsWith(",")) txtReceivedAmount.Text += "0";
                if (lostFocusTextBox.Name == "txtTotalAmount" && txtTotalAmount.Text.EndsWith(",")) txtTotalAmount.Text += "0";
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintProcess();
        }

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            _receiptService.RenderReceiptPage(newReceipt, e);
        }



        void PrintProcess()
        {
            CreateReceipt();
            if (!String.IsNullOrEmpty(newReceipt.Name))
            {
                ////ön izleme ekranı ile:
                //printDocument1.DocumentName = "Makbuz";
                //printPreviewDialog1.Document = printDocument1;
                //if (printPreviewDialog1.Visible)
                //{
                //    printPreviewDialog1.Close();
                //}
                //printPreviewDialog1.ShowDialog();


                //Direkt yazdırma:
                printDocument1.DocumentName = "Makbuz";
                printDocument1.Print();
            }
            else
            {
                MessageBox.Show("Lütfen Ad Soyad girin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void CreateReceipt()
        {
            newReceipt = _receiptService.CreateReceipt(
                txtName.Text, txtDimensions.Text, txtNumQty.Text,
                txtTotalAmount.Text, txtReceivedAmount.Text, txtRemainingAmount.Text,
                txtDeliveryDate.Text, txtBoxNotes.Text);
        }

        bool SaveProcess(bool isSaveAndPrint = false)
        {
            if (String.IsNullOrEmpty(textBoxFileLocation.Text))
            {
                MessageBox.Show("Lütfen kayıt için konum seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            CreateReceipt();

            if (!string.IsNullOrWhiteSpace(newReceipt.Name))
            {
                try
                {
                    var (success, folderName, fileName, dupCount) =
                        _receiptService.SaveReceiptToFolder(newReceipt, textBoxFileLocation.Text);

                    if (!success) return false;

                    lblReceiptName.Text = fileName!;
                    lblFileLocation.Text = folderName!;
                    if (!isSaveAndPrint)
                    {
                        MessageBox.Show("Klasör ve dosya başarıyla oluşturuldu.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (dupCount > 0)
                    {
                        MessageBox.Show($"Daha önce aynı isimli kayıt olduğu için, yeni kaydınız \"{folderName}\" olarak oluşturuldu.", "Bilgilendirme!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    setVisibleAfterSaveProcess(false);

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Lütfen Ad Soyad girin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void setVisibleAfterSaveProcess(bool status)
        {
            btnSave.Visible = status;
            lblSave.Visible = status;
            btnSaveAndPrint.Visible = status;
            lblSaveAndPrint.Visible = status;
        }

        private void btnSaveAndPrint_Click(object sender, EventArgs e)
        {
            if (SaveProcess(true))
            {
                PrintProcess();
            }
        }

        private void btnFindFolder_Click(object sender, EventArgs e)
        {
            pnlBorder.Visible = true;
            pnlReceipt.Visible = false;
            pnlFindFolder.Visible = true;
            flowLayoutPanelArchive.Visible = false;
            pnlDBprocess.Visible = false;

            //pnlReceipt.SendToBack();
            //pnlFindFolder.BringToFront();

            PopulateDriveComboBox();
        }

        private void PopulateDriveComboBox()
        {
            // ComboBox'ı temizle
            cmbBoxDriver.Items.Clear();
            comboBoxDriversForRecord.Items.Clear();

            // Bilgisayardaki sürücüleri al
            DriveInfo[] drives = DriveInfo.GetDrives();

            // Sürücüleri ComboBox'a ekle
            foreach (DriveInfo drive in drives)
            {
                cmbBoxDriver.Items.Add(drive.Name);
                comboBoxDriversForRecord.Items.Add(drive.Name);
            }

            // ComboBox'da bir öğe seçili hale getirebilirsiniz, örneğin:
            if (cmbBoxDriver.Items.Count > 0)
            {
                cmbBoxDriver.SelectedIndex = 0;
                comboBoxDriversForRecord.SelectedIndex = 0;
            }
        }

        private void btnSearchFile_Click(object sender, EventArgs e)
        {
            Search(false);
        }

        private void Search(bool searchUpperFolderArchive = false)
        {
            // Dosya adını ve sürücüyü al
            string klasorAdi = "";
            string? secilenSurucu = "";
            if (!searchUpperFolderArchive)
            {
                klasorAdi = txtFileNameInput.Text.Trim();
                secilenSurucu = cmbBoxDriver.SelectedItem as string;
            }
            else
            {
                klasorAdi = txtDataUpperFileName.Text;
                secilenSurucu = comboBoxDriversForRecord.SelectedItem as string;
            }

            // Geçerli bir dosya adı ve sürücü var mı kontrol et
            if (!string.IsNullOrEmpty(klasorAdi) && !string.IsNullOrEmpty(secilenSurucu))
            {
                try
                {
                    Thread threadInput = new Thread(() => DisplayData(secilenSurucu, klasorAdi, searchUpperFolderArchive));
                    threadInput.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen klasör adını ve sürücüyü seçin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DisplayData(string secilenSurucu, string klasorAdi, bool searchUpperFolderArchive)
        {
            // Loading göstergesini göster
            SetLoading(true, searchUpperFolderArchive);

            // Diğer işlemler burada gerçekleştirilir
            ListFolderNames(secilenSurucu, klasorAdi, searchUpperFolderArchive);

            // Loading göstergesini gizle
            SetLoading(false, searchUpperFolderArchive);
        }

        private void SetLoading(bool displayLoader, bool searchUpperFolderArchive, bool addFolderToArchive = false, bool addDbToFolder = false, bool addSpareToArchive = false)
        {
            // this.Invoke ile UI thread üzerinde işlemler yapılır
            this.Invoke((MethodInvoker)delegate
            {
                if (displayLoader)
                {
                    // Loading göstergesini göster ve cursor'ı "wait" durumuna getir
                    this.Cursor = Cursors.WaitCursor;
                    if (searchUpperFolderArchive)
                    {
                        btnSearchArchive.Visible = false;
                        lblSearchArchive.Visible = false;
                        pictureBoxLoadingArchive.Visible = true;
                    }
                    else if (addFolderToArchive)
                    {
                        btnAddFolderToArchive.Visible = false;
                        lblAddFolderToArchive.Text = "Lütfen bekleyiniz..";
                        pictureBoxAddFolderToArchive.Visible = true;
                    }
                    else if (addDbToFolder)
                    {
                        btnDBtoFolder.Visible = false;
                        lblDbToFolder.Text = "Lütfen bekleyiniz..";
                        pictureBoxLoadingDbToFolder.Visible = true;
                    }
                    else if (addSpareToArchive)
                    {
                        btnSpareToArchive.Visible = false;
                        lblSpareToArchive.Text = "Lütfen bekleyiniz..";
                        pictureBoxLoadingSpareToArchive.Visible = true;
                    }
                    else
                    {
                        btnSearchFile.Visible = false;
                        lblSearchFile.Visible = false;
                        pictureBoxLoading.Visible = true;
                    }
                }
                else
                {
                    // Loading göstergesini gizle ve cursor'ı varsayılan duruma getir
                    this.Cursor = Cursors.Default;

                    if (searchUpperFolderArchive)
                    {
                        btnSearchArchive.Visible = true;
                        lblSearchArchive.Visible = true;
                        pictureBoxLoadingArchive.Visible = false;
                    }
                    else if (addFolderToArchive)
                    {
                        btnAddFolderToArchive.Visible = true;
                        lblAddFolderToArchive.Text = "Arşive Ekle";
                        pictureBoxAddFolderToArchive.Visible = false;
                    }
                    else if (addDbToFolder)
                    {
                        btnDBtoFolder.Visible = true;
                        lblDbToFolder.Text = "Arşivi Dosyaya Yedekle";
                        pictureBoxLoadingDbToFolder.Visible = false;
                    }
                    else if (addSpareToArchive)
                    {
                        btnSpareToArchive.Visible = true;
                        lblSpareToArchive.Text = "Yedek Dosyayı Arşive Ekle";
                        pictureBoxLoadingSpareToArchive.Visible = false;
                    }
                    else
                    {
                        btnSearchFile.Visible = true;
                        lblSearchFile.Visible = true;
                        pictureBoxLoading.Visible = false;
                    }
                }
            });
        }

        private void ListFolderNames(string dizinYolu, string arananKlasorAdi, bool searchUpperFolderArchive)
        {
            try
            {
                if (!searchUpperFolderArchive)
                    SetLoading(true, searchUpperFolderArchive);

                this.Invoke((MethodInvoker)delegate
                {
                    if (!searchUpperFolderArchive)
                    {
                        listBoxFiles.Items.Clear();
                    }
                    else
                    {
                        listBoxArchive.Items.Clear();
                    }
                });
                // Dizin içindeki klasörleri kontrol et
                DirectoryInfo di = new DirectoryInfo(dizinYolu);

                List<DirectoryInfo> erisilebilenKlasorler = [];
                List<DirectoryInfo> filtrelenmisKlasorler = [];
                if (!searchUpperFolderArchive)
                {
                    CheckDirectories(di, erisilebilenKlasorler);

                    filtrelenmisKlasorler = erisilebilenKlasorler
                    .Where(info => (info.Attributes & FileAttributes.Directory) == FileAttributes.Directory && info.Name.Contains(arananKlasorAdi, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                    foreach (var klasorDosya in filtrelenmisKlasorler)
                    {
                        // Klasör isimlerini alıyoruz
                        string klasorAdi = klasorDosya.FullName;
                        this.Invoke((MethodInvoker)delegate
                        {
                            listBoxFiles.Items.Add(klasorAdi);
                        });

                        // Yatay kaydırma çubuğunu güncelle
                    }

                    if (listBoxFiles.Items.Count == 0)
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            listBoxFiles.Items.Add("Bulunamadı");
                        });

                    }
                    this.Invoke((MethodInvoker)delegate
                    {
                        listBoxFiles.SelectedIndex = 0; // İlk öğeyi seç
                    });
                }

                else
                {
                    CheckDirectory(di, erisilebilenKlasorler, txtDataUpperFileName.Text);

                    filtrelenmisKlasorler = erisilebilenKlasorler;
                    //filtrelenmisKlasorler = erisilebilenKlasorler.Where(info => (info.Attributes & FileAttributes.Directory) == FileAttributes.Directory && info.Name.Equals(arananKlasorAdi, StringComparison.Ordinal)).ToList();

                    foreach (var klasorDosya in filtrelenmisKlasorler)
                    {
                        // Klasör isimlerini alıyoruz
                        string klasorAdi = klasorDosya.FullName;
                        this.Invoke((MethodInvoker)delegate
                        {
                            listBoxArchive.Items.Add(klasorAdi);
                        });

                        // Yatay kaydırma çubuğunu güncelle
                    }

                    if (listBoxArchive.Items.Count == 0)
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            listBoxArchive.Items.Add("Bulunamadı");
                        });

                    }
                    this.Invoke((MethodInvoker)delegate
                    {
                        listBoxArchive.SelectedIndex = 0; // İlk öğeyi seç
                    });
                }

            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Bu dizine erişme izniniz yok.", "Erişim İzni Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        static void CheckDirectories(DirectoryInfo currentDirectory, List<DirectoryInfo> accessibleDirectories)
        {
            accessibleDirectories.Add(currentDirectory);
            try
            {
                // UnauthorizedAccessException hatası alınmazsa, alt klasörleri ile birlikte kontrol et
                foreach (var subDirectory in currentDirectory.GetDirectories())
                {
                    CheckDirectories(subDirectory, accessibleDirectories);
                }
            }
            catch (UnauthorizedAccessException)
            {

            }
        }

        static void CheckDirectory(DirectoryInfo rootDirectory, List<DirectoryInfo> accessibleDirectories, string targetDirectoryName)
        {
            Queue<DirectoryInfo> queue = new Queue<DirectoryInfo>();
            queue.Enqueue(rootDirectory);

            while (queue.Count > 0)
            {
                DirectoryInfo currentDirectory = queue.Dequeue();

                try
                {
                    // Mevcut klasörün alt klasörlerini al
                    DirectoryInfo[] subDirectories = currentDirectory.GetDirectories();

                    // Mevcut klasör altındaki klasörleri döngüye al
                    foreach (var subDirectory in subDirectories)
                    {
                        // Alt klasörün adı hedef klasör adı ile eşleşiyorsa
                        if (subDirectory.Name.Equals(targetDirectoryName, StringComparison.OrdinalIgnoreCase))
                        {
                            // Eğer koşul sağlanıyorsa, klasörü listBox'a ekle
                            accessibleDirectories.Add(subDirectory);
                            return; // Bulunduğunda arama işleminden çık
                        }

                        // Alt klasörü arama kuyruğuna ekle
                        queue.Enqueue(subDirectory);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    // Eğer erişim izni yoksa devam et
                }
            }
        }

        private void ListBoxFiles_DoubleClick(object sender, EventArgs e)
        {
            // ListBox'ta çift tıklanan öğenin adını al
            string? secilenKlasor = listBoxFiles.SelectedItem as string;

            // Geçerli bir öğe seçildiyse ve "Bulunamadı" öğesi değilse işlem yap
            if (!string.IsNullOrEmpty(secilenKlasor) && secilenKlasor != "Bulunamadı")
            {
                // Klasör yolunu oluştur ve aç
                string? secilenSurucu = cmbBoxDriver.SelectedItem as string;
                string? klasorYolu = Path.Combine(secilenSurucu!, secilenKlasor);

                try
                {
                    Process.Start("explorer.exe", klasorYolu);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnMyComputer_Click(object sender, EventArgs e)
        {
            try
            {
                // Bilgisayarım'ı açmak için explorer.exe'yi başlat
                Process.Start("explorer.exe", "::{20D04FE0-3AEA-1069-A2D8-08002B30309D}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFileNameInput_KeyDown(object sender, KeyEventArgs e)
        {
            // Eğer Enter tuşuna basıldıysa
            if (e.KeyCode == Keys.Enter)
            {
                // Başka bir butonun Click olayını tetikle
                btnSearchFile.PerformClick();
            }
        }



        private void txtName_TextChanged(object sender, EventArgs e)
        {
            setVisibleAfterSaveProcess(true);
        }

        private void btnSearchPhoto_Click(object sender, EventArgs e)
        {
            lblEmpty.Text = btnSearchPhoto.Text + " :";
            lblExplanation.Visible = true;
            lblEmpty.Visible = true;
            lblExplanation.Text = ArchiveExplanations.SearchPhoto;
            pnlArchiveContents.Visible = true;
            pnlSearchPhoto.Visible = true;
            pnlAddFoldersToArchive.Visible = false;
            pnlAddSpareToArchive.Visible = false;
            pnlMakeSpare.Visible = false;
            listBoxArchive.Items.Clear();
            pnlDBprocess.Visible = false;
            PopulateDriveComboBox();
        }

        private void btnAddFoldersToArchive_Click(object sender, EventArgs e)
        {
            lblEmpty.Text = btnAddFoldersToArchive.Text + " :";
            txtChosenUpperFolder.Text = "";
            lblExplanation.Visible = true;
            lblEmpty.Visible = true;
            lblExplanation.Text = ArchiveExplanations.AddFoldersToArchive;
            pnlArchiveContents.Visible = true;
            pnlSearchPhoto.Visible = false;
            pnlAddFoldersToArchive.Visible = true;
            pnlAddSpareToArchive.Visible = false;
            pnlMakeSpare.Visible = false;
            pnlDBprocess.Visible = false;
        }

        private void btnMakeSpare_Click(object sender, EventArgs e)
        {
            lblEmpty.Text = btnMakeSpare.Text + " :";
            txtLocationForArchive.Text = "";
            lblExplanation.Visible = true;
            lblEmpty.Visible = true;
            lblExplanation.Text = ArchiveExplanations.MakeSpare;
            pnlArchiveContents.Visible = true;
            pnlSearchPhoto.Visible = false;
            pnlAddFoldersToArchive.Visible = false;
            pnlAddSpareToArchive.Visible = false;
            pnlMakeSpare.Visible = true;
            pnlDBprocess.Visible = false;
        }

        private void btnAddSpareToArchive_Click(object sender, EventArgs e)
        {
            lblEmpty.Text = btnAddSpareToArchive.Text + " :";
            txtLocationOfSpareFolder.Text = "";
            lblExplanation.Visible = true;
            lblEmpty.Visible = true;
            lblExplanation.Text = ArchiveExplanations.AddSpareToArchive;
            pnlArchiveContents.Visible = true;
            pnlSearchPhoto.Visible = false;
            pnlAddFoldersToArchive.Visible = false;
            pnlAddSpareToArchive.Visible = true;
            pnlMakeSpare.Visible = false;
            pnlDBprocess.Visible = false;
        }

        private void btnChooseUpperFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    txtChosenUpperFolder.Text = folderDialog.SelectedPath;
                    isUpperArchiveBtn = false;
                }
            }
        }

        private void btnChooseSpareFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    txtLocationOfSpareFolder.Text = folderDialog.SelectedPath;
                }
            }
        }

        private async void btnAddFolderToArchive_Click(object sender, EventArgs e)
        {
            string folderPath = txtChosenUpperFolder.Text;

            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show("Belirtilen klasör bulunamadı!");
                return;
            }
            string[] subDirectories = Directory.GetDirectories(folderPath);
            if (subDirectories.Length == 0)
            {
                MessageBox.Show("Belirtilen üst klasörde kaydedilecek alt klasör bulunamadı!");
                return;
            }
            SetLoading(true, false, true);
            await Task.Delay(1000);

            RecordStatus recordStatus = new RecordStatus();
            if (!isUpperArchiveBtn)
            {
                recordStatus = _dbService.RecordFoldersToDB(folderPath, subDirectories);
            }
            else
            {
                foreach (string subDirectory in subDirectories)
                {
                    ////Check record count:(max 20 for demo)
                    //using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
                    //{
                    //    connection.Open();
                    //    string checkCount = "SELECT COUNT(*) FROM customers";

                    //    using (NpgsqlCommand checkCommand = new NpgsqlCommand(checkCount, connection))
                    //    {
                    //        long totalExistingRecordsCount = (long)checkCommand.ExecuteScalar()!;
                    //        if (totalExistingRecordsCount > 19)
                    //        {
                    //            MessageBox.Show($"Demo programında maksimum 20 adet kayıt yapılabilmektedir!", "Üzgünüm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //            break;
                    //        }
                    //    }
                    //}

                    DirectoryInfo subDirInfo = new DirectoryInfo(subDirectory);
                    string subDirInfoName = subDirInfo.Name;
                    string subFolderPath = Path.Combine(folderPath, subDirInfoName);
                    string[] subDirs = Directory.GetDirectories(subFolderPath);
                    if (subDirs.Length > 0)
                    {
                        var subStatus = _dbService.RecordFoldersToDB(subFolderPath, subDirs);
                        recordStatus.totalInserts += subStatus.totalInserts;
                        recordStatus.successfulInserts += subStatus.successfulInserts;
                        recordStatus.duplicateRecords.AddRange(subStatus.duplicateRecords);
                        recordStatus.errorFullNames.AddRange(subStatus.errorFullNames);
                        recordStatus.noImageRecords.AddRange(subStatus.noImageRecords);
                        recordStatus.faultyImageRecords.AddRange(subStatus.faultyImageRecords);
                    }
                }
            }

            SetLoading(false, false, true);
            MessageBox.Show($"Toplam kayıt sayısı: {recordStatus.totalInserts}\nBaşarılı kayıt sayısı: {recordStatus.successfulInserts}\nTekrar ettiği için veri tabanına eklenMEYEN kayıt sayısı: {recordStatus.duplicateRecords!.Count} {string.Join(", ", recordStatus.duplicateRecords)}\nHata alındığı için veri tabanına ekleNEMEYEN kayıt sayısı: {recordStatus.errorFullNames.Count} {string.Join(", ", recordStatus.errorFullNames)}\n--------\nBAŞARILI KAYITLARDA İLAVE NOTLAR:\nUygun resmi olmayan kayıt sayısı: {recordStatus.noImageRecords.Count} {string.Join(", ", recordStatus.noImageRecords)}\nResmi bozuk veya işlenemeyen kayıt sayısı: {recordStatus.faultyImageRecords.Count} {string.Join(", ", recordStatus.faultyImageRecords)}");
        }



        private System.Windows.Forms.Timer _searchTimer;

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            if (_searchTimer == null)
            {
                _searchTimer = new System.Windows.Forms.Timer();
                _searchTimer.Interval = 400;
                _searchTimer.Tick += (s, ev) => 
                {
                    _searchTimer.Stop();
                    PerformSearch();
                };
            }
            _searchTimer.Stop();
            _searchTimer.Start();
        }

        private void PerformSearch()
        {
            txtDataUpperFileName.Text = "";
            listBoxArchive.Items.Clear();
            string searchText = txtFullName.Text.Trim().ToUpper(new CultureInfo("tr-TR"));

            try
            {
                DataTable dataTable = _dbService.SearchCustomers(searchText);

                dataGridRecords.DataSource = dataTable;
                dataGridRecords.Columns["id"].Visible = false;
                dataGridRecords.Columns["Ad Soyad"].HeaderText = "Ad Soyad:";
                lblTotalRecord.Text = dataGridRecords.RowCount.ToString();
                if (dataGridRecords.RowCount == 0)
                {
                    pictureBoxChosenPhoto.Image = null;
                    txtDataUpperFileName.Text = "";
                    listBoxArchive.Items.Clear();
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("3D000"))
                    MessageBox.Show($"Veri tabanı oluşturulmamış, Lütfen 'Veri Tabanı' işlemi menüsünde, veri tabanı oluşturunuz ve kayıtlarınızı ekleyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show($"Kayıt ararken hata oluştu! {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridRecords_SelectionChanged(object sender, EventArgs e)
        {
            int selectedId;
            if (dataGridRecords.CurrentRow != null && dataGridRecords.CurrentRow.Cells["id"].Value != null)
            {
                if (int.TryParse(dataGridRecords.CurrentRow.Cells["id"].Value.ToString(), out selectedId))
                {
                    var (folderName, photoData) = _dbService.GetCustomerDetail(selectedId);
                    txtDataUpperFileName.Text = folderName ?? "";

                    if (photoData != null)
                    {
                        using var ms = new System.IO.MemoryStream(photoData);
                        try
                        {
                            pictureBoxChosenPhoto.Image?.Dispose();
                            var image = Image.FromStream(ms);
                            pictureBoxChosenPhoto.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBoxChosenPhoto.Image = image;
                        }
                        catch (Exception)
                        {
                            pictureBoxChosenPhoto.Image = null;
                        }
                    }
                    else
                    {
                        pictureBoxChosenPhoto.Image = null;
                    }
                }
                else
                {
                    pictureBoxChosenPhoto.Image = null;
                }
            }
            else
            {
                pictureBoxChosenPhoto.Image = null;
            }
        }

        private void btnGoRecord_Click(object sender, EventArgs e)
        {
            if (dataGridRecords.CurrentRow != null && dataGridRecords.CurrentRow.Cells["Ad Soyad"] != null && dataGridRecords.CurrentRow.Cells["Ad Soyad"].Value != null)
            {
                // txtDataUpperFileName ve comboBoxDriversForRecord boş olmamalıdır
                if (string.IsNullOrEmpty(txtDataUpperFileName.Text) || comboBoxDriversForRecord.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen klasör adını ve sürücüyü seçin.");
                    return;
                }
                // ListBox'taki öğenin adını al
                string? selectedUpperFolder = listBoxArchive.SelectedItem as string;

                // Geçerli bir öğe seçildiyse ve "Bulunamadı" öğesi değilse işlem yap
                if (!string.IsNullOrEmpty(selectedUpperFolder) && selectedUpperFolder != "Bulunamadı")
                {
                    // Klasör yolunu oluştur ve aç
                    string selectedFullName = dataGridRecords.CurrentRow.Cells["Ad Soyad"].Value.ToString()!;
                    string? completePath = Path.Combine(selectedUpperFolder, selectedFullName!);

                    // Klasörün varlığını kontrol et
                    if (Directory.Exists(completePath))
                    {
                        try
                        {
                            Process.Start("explorer.exe", completePath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Klasör açılamadı: " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Belirtilen klasör bulunamadı: " + completePath);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Ad Soyad tablosundan bir kayıt seçin!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearchArchive_Click(object sender, EventArgs e)
        {
            Search(true);
        }

        private void btnLocationForArchive_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    txtLocationForArchive.Text = folderDialog.SelectedPath;
                }
            }
        }

        private async void btnDBtoFolder_Click(object sender, EventArgs e)
        {
            string folderPath = txtLocationForArchive.Text;

            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show("Belirtilen klasör bulunamadı!");
                return;
            }

            try
            {
                SetLoading(true, false, false, true);
                await Task.Delay(2000);

                var exportedData = _dbService.ExportAllCustomers();
                foreach (var item in exportedData)
                {
                    string fileName = $"{item.fullName}_{item.folderName}.jpg";
                    string filePath = Path.Combine(folderPath, fileName);
                    ImageService.SavePhotoDataAsJpeg(item.photoData, filePath, item.createDate);
                }

                SetLoading(false, false, false, true);
                MessageBox.Show("Veritabanındaki veriler başarıyla klasöre kaydedildi!");
            }
            catch (Exception ex)
            {
                SetLoading(false, false, false, true);
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
        }

        
        private async void btnSpareToArchive_Click(object sender, EventArgs e)
        {
            string folderPath = txtLocationOfSpareFolder.Text;

            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show("Belirtilen klasör bulunamadı!");
                return;
            }
            SetLoading(true, false, false, false, true);
            await Task.Delay(2000);

            var result = _dbService.ImportSpareToArchive(folderPath);

            SetLoading(false, false, false, false, true);
            MessageBox.Show($"Toplam kayıt sayısı: {result.totalInserts}\nBaşarılı kayıt sayısı: {result.successfulInserts}\nTekrar eden kayıt sayısı: {result.duplicateRecords.Count} {string.Join(", ", result.duplicateRecords)}\nİsmi uygun olmayan kayıt sayısı: {result.wrongFormatRecords.Count} {string.Join(", ", result.wrongFormatRecords)}\nResim olmayan kayıt sayısı: {result.notImages.Count} {string.Join(", ", result.notImages)}\nVeritabanına kayıt esnasında hata alınan kayıt sayısı: {result.errorFullNames.Count} {string.Join(", ", result.errorFullNames)}");
        }

        
        private void btnUpperArchiveFoldersToDB_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    txtChosenUpperFolder.Text = folderDialog.SelectedPath;
                    isUpperArchiveBtn = true;
                }
            }
        }

        private async void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            int selectedRowId;
            if (dataGridRecords.CurrentRow != null && dataGridRecords.CurrentRow.Cells["id"].Value != null)
            {
                if (int.TryParse(dataGridRecords.CurrentRow.Cells["id"].Value.ToString(), out selectedRowId))
                {
                    object fullNameObject = dataGridRecords.CurrentRow.Cells["Ad Soyad"].Value;
                    string selectedFullName = fullNameObject != null ? fullNameObject.ToString()! : string.Empty;
                    if (string.IsNullOrEmpty(selectedFullName))
                    {
                        MessageBox.Show("Lütfen Ad Soyad girin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    selectedFullName = selectedFullName.Trim();
                    DialogResult result = MessageBox.Show("Kaydı güncellemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (PasswordDialog.Authenticate(this, pswUpdate))
                        {
                            try
                            {

                                _dbService.UpdateCustomerName(selectedRowId, selectedFullName);


                                MessageBox.Show("Kayıt başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                PerformSearch();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Kayıt güncellenirken hata oluştu! {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                }
            }




        }

        private async void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            int selectedRowId;

            if (dataGridRecords.CurrentRow != null && dataGridRecords.CurrentRow.Cells["id"].Value != null)
            {
                if (int.TryParse(dataGridRecords.CurrentRow.Cells["id"].Value.ToString(), out selectedRowId))
                {
                    DialogResult result = MessageBox.Show("Kaydı silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            if (!PasswordDialog.Authenticate(this, pswDelete))
                                return;

                            _dbService.DeleteCustomer(selectedRowId);


                            MessageBox.Show("Kayıt başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            PerformSearch();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Kayıt silme işleminde hata oluştu! {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private async void btnDB_Click(object sender, EventArgs e)
        {
            pnlBorder.Visible = false;
            pnlReceipt.Visible = false;
            pnlFindFolder.Visible = false;
            flowLayoutPanelArchive.Visible = false;
            if (PasswordDialog.Authenticate(this, pswDBprocess, "Veri tabanı işlemleri için \nlütfen yönetici şifresini giriniz:"))
            {
                pnlBorder.Visible = true;
                pnlDBprocess.Visible = true;
            }

        }

        private void btnCreateDB_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the database exists
                if (_dbService.CheckDatabaseExists())
                {
                    MessageBox.Show("Veri tabanı zaten mevcut", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _dbService.CreateDatabase();
                    _dbService.CreateTable();
                    MessageBox.Show("Veri tabanı başarıyla oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                //MessageBox.Show($"Veri tabanı oluşturulurken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Veri tabanı oluşturulurken bir hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnRemoveDB_Click(object sender, EventArgs e)
        {
            if (_dbService.CheckDatabaseExists())
            {
                DialogResult result = MessageBox.Show("Veri tabanınızı !!!Geri Getiremeyecek Şekilde!!! silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (!PasswordDialog.Authenticate(this, pswDelete))
                            return;

                        DialogResult resultLast = MessageBox.Show("Veri tabanınız tamamen kaldırılacak, onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultLast != DialogResult.Yes)
                            return;

                        _dbService.RemoveDatabase();
                        MessageBox.Show("Veri tabanı başarıyla kaldırıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Veri tabanı kaldırılırken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Veri tabanı sistemde mevcut değil", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDownloadDB_Click(object sender, EventArgs e)
        {
            try
            {
                string localDatabasePath = txtDownloadDBLocation.Text;

                if (string.IsNullOrEmpty(localDatabasePath))
                {
                    MessageBox.Show($"Lütfen yedekleme dosyasını oluşturacağınız bir konum seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                BackupService.RunBackup(localDatabasePath);
                MessageBox.Show("Yedek alma işlemi tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Yedek dosyası oluşturulurken hata meydana geldi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }



        private void btnDownloadDBLocation_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    txtDownloadDBLocation.Text = dialog.SelectedPath;
                }
            }
        }

        private void btnUploadDBLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PostgreSQL Backup Files (*.tar)|*.tar";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtUploadDBLocation.Text = openFileDialog.FileName;
            }
        }

        private async void btnUploadDB_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtUploadDBLocation.Text))
                {
                    MessageBox.Show("Lütfen geri yüklemek için bir dosya seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult result = MessageBox.Show("Seçtiğiniz yedek dosyası yüklenirken mevcut veri tabanınız silinmiş olacak, devam etmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (PasswordDialog.Authenticate(this, pswDelete))
                    {
                        if (!_dbService.CheckDatabaseExists())
                        {
                            _dbService.CreateDatabase();
                        }
                        else
                        {
                            _dbService.RemoveDatabase();
                            await Task.Delay(1000);
                            _dbService.CreateDatabase();
                        }
                        await Task.Delay(2000);
                        BackupService.RunRestore(txtUploadDBLocation.Text);
                        MessageBox.Show("Veritabanı geri yükleme işlemi tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veritabanı geri yükleme işleminde bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }



    }
}

