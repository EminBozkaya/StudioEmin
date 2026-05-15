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
        private static string pswDBprocess => AppConfig.PasswordDBProcess;
        private static string pswDelete => AppConfig.PasswordDelete;
        private static string pswUpdate => AppConfig.PasswordUpdate;

        private readonly DatabaseService _dbService = new();
        private readonly ReceiptService _receiptService = new();

        private bool isUpperArchiveBtn = false;
        private Receipt newReceipt = new();
        private Bitmap? _globeIcon;
        private string _currentLangCode = "TR";

        public Form1()
        {
            LanguageManager.Initialize();
            InitializeComponent();

            this.Load += (s, e) =>
            {
                this.Width = 1720;
                this.Height = 975;
                textBoxFileLocation.Multiline = false;
                textBoxFileLocation.ScrollBars = ScrollBars.Vertical;

                pictureBoxLoading.Visible = false;
                pictureBoxLoadingArchive.Visible = false;
                pictureBoxAddFolderToArchive.Visible = false;
                pictureBoxLoadingDbToFolder.Visible = false;
                pictureBoxLoadingSpareToArchive.Visible = false;
                pnlBorder.Visible = false;

                ApplyLanguage();
                PopulateLanguageMenu();

                try
                {
                    if (_dbService.CheckDatabaseExists())
                    {
                        // auto backup is disabled
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

            this.Click += (s, e) =>
            {
                pnlBorder.Visible = false;
            };
        }

        private void ApplyLanguage()
        {
            var L = LanguageManager.GetString;

            this.Text = L("app_title");

            lblBilgisayarım.Text = L("nav_myComputer");
            lblKlasörAra.Text = L("nav_findFolder");
            lblMakbuzKes.Text = L("nav_createReceipt");
            lblArşiv.Text = L("nav_archive");
            lblVeriTabanı.Text = L("nav_database");

            lblName.Text = L("receipt_name");
            lblEbat.Text = L("receipt_dimensions");
            lblAdet.Text = L("receipt_quantity");
            lblTutar.Text = L("receipt_total");
            lblAlınan.Text = L("receipt_received");
            lblKalan.Text = L("receipt_remaining");
            lblTeslimTarihi.Text = L("receipt_deliveryDate");
            lblNot.Text = L("receipt_notes");
            lblAdSoyadkısmındaaltçizgi_KULLANMAYINIZ.Text = L("receipt_nameWarning");
            lblSeçilenKonum.Text = L("receipt_selectedLocation");
            lblReceiptCaption.Text = L("receipt_createdReceipt");
            lblKlasör.Text = L("receipt_folder");
            lblMakbuzAdı.Text = L("receipt_receiptName");
            lblKlasöreGit.Text = L("receipt_goToFolder");
            lblMakbuzaGit.Text = L("receipt_goToReceipt");
            lblSave.Text = L("receipt_save");
            lblSaveAndPrint.Text = L("receipt_saveAndPrint");
            lblYazdır.Text = L("receipt_print");
            lblFormuTemizle.Text = L("receipt_clearForm");

            lblSürücüSeç.Text = L("find_selectDrive");
            lblKlasörAdıGir.Text = L("find_enterFolderName");
            lblSearchFile.Text = L("find_search");
            lblBulunanKlasörler.Text = L("find_foundFolders");

            lblMainArchiveCaption.Text = L("archive_title");
            btnSearchPhoto.Text = L("archive_searchRecord");
            btnAddFoldersToArchive.Text = L("archive_addFolders");
            btnMakeSpare.Text = L("archive_backup");
            btnAddSpareToArchive.Text = L("archive_loadBackup");

            lblFullName.Text = L("search_enterName");
            lblFound.Text = L("search_foundRecords");
            lblFoundPhoto.Text = L("search_representativePhoto");
            lblKayıtSayısı.Text = L("search_recordCount");
            lblSeçilenKaydınBulunduğuÜstKlasör.Text = L("search_parentFolder");
            lblKaydıGüncelle.Text = L("search_updateRecord");
            lblKaydıSil.Text = L("search_deleteRecord");
            lblKaydınKlasörünüAçmakİçin.Text = L("search_openFolderTitle");
            lblChooseDriver.Text = L("search_selectDriveFirst");
            lblSearchArchive.Text = L("search_searchParentFolder");
            lblGoRecord.Text = L("search_goToRecordFolder");
            lblGit.Text = L("search_go");

            lblHazırlamışolduğunuz.Text = L("addFolder_prepared");
            lblmüşterilerinkayıtdosyalarınıbulunduran.Text = L("addFolder_containing");
            lblÜSTKLASÖRÜNÜZÜSeçiniz.Text = L("addFolder_selectParent");
            lblArşiveEklemekİçinSeçilenÜstKlasör.Text = L("addFolder_selectedParent");
            lblAddFolderToArchive.Text = L("addFolder_addToArchive");
            lblVeya.Text = L("addFolder_or");
            lblÖncedenArşiveeklemeküzerehazırladığınız.Text = L("addFolder_previouslyPrepared");
            lblÜSTklasörleribarındıran.Text = L("addFolder_containingParent");
            lblGenelÜSTARŞİVKLASÖRÜNÜZÜSeçiniz.Text = L("addFolder_selectGeneralParent");

            lblVeriTabanındakiarşiviyedeklemekiçin.Text = L("spare_backupArchiveLabel");
            lblDosyaKonumuSeçiniz.Text = L("spare_selectLocation");
            lblSeçilenKonum3.Text = L("spare_selectedLocation");
            lblDbToFolder.Text = L("spare_backupToFile");

            lblDahaöncedenyedeklediğiniz.Text = L("restore_previouslyBacked");
            lblDosyayıSeçiniz.Text = L("restore_selectFile");
            lblSeçilenYedekDosyası.Text = L("restore_selectedFile");
            lblSpareToArchive.Text = L("restore_loadToArchive");

            lblVeriTabanınıOluştur.Text = L("db_create");
            lblVeriTabanınıYedekle.Text = L("db_backup");
            lblYedektenVeriTabanınıOluştur.Text = L("db_restoreFromBackup");
            lblVeriTabanınıSil.Text = L("db_delete");
            lblSeçilenKonum2.Text = L("db_selectedLocation");
            lblSeçilenYedek.Text = L("db_selectedBackup");
            richTextBox2.Text = L("db_info_create");
            richTextBox1.Text = L("db_info_backup");
            richTextBox3.Text = L("db_info_restore");
            richTextBox4.Text = L("db_info_delete");
        }

        private void PopulateLanguageMenu()
        {
            _globeIcon = Extensions.Resources.btnLanguage;
            _currentLangCode = LanguageManager.CurrentLanguage.ToUpper(new System.Globalization.CultureInfo("en-US"));

            ctxLanguageMenu.Items.Clear();
            var languages = LanguageManager.GetAvailableLanguages();

            foreach (var lang in languages)
            {
                var item = new ToolStripMenuItem(lang.Name)
                {
                    Tag = lang,
                    Checked = lang.Code == LanguageManager.CurrentLanguage
                };
                item.Click += LanguageMenuItem_Click;
                ctxLanguageMenu.Items.Add(item);
            }

            btnLanguage.Invalidate();
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            ctxLanguageMenu.Show(btnLanguage, new Point(0, -ctxLanguageMenu.PreferredSize.Height));
        }

        private void btnLanguage_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            if (_globeIcon != null)
                g.DrawImage(_globeIcon, 2, 2, 66, 66);

            using var font = new Font("Segoe UI", 13F, FontStyle.Bold);
            var text = _currentLangCode;
            var textSize = g.MeasureString(text, font);
            float tx = (btnLanguage.Width - textSize.Width) / 2f;
            float ty = (btnLanguage.Height - textSize.Height) / 2f;

            using var bgBrush = new SolidBrush(Color.FromArgb(180, 0, 0, 0));
            float pad = 3;
            var bgRect = new RectangleF(tx - pad, ty - pad, textSize.Width + pad * 2, textSize.Height + pad * 2);
            using var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddRectangle(bgRect);
            g.FillPath(bgBrush, path);

            using var brush = new SolidBrush(Color.White);
            g.DrawString(text, font, brush, tx, ty);
        }

        private void LanguageMenuItem_Click(object? sender, EventArgs e)
        {
            if (sender is not ToolStripMenuItem menuItem) return;
            if (menuItem.Tag is not LanguageInfo selected) return;
            if (selected.Code == LanguageManager.CurrentLanguage) return;

            var result = MessageBox.Show(
                LanguageManager.GetString("lang_restartMessage"),
                LanguageManager.GetString("lang_restartTitle"),
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LanguageManager.SetLanguage(selected.Code);
                Application.Restart();
            }
        }

        private void btnChooseFileLocation_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderDialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                    textBoxFileLocation.Text = folderDialog.SelectedPath;
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
                    Process.Start(new ProcessStartInfo { FileName = folderPath, UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        string.Format(LanguageManager.GetString("msg_errorOccurred"), ex.Message),
                        LanguageManager.GetString("msg_error"),
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(
                    LanguageManager.GetString("msg_noRecordYet"),
                    LanguageManager.GetString("msg_warning"),
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGoTheReceipt_Click(object sender, EventArgs e)
        {
            string folderPath = Path.Combine(textBoxFileLocation.Text, lblFileLocation.Text, lblReceiptName.Text);
            if (!String.IsNullOrEmpty(folderPath))
            {
                try
                {
                    Process.Start(new ProcessStartInfo { FileName = folderPath, UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        string.Format(LanguageManager.GetString("msg_errorOccurred"), ex.Message),
                        LanguageManager.GetString("msg_error"),
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(
                    LanguageManager.GetString("msg_noRecordYet"),
                    LanguageManager.GetString("msg_warning"),
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearTextBoxes(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is TextBox || control is RichTextBox)
                    ((TextBoxBase)control).Clear();
                else if (control.HasChildren)
                    ClearTextBoxes(control);
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
            setVisibleAfterSaveProcess(true);

            TextBox changedTextBox = (TextBox)sender;
            string text = changedTextBox.Text.Replace(",", ".");

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
                txtRemainingAmount.Text = LanguageManager.GetString("receipt_invalidAmount");
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
                printDocument1.DocumentName = "Makbuz";
                printDocument1.Print();
            }
            else
            {
                MessageBox.Show(
                    LanguageManager.GetString("msg_enterName"),
                    LanguageManager.GetString("msg_warning"),
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show(
                    LanguageManager.GetString("msg_selectSaveLocation"),
                    LanguageManager.GetString("msg_warning"),
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show(
                            LanguageManager.GetString("msg_folderFileCreated"),
                            LanguageManager.GetString("msg_success"),
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (dupCount > 0)
                    {
                        MessageBox.Show(
                            string.Format(LanguageManager.GetString("msg_duplicateFolder"), folderName),
                            LanguageManager.GetString("msg_notification"),
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    setVisibleAfterSaveProcess(false);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        string.Format(LanguageManager.GetString("msg_errorOccurred"), ex.Message),
                        LanguageManager.GetString("msg_error"),
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show(
                    LanguageManager.GetString("msg_enterName"),
                    LanguageManager.GetString("msg_warning"),
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                PrintProcess();
        }

        private void btnFindFolder_Click(object sender, EventArgs e)
        {
            pnlBorder.Visible = true;
            pnlReceipt.Visible = false;
            pnlFindFolder.Visible = true;
            flowLayoutPanelArchive.Visible = false;
            pnlDBprocess.Visible = false;

            PopulateDriveComboBox();
        }

        private void PopulateDriveComboBox()
        {
            cmbBoxDriver.Items.Clear();
            comboBoxDriversForRecord.Items.Clear();

            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                cmbBoxDriver.Items.Add(drive.Name);
                comboBoxDriversForRecord.Items.Add(drive.Name);
            }

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

            if (!string.IsNullOrEmpty(klasorAdi) && !string.IsNullOrEmpty(secilenSurucu))
            {
                try
                {
                    Thread threadInput = new Thread(() => DisplayData(secilenSurucu, klasorAdi, searchUpperFolderArchive));
                    threadInput.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        string.Format(LanguageManager.GetString("msg_errorOccurred"), ex.Message),
                        LanguageManager.GetString("msg_error"),
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(
                    LanguageManager.GetString("msg_selectFolderAndDrive"),
                    LanguageManager.GetString("msg_missingInfo"),
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DisplayData(string secilenSurucu, string klasorAdi, bool searchUpperFolderArchive)
        {
            SetLoading(true, searchUpperFolderArchive);
            ListFolderNames(secilenSurucu, klasorAdi, searchUpperFolderArchive);
            SetLoading(false, searchUpperFolderArchive);
        }

        private void SetLoading(bool displayLoader, bool searchUpperFolderArchive, bool addFolderToArchive = false, bool addDbToFolder = false, bool addSpareToArchive = false)
        {
            this.Invoke((MethodInvoker)delegate
            {
                if (displayLoader)
                {
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
                        lblAddFolderToArchive.Text = LanguageManager.GetString("loading_pleaseWait");
                        pictureBoxAddFolderToArchive.Visible = true;
                    }
                    else if (addDbToFolder)
                    {
                        btnDBtoFolder.Visible = false;
                        lblDbToFolder.Text = LanguageManager.GetString("loading_pleaseWait");
                        pictureBoxLoadingDbToFolder.Visible = true;
                    }
                    else if (addSpareToArchive)
                    {
                        btnSpareToArchive.Visible = false;
                        lblSpareToArchive.Text = LanguageManager.GetString("loading_pleaseWait");
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
                        lblAddFolderToArchive.Text = LanguageManager.GetString("loading_addToArchive");
                        pictureBoxAddFolderToArchive.Visible = false;
                    }
                    else if (addDbToFolder)
                    {
                        btnDBtoFolder.Visible = true;
                        lblDbToFolder.Text = LanguageManager.GetString("loading_backupToFile");
                        pictureBoxLoadingDbToFolder.Visible = false;
                    }
                    else if (addSpareToArchive)
                    {
                        btnSpareToArchive.Visible = true;
                        lblSpareToArchive.Text = LanguageManager.GetString("loading_loadBackupToArchive");
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
                        listBoxFiles.Items.Clear();
                    else
                        listBoxArchive.Items.Clear();
                });

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
                        string klasorAdi = klasorDosya.FullName;
                        this.Invoke((MethodInvoker)delegate { listBoxFiles.Items.Add(klasorAdi); });
                    }

                    if (listBoxFiles.Items.Count == 0)
                        this.Invoke((MethodInvoker)delegate { listBoxFiles.Items.Add(LanguageManager.GetString("find_notFound")); });

                    this.Invoke((MethodInvoker)delegate { listBoxFiles.SelectedIndex = 0; });
                }
                else
                {
                    CheckDirectory(di, erisilebilenKlasorler, txtDataUpperFileName.Text);
                    filtrelenmisKlasorler = erisilebilenKlasorler;

                    foreach (var klasorDosya in filtrelenmisKlasorler)
                    {
                        string klasorAdi = klasorDosya.FullName;
                        this.Invoke((MethodInvoker)delegate { listBoxArchive.Items.Add(klasorAdi); });
                    }

                    if (listBoxArchive.Items.Count == 0)
                        this.Invoke((MethodInvoker)delegate { listBoxArchive.Items.Add(LanguageManager.GetString("find_notFound")); });

                    this.Invoke((MethodInvoker)delegate { listBoxArchive.SelectedIndex = 0; });
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(
                    LanguageManager.GetString("msg_noAccessPermission"),
                    LanguageManager.GetString("msg_error"),
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, LanguageManager.GetString("msg_error"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        static void CheckDirectories(DirectoryInfo currentDirectory, List<DirectoryInfo> accessibleDirectories)
        {
            accessibleDirectories.Add(currentDirectory);
            try
            {
                foreach (var subDirectory in currentDirectory.GetDirectories())
                    CheckDirectories(subDirectory, accessibleDirectories);
            }
            catch (UnauthorizedAccessException) { }
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
                    DirectoryInfo[] subDirectories = currentDirectory.GetDirectories();
                    foreach (var subDirectory in subDirectories)
                    {
                        if (subDirectory.Name.Equals(targetDirectoryName, StringComparison.OrdinalIgnoreCase))
                        {
                            accessibleDirectories.Add(subDirectory);
                            return;
                        }
                        queue.Enqueue(subDirectory);
                    }
                }
                catch (UnauthorizedAccessException) { }
            }
        }

        private void ListBoxFiles_DoubleClick(object sender, EventArgs e)
        {
            string? secilenKlasor = listBoxFiles.SelectedItem as string;
            string notFoundText = LanguageManager.GetString("find_notFound");

            if (!string.IsNullOrEmpty(secilenKlasor) && secilenKlasor != notFoundText)
            {
                string? secilenSurucu = cmbBoxDriver.SelectedItem as string;
                string? klasorYolu = Path.Combine(secilenSurucu!, secilenKlasor);
                try
                {
                    Process.Start("explorer.exe", klasorYolu);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        string.Format(LanguageManager.GetString("msg_errorOccurred"), ex.Message),
                        LanguageManager.GetString("msg_error"),
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnMyComputer_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", "::{20D04FE0-3AEA-1069-A2D8-08002B30309D}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    string.Format(LanguageManager.GetString("msg_errorOccurred"), ex.Message),
                    LanguageManager.GetString("msg_error"),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFileNameInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearchFile.PerformClick();
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
                    txtLocationOfSpareFolder.Text = folderDialog.SelectedPath;
            }
        }

        private async void btnAddFolderToArchive_Click(object sender, EventArgs e)
        {
            string folderPath = txtChosenUpperFolder.Text;

            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show(LanguageManager.GetString("msg_folderNotFound"));
                return;
            }
            string[] subDirectories = Directory.GetDirectories(folderPath);
            if (subDirectories.Length == 0)
            {
                MessageBox.Show(LanguageManager.GetString("msg_noSubFoldersFound"));
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

            var L = LanguageManager.GetString;
            MessageBox.Show(
                string.Format(L("msg_archiveResult_total"), recordStatus.totalInserts) + "\n" +
                string.Format(L("msg_archiveResult_success"), recordStatus.successfulInserts) + "\n" +
                string.Format(L("msg_archiveResult_duplicate"), recordStatus.duplicateRecords!.Count, string.Join(", ", recordStatus.duplicateRecords)) + "\n" +
                string.Format(L("msg_archiveResult_error"), recordStatus.errorFullNames.Count, string.Join(", ", recordStatus.errorFullNames)) + "\n" +
                "--------\n" +
                L("msg_archiveResult_successNotes") + "\n" +
                string.Format(L("msg_archiveResult_noImage"), recordStatus.noImageRecords.Count, string.Join(", ", recordStatus.noImageRecords)) + "\n" +
                string.Format(L("msg_archiveResult_faultyImage"), recordStatus.faultyImageRecords.Count, string.Join(", ", recordStatus.faultyImageRecords)));
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
                dataGridRecords.Columns["Ad Soyad"].HeaderText = LanguageManager.GetString("search_dataGridHeaderFullName");
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
                    MessageBox.Show(
                        LanguageManager.GetString("msg_dbNotCreated"),
                        LanguageManager.GetString("msg_error"),
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(
                        string.Format(LanguageManager.GetString("msg_searchError"), ex.Message),
                        LanguageManager.GetString("msg_error"),
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (string.IsNullOrEmpty(txtDataUpperFileName.Text) || comboBoxDriversForRecord.SelectedItem == null)
                {
                    MessageBox.Show(LanguageManager.GetString("msg_selectFolderAndDrive"));
                    return;
                }
                string? selectedUpperFolder = listBoxArchive.SelectedItem as string;
                string notFoundText = LanguageManager.GetString("find_notFound");

                if (!string.IsNullOrEmpty(selectedUpperFolder) && selectedUpperFolder != notFoundText)
                {
                    string selectedFullName = dataGridRecords.CurrentRow.Cells["Ad Soyad"].Value.ToString()!;
                    string? completePath = Path.Combine(selectedUpperFolder, selectedFullName!);

                    if (Directory.Exists(completePath))
                    {
                        try
                        {
                            Process.Start("explorer.exe", completePath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(string.Format(LanguageManager.GetString("msg_folderCannotOpen"), ex.Message));
                        }
                    }
                    else
                    {
                        MessageBox.Show(string.Format(LanguageManager.GetString("msg_folderNotFoundPath"), completePath));
                    }
                }
            }
            else
            {
                MessageBox.Show(
                    LanguageManager.GetString("msg_selectNameFromTable"),
                    LanguageManager.GetString("msg_missingInfo"),
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    txtLocationForArchive.Text = folderDialog.SelectedPath;
            }
        }

        private async void btnDBtoFolder_Click(object sender, EventArgs e)
        {
            string folderPath = txtLocationForArchive.Text;

            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show(LanguageManager.GetString("msg_folderNotFound"));
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
                MessageBox.Show(LanguageManager.GetString("msg_dbSavedToFolder"));
            }
            catch (Exception ex)
            {
                LogService.LogError(ex, LanguageManager.GetString("log_dbToFolderError"));
                SetLoading(false, false, false, true);
                MessageBox.Show(string.Format(LanguageManager.GetString("msg_errorOccurred"), ex.Message));
            }
        }

        private async void btnSpareToArchive_Click(object sender, EventArgs e)
        {
            string folderPath = txtLocationOfSpareFolder.Text;

            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show(LanguageManager.GetString("msg_folderNotFound"));
                return;
            }
            SetLoading(true, false, false, false, true);
            await Task.Delay(2000);

            var result = _dbService.ImportSpareToArchive(folderPath);

            SetLoading(false, false, false, false, true);

            var L = LanguageManager.GetString;
            MessageBox.Show(
                string.Format(L("msg_spareResult_total"), result.totalInserts) + "\n" +
                string.Format(L("msg_spareResult_success"), result.successfulInserts) + "\n" +
                string.Format(L("msg_spareResult_duplicate"), result.duplicateRecords.Count, string.Join(", ", result.duplicateRecords)) + "\n" +
                string.Format(L("msg_spareResult_wrongFormat"), result.wrongFormatRecords.Count, string.Join(", ", result.wrongFormatRecords)) + "\n" +
                string.Format(L("msg_spareResult_notImage"), result.notImages.Count, string.Join(", ", result.notImages)) + "\n" +
                string.Format(L("msg_spareResult_dbError"), result.errorFullNames.Count, string.Join(", ", result.errorFullNames)));
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
                        MessageBox.Show(
                            LanguageManager.GetString("msg_enterName"),
                            LanguageManager.GetString("msg_warning"),
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    selectedFullName = selectedFullName.Trim();
                    DialogResult result = MessageBox.Show(
                        LanguageManager.GetString("msg_confirmUpdate"),
                        LanguageManager.GetString("msg_warning"),
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (PasswordDialog.Authenticate(this, pswUpdate))
                        {
                            try
                            {
                                _dbService.UpdateCustomerName(selectedRowId, selectedFullName);
                                MessageBox.Show(
                                    LanguageManager.GetString("msg_recordUpdated"),
                                    LanguageManager.GetString("msg_success"),
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                PerformSearch();
                            }
                            catch (Exception ex)
                            {
                                LogService.LogError(ex, LanguageManager.GetString("log_recordUpdateError"));
                                MessageBox.Show(
                                    string.Format(LanguageManager.GetString("msg_updateError"), ex.Message),
                                    LanguageManager.GetString("msg_error"),
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    DialogResult result = MessageBox.Show(
                        LanguageManager.GetString("msg_confirmDelete"),
                        LanguageManager.GetString("msg_warning"),
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            if (!PasswordDialog.Authenticate(this, pswDelete))
                                return;

                            _dbService.DeleteCustomer(selectedRowId);
                            MessageBox.Show(
                                LanguageManager.GetString("msg_recordDeleted"),
                                LanguageManager.GetString("msg_success"),
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            PerformSearch();
                        }
                        catch (Exception ex)
                        {
                            LogService.LogError(ex, LanguageManager.GetString("log_recordDeleteError"));
                            MessageBox.Show(
                                string.Format(LanguageManager.GetString("msg_deleteError"), ex.Message),
                                LanguageManager.GetString("msg_error"),
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (PasswordDialog.Authenticate(this, pswDBprocess, LanguageManager.GetString("pwd_dbOperations")))
            {
                pnlBorder.Visible = true;
                pnlDBprocess.Visible = true;
            }
        }

        private void btnCreateDB_Click(object sender, EventArgs e)
        {
            try
            {
                if (_dbService.CheckDatabaseExists())
                {
                    MessageBox.Show(
                        LanguageManager.GetString("msg_dbAlreadyExists"),
                        LanguageManager.GetString("msg_warning"),
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _dbService.CreateDatabase();
                    _dbService.CreateTable();
                    MessageBox.Show(
                        LanguageManager.GetString("msg_dbCreated"),
                        LanguageManager.GetString("msg_info"),
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                LogService.LogError(ex, LanguageManager.GetString("log_dbCreateError"));
                MessageBox.Show(
                    string.Format(LanguageManager.GetString("msg_dbCreateError"), ex.Message),
                    LanguageManager.GetString("msg_error"),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(
                    LanguageManager.GetString("msg_dbCreateErrorGeneric"),
                    LanguageManager.GetString("msg_error"),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnRemoveDB_Click(object sender, EventArgs e)
        {
            if (_dbService.CheckDatabaseExists())
            {
                DialogResult result = MessageBox.Show(
                    LanguageManager.GetString("msg_confirmDeleteDB"),
                    LanguageManager.GetString("msg_warning"),
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (!PasswordDialog.Authenticate(this, pswDelete))
                            return;

                        DialogResult resultLast = MessageBox.Show(
                            LanguageManager.GetString("msg_confirmDeleteDBFinal"),
                            LanguageManager.GetString("msg_warning"),
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resultLast != DialogResult.Yes)
                            return;

                        _dbService.RemoveDatabase();
                        MessageBox.Show(
                            LanguageManager.GetString("msg_dbRemoved"),
                            LanguageManager.GetString("msg_info"),
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        LogService.LogError(ex, LanguageManager.GetString("log_dbDeleteError"));
                        MessageBox.Show(
                            string.Format(LanguageManager.GetString("msg_dbRemoveError"), ex.Message),
                            LanguageManager.GetString("msg_error"),
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(
                    LanguageManager.GetString("msg_dbNotExists"),
                    LanguageManager.GetString("msg_warning"),
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDownloadDB_Click(object sender, EventArgs e)
        {
            try
            {
                string localDatabasePath = txtDownloadDBLocation.Text;
                if (string.IsNullOrEmpty(localDatabasePath))
                {
                    MessageBox.Show(
                        LanguageManager.GetString("msg_selectBackupLocation"),
                        LanguageManager.GetString("msg_warning"),
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                BackupService.RunBackup(localDatabasePath);
                MessageBox.Show(
                    LanguageManager.GetString("msg_backupCompleted"),
                    LanguageManager.GetString("msg_info"),
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                LogService.LogError(ex, LanguageManager.GetString("log_backupCreateError"));
                MessageBox.Show(
                    string.Format(LanguageManager.GetString("msg_backupError"), ex.Message),
                    LanguageManager.GetString("msg_error"),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDownloadDBLocation_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                    txtDownloadDBLocation.Text = dialog.SelectedPath;
            }
        }

        private void btnUploadDBLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PostgreSQL Backup Files (*.tar)|*.tar";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                txtUploadDBLocation.Text = openFileDialog.FileName;
        }

        private async void btnUploadDB_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUploadDBLocation.Text))
                {
                    MessageBox.Show(
                        LanguageManager.GetString("msg_selectRestoreFile"),
                        LanguageManager.GetString("msg_warning"),
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult result = MessageBox.Show(
                    LanguageManager.GetString("msg_confirmRestore"),
                    LanguageManager.GetString("msg_warning"),
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                        MessageBox.Show(
                            LanguageManager.GetString("msg_restoreCompleted"),
                            LanguageManager.GetString("msg_info"),
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                LogService.LogError(ex, LanguageManager.GetString("log_dbRestoreError"));
                MessageBox.Show(
                    string.Format(LanguageManager.GetString("msg_restoreError"), ex.Message),
                    LanguageManager.GetString("msg_error"),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
