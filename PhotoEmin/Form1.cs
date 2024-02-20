using Npgsql;
using NpgsqlTypes;
using PhotoEmin.Model;
using System.Data;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Globalization;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PhotoEmin
{
    public partial class Form1 : Form
    {
        private const string ConnectionString = "Server=localhost;Port=5432;Database=dbPhoto;User Id=postgres;Password=postgres;";
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
                pnlBorder.Visible = false;
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
            string name = newReceipt.Name!;
            string dimensions = newReceipt.Dimensions!;
            decimal? qty = newReceipt.Quantity == 0 ? null : newReceipt.Quantity;
            string totalAmountText = (newReceipt.TotalAmount != 0) ? $"Tutar: {newReceipt.TotalAmount} ₺" : "Tutar: ";
            string receivedAmountText = (newReceipt.ReceivedAmount != 0) ? $"Alınan: {newReceipt.ReceivedAmount} ₺" : "Alınan: ";
            string remainingAmountText = (newReceipt.RemainingAmount != 0) ? $"Kalan: {newReceipt.RemainingAmount} ₺" : "Kalan: ";
            string deliveryDate = newReceipt.DeliveryDate!;
            string note = newReceipt.Note!;

            //string name = "John Doe";
            //string dimensions = "25x25";
            //int qty = 2;
            //decimal totalAmount = 10200;
            //decimal receivedAmount = 200;
            //decimal remainingAmount = 10000;
            //string deliveryDate = "12.12.2022";
            //string note = "heeey";

            // Logo eklemek
            Bitmap logo = Extensions.Resources.makbuzResim;
            int logoWidth = 500;
            int logoHeight = 180;
            e.Graphics!.DrawImage(logo, new Rectangle((e.PageBounds.Width - logoWidth) / 2, 50, logoWidth, logoHeight));

            // Başlık eklemek
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            string titleText = "www.studyoemin.com";
            SizeF titleSize = e.Graphics.MeasureString(titleText, titleFont);
            e.Graphics.DrawString(titleText, titleFont, Brushes.Black, new PointF((e.PageBounds.Width - titleSize.Width) / 2, 50 + logoHeight + 10));

            // İkinci metin eklemek
            Font titleFont2 = new Font("Arial", 14, FontStyle.Regular);
            string titleText2 = "Adres: Camicedit Mahallesi Cumhuriyet Caddesi";
            SizeF titleSize2 = e.Graphics.MeasureString(titleText2, titleFont2);
            float currentY = 50 + logoHeight; // currentY'yi tanımla ve başlangıç değerini ayarla
            currentY += (int)titleSize.Height + 10; // Önceki metinden sonra bir boşluk bırakmak için
            e.Graphics.DrawString(titleText2, titleFont2, Brushes.Black, new PointF((e.PageBounds.Width - titleSize2.Width) / 2, currentY));

            // Üçüncü metin eklemek
            Font titleFont3 = new Font("Arial", 14, FontStyle.Regular);
            string titleText3 = "No : 119/A - Merzifon/Amasya";
            SizeF titleSize3 = e.Graphics.MeasureString(titleText3, titleFont3);
            currentY += (int)titleSize2.Height; // Önceki metinden sonra bir boşluk bırakmak için
            e.Graphics.DrawString(titleText3, titleFont3, Brushes.Black, new PointF((e.PageBounds.Width - titleSize3.Width) / 2, currentY));

            // Dördüncü metin eklemek
            Font titleFont4 = new Font("Arial", 14, FontStyle.Regular);
            string titleText4 = "Telefon: +90 (358) 514 33 11  /  E-Posta: info@studyoemin.com";
            SizeF titleSize4 = e.Graphics.MeasureString(titleText4, titleFont4);
            currentY += (int)titleSize2.Height; // Önceki metinden sonra bir boşluk bırakmak için
            e.Graphics.DrawString(titleText4, titleFont4, Brushes.Black, new PointF((e.PageBounds.Width - titleSize4.Width) / 2, currentY));

            // Tabloyu oluşturmak
            DataTable table = new DataTable();
            Font tableCapitalFont = new Font("Arial", 15, FontStyle.Bold);
            Font tableFont = new Font("Arial", 15, FontStyle.Regular);
            table.Columns.Add("Özellik", typeof(string));
            table.Columns.Add("Değer", typeof(string));

            // İlk satırı eklemek
            table.Rows.Add($"Ad-Soyad:{name}");

            // İkinci satırı eklemek
            table.Rows.Add($"Ebat: {dimensions}", $"Adet: {qty}");

            // Üçüncü satırı eklemek
            table.Rows.Add(totalAmountText, receivedAmountText);

            // Dördüncü satırı eklemek
            table.Rows.Add(remainingAmountText, $"Teslim Tarihi:{deliveryDate}");

            // Beşinci satırı eklemek için:
            table.Rows.Add($"Not: {note}");

            // Tablonun boyutları ve hücre boyutları
            int tableWidth = 600;
            //int cellPadding = 10;
            //int cellWidth = (tableWidth - 2 * cellPadding) / table.Columns.Count;  // Hesaplanan hücre genişliği
            int cellWidth = 300;  // Hesaplanan hücre genişliği
            int cellHeight = 50;

            // Tablo başlıkları
            currentY += (int)titleSize3.Height + 20; // Önceki metinden sonra bir boşluk bırakmak için
            float currentYlast = 0;
            int tableStartX = (e.PageBounds.Width - tableWidth) / 2;

            // Tabloyu çizmek
            for (int row = 0; row < table.Rows.Count; row++)
            {
                // İlk ve son satır için
                if (row == 0 || row == table.Rows.Count - 1)
                {
                    if (row == 0)
                    {
                        e.Graphics.FillRectangle(Brushes.White, new Rectangle(tableStartX, (int)currentY, tableWidth, cellHeight));
                        e.Graphics.DrawRectangle(Pens.Black, new Rectangle(tableStartX, (int)currentY, tableWidth, cellHeight));

                        string[] rowItems = SplitAndReturn(table.Rows[row][0].ToString()!);

                        e.Graphics.DrawString(rowItems[0], tableCapitalFont, Brushes.Black, new RectangleF(tableStartX, (int)currentY, tableWidth, cellHeight), new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });
                        e.Graphics.DrawString(rowItems[1], tableFont, Brushes.Black, new RectangleF(tableStartX + (rowItems[0].Length * 12), (int)currentY, tableWidth, cellHeight), new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });
                    }
                    else
                    {
                        int noteCellHeight = 30;
                        Font noteCapitalFont = new Font("Arial", 14, FontStyle.Bold);
                        Font noteFont = new Font("Arial", 13, FontStyle.Regular);
                        string yourString = table.Rows[row][0].ToString()!;
                        string[] lines = yourString.Split("\n");
                        int noteHeight = lines.Length < 7 ? 280 : noteCellHeight * lines.Length;
                        for (int i = 0; i < lines.Length; i++)
                        {
                            if (i == 0)
                            {
                                string[] lineItems = SplitAndReturn(lines[i]);

                                e.Graphics.FillRectangle(Brushes.White, new Rectangle(tableStartX, (int)currentY, tableWidth, noteCellHeight));
                                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(tableStartX, (int)currentY, tableWidth, noteHeight));
                                e.Graphics.DrawString(lineItems[0], noteCapitalFont, Brushes.Black, new RectangleF(tableStartX, (int)currentY, tableWidth, noteCellHeight), new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });
                                e.Graphics.DrawString(lineItems[1], noteFont, Brushes.Black, new RectangleF(tableStartX + (lineItems[0].Length * 10), (int)currentY, tableWidth, noteCellHeight), new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });
                                currentYlast = currentY + noteHeight;
                            }
                            else
                            {
                                //e.Graphics.FillRectangle(Brushes.White, new Rectangle(tableStartX, (int)currentY, tableWidth, cellHeight));
                                //e.Graphics.DrawRectangle(Pens.Black, new Rectangle(tableStartX, (int)currentY, tableWidth, row == table.Rows.Count - 1 ? 5 * cellHeight : cellHeight));
                                e.Graphics.DrawString(lines[i], noteFont, Brushes.Black, new RectangleF(tableStartX, (int)currentY, tableWidth, noteCellHeight), new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });
                            }
                            currentY += noteCellHeight;
                        }
                    }
                }
                else
                {
                    // Diğer satırlar için
                    for (int i = 0; i < table.Columns.Count; i++)
                    {
                        e.Graphics.FillRectangle(Brushes.White, new Rectangle(tableStartX + i * cellWidth, (int)currentY, cellWidth, cellHeight));
                        e.Graphics.DrawRectangle(Pens.Black, new Rectangle(tableStartX + i * cellWidth, (int)currentY, cellWidth, cellHeight));

                        string[] columnItems = SplitAndReturn(table.Rows[row][i].ToString()!);

                        e.Graphics.DrawString(columnItems[0], tableCapitalFont, Brushes.Black, new RectangleF(tableStartX + i * cellWidth, (int)currentY, cellWidth, cellHeight), new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });
                        e.Graphics.DrawString(columnItems[1], tableFont, Brushes.Black, new RectangleF(tableStartX + i * cellWidth + (float)(columnItems[0].Length * 10), (int)currentY, cellWidth, cellHeight), new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });
                    }
                }

                currentY += cellHeight;
            }
            // Footer metin eklemek
            Font titleFont5 = new Font("Arial", 11, FontStyle.Regular);
            string titleText5 = "1) Makbuzsuz fotoğraf verilmez. 2) 1 ay içerisinde alınmayan fotoğraftan mesul değiliz. 3) Özel çekimleriniz için lütfen randevu alınız. 4) Çekimleri tarafımızca yapılan bütün işler 5846 sayılı fikir ve sanat eserleri yasasıyla koruma altındadır. 5) Çekimleri tarafımızca yapılmış olan bütün işlerin telif ve mülkiyet hakkı firmamıza aittir. Çekim öncesi özel bir anlaşma yapılmadı ise; dijital, negatif, orijinal görüntü ve çalışmalar müşteriye teslim edilmez. Kullanım hakkının ihlâli, yasal olmayan kopyalama, çoğaltma, yasa uyarınca suç teşkil etmektedir.";
            //currentYlast += 200; // Önceki metinden sonra bir boşluk bırakmak için
            e.Graphics.DrawString(titleText5, titleFont5, Brushes.Black, new RectangleF(120, (int)currentYlast, 600, 160), new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
        }

        bool SaveProcess(bool isSaveAndPrint = false)
        {
            string name = txtName.Text.Trim();
            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Ad-Soyad alanı boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (String.IsNullOrEmpty(textBoxFileLocation.Text))
            {
                MessageBox.Show("Lütfen kayıt için konum seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            name = name.ToUpper(new CultureInfo("tr-TR"));
            string dimensions = txtDimensions.Text.Trim(); ;
            decimal quantity = numQty.Value;
            decimal totalAmount = 0;
            decimal receivedAmount = 0;
            decimal remainingAmount = 0;
            CultureInfo turkishCulture = new CultureInfo("tr-TR");
            if (decimal.TryParse(txtTotalAmount.Text, turkishCulture, out totalAmount)) { }
            if (decimal.TryParse(txtReceivedAmount.Text, turkishCulture, out receivedAmount)) { }
            if (decimal.TryParse(txtRemainingAmount.Text, turkishCulture, out remainingAmount)) { }
            string deliveryDate = txtDeliveryDate.Text.Trim();
            string note = txtBoxNotes.Text.Trim();

            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(textBoxFileLocation.Text))
            {
                try
                {
                    // Klasör oluştur
                    string folderName = $"{name}";
                    string folderPath = Path.Combine(textBoxFileLocation.Text, folderName);
                    // Eğer klasör zaten varsa, farklı bir isim belirle
                    int count = 1;
                    while (Directory.Exists(folderPath))
                    {
                        folderName = $"{name}-{count}";
                        folderPath = Path.Combine(textBoxFileLocation.Text, folderName);
                        count++;
                    }
                    Directory.CreateDirectory(folderPath);

                    // Dosya oluştur ve içine verileri yaz
                    string fileName = $"{DateTime.Now:yyyyMMdd-HHmmss}.txt";
                    string filePath = Path.Combine(folderPath, fileName);
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine($"Ad-Soyad: {name}");
                        writer.WriteLine($"Ebat: {dimensions}");
                        writer.WriteLine($"Adet: {quantity}");
                        writer.WriteLine($"Toplam Tutar: {totalAmount}");
                        writer.WriteLine($"Alınan Tutar: {receivedAmount}");
                        writer.WriteLine($"Kalan Tutar: {remainingAmount}");
                        writer.WriteLine($"Teslim Tarihi: {deliveryDate}");
                        writer.WriteLine($"Not: {note}");
                    }
                    lblReceiptName.Text = fileName;
                    lblFileLocation.Text = folderName;
                    if (!isSaveAndPrint)
                    {
                        MessageBox.Show("Klasör ve dosya başarıyla oluşturuldu.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (count > 1)
                    {
                        MessageBox.Show($"Daha önce aynı isimli kayıt olduğu için, yeni kaydınız \"{folderName}\" olarak oluşturuldu.", "Bilgilendirme!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    setVisibleAfterSaveProcess(false);

                    newReceipt.Name = name;
                    newReceipt.Dimensions = dimensions;
                    newReceipt.Quantity = quantity;
                    newReceipt.TotalAmount = totalAmount;
                    newReceipt.ReceivedAmount = receivedAmount;
                    newReceipt.RemainingAmount = remainingAmount;
                    newReceipt.DeliveryDate = deliveryDate;
                    newReceipt.Note = note;

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
                MessageBox.Show("Lütfen Ad-Soyad girin ve bir klasör seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        void PrintProcess()
        {
            if (!string.IsNullOrWhiteSpace(lblReceiptName.Text))
            {
                //string fullPath = Path.Combine(textBoxFileLocation.Text, lblReceiptName.Text);
                //printDocument1.DocumentName = lblReceiptName.Text;
                //stringToPrint = File.ReadAllText(fullPath);
                printDocument1.DocumentName = "Makbuz";
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Yazdırmak için kayıtlı bir makbuz bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //printDocument1.DocumentName = "Makbuz";
            //printPreviewDialog1.Document = printDocument1;
            //printPreviewDialog1.ShowDialog();
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

        private void SetLoading(bool displayLoader, bool searchUpperFolderArchive, bool addFolderToArchive = false, bool addDbToFolder = false)
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
                        btnAddFoldersToArchive.Visible = false;
                        lblAddFolderToArchive.Text = "Lütfen bekleyiniz..";
                        pictureBoxAddFolderToArchive.Visible = true;
                    }
                    else if (addDbToFolder)
                    {
                        btnDBtoFolder.Visible = false;
                        lblDbToFolder.Text = "Lütfen bekleyiniz..";
                        pictureBoxLoadingDbToFolder.Visible = true;
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
                        btnAddFoldersToArchive.Visible = true;
                        lblAddFolderToArchive.Text = "Arşive Ekle";
                        pictureBoxAddFolderToArchive.Visible = false;
                    }
                    else if (addDbToFolder)
                    {
                        btnDBtoFolder.Visible = true;
                        lblDbToFolder.Text = "Arşivi Dosyaya Yedekle";
                        pictureBoxLoadingDbToFolder.Visible = false;
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

        static string[] SplitAndReturn(string input)
        {
            int index = input.IndexOf(":");

            if (index == -1 || index == 0)
            {
                return new string[] { "", "" };
            }
            string firstPart = input.Substring(0, index + 1);
            string secondPart = input.Substring(index + 1);

            string[] result = { firstPart, secondPart };

            return result;
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
            PopulateDriveComboBox();
        }

        private void btnAddFoldersToArchive_Click(object sender, EventArgs e)
        {
            lblEmpty.Text = btnAddFoldersToArchive.Text + " :";
            lblExplanation.Visible = true;
            lblEmpty.Visible = true;
            lblExplanation.Text = ArchiveExplanations.AddFoldersToArchive;
            pnlArchiveContents.Visible = true;
            pnlSearchPhoto.Visible = false;
            pnlAddFoldersToArchive.Visible = true;
            pnlAddSpareToArchive.Visible = false;
            pnlMakeSpare.Visible = false;
        }

        private void btnMakeSpare_Click(object sender, EventArgs e)
        {
            lblEmpty.Text = btnMakeSpare.Text + " :";
            lblExplanation.Visible = true;
            lblEmpty.Visible = true;
            lblExplanation.Text = ArchiveExplanations.MakeSpare;
            pnlArchiveContents.Visible = true;
            pnlSearchPhoto.Visible = false;
            pnlAddFoldersToArchive.Visible = false;
            pnlAddSpareToArchive.Visible = false;
            pnlMakeSpare.Visible = true;
        }

        private void btnAddSpareToArchive_Click(object sender, EventArgs e)
        {
            lblEmpty.Text = btnAddSpareToArchive.Text + " :";
            lblExplanation.Visible = true;
            lblEmpty.Visible = true;
            lblExplanation.Text = ArchiveExplanations.AddSpareToArchive;
            pnlArchiveContents.Visible = true;
            pnlSearchPhoto.Visible = false;
            pnlAddFoldersToArchive.Visible = false;
            pnlAddSpareToArchive.Visible = true;
            pnlMakeSpare.Visible = false;
        }

        private void btnChooseUpperFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    txtChosenUpperFolder.Text = folderDialog.SelectedPath;
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

        private void btnAddFolderToArchive_Click(object sender, EventArgs e)
        {
            SetLoading(true, false, true);
            string folderPath = txtChosenUpperFolder.Text;

            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show("Belirtilen klasör bulunamadı!");
                SetLoading(false, false, true);
                return;
            }
            List<string> errorFullNames = new();
            string errorFullName = "";
            List<string> duplicateRecords = new();
            int successfulInserts = 0;
            int totalInserts = 0;

            using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();

                string[] subDirectories = Directory.GetDirectories(folderPath);
                if (subDirectories.Length == 0)
                {
                    MessageBox.Show("Belirtilen üst klasörde kaydedilecek alt klasör bulunamadı!");
                    SetLoading(false, false, true);
                    return;
                }
                totalInserts = subDirectories.Length;
                foreach (string subDir in subDirectories)
                {
                    try
                    {
                        DirectoryInfo subDirInfo = new DirectoryInfo(subDir);
                        string folderName = Path.GetFileName(folderPath);

                        string[] jpgFiles = Directory.GetFiles(subDir, "a.jpg");
                        string[] otherJpgFiles = Directory.GetFiles(subDir, "*.jpg");
                        string[] otherPngFiles = Directory.GetFiles(subDir, "*.png");

                        byte[]? photoData = null;
                        DateTime? creationDate = DateTime.Now.Date;
                        if (jpgFiles.Length > 0)
                        {
                            photoData = File.ReadAllBytes(jpgFiles[0]);
                            creationDate = File.GetCreationTime(jpgFiles[0]).Date;
                        }
                        else if (otherJpgFiles.Length > 0)
                        {
                            photoData = File.ReadAllBytes(otherJpgFiles[0]);
                            creationDate = File.GetCreationTime(otherJpgFiles[0]).Date;
                        }
                        else if (otherPngFiles.Length > 0)
                        {
                            photoData = File.ReadAllBytes(otherPngFiles[0]);
                            creationDate = File.GetCreationTime(otherPngFiles[0]).Date;
                        }

                        string fullName = subDirInfo.Name;
                        errorFullName = subDirInfo.Name;

                        string checkDuplicateQuery = "SELECT COUNT(*) FROM customers WHERE fullname = @fullname AND foldername = @foldername";

                        using (NpgsqlCommand checkCommand = new NpgsqlCommand(checkDuplicateQuery, connection))
                        {
                            checkCommand.Parameters.AddWithValue("@fullname", fullName);
                            checkCommand.Parameters.AddWithValue("@foldername", folderName);

                            long existingRecordsCount = (long)checkCommand.ExecuteScalar()!;

                            if (existingRecordsCount == 0)
                            {
                                string insertQuery = "INSERT INTO customers (fullname, foldername, photodata) VALUES (@fullname, @foldername, @photodata)";

                                using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))
                                {
                                    command.Parameters.AddWithValue("@fullname", NpgsqlDbType.Text, fullName);
                                    command.Parameters.AddWithValue("@foldername", NpgsqlDbType.Text, folderName);
                                    command.Parameters.AddWithValue("@photodata", NpgsqlDbType.Bytea, photoData!);
                                    command.Parameters.AddWithValue("@createdate", NpgsqlDbType.Date, creationDate);
                                    command.Parameters.AddWithValue("@insertdate", NpgsqlDbType.Date, DateTime.Now.Date);

                                    int rowsAffected = command.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        successfulInserts++;
                                    }
                                }
                            }
                            else
                            {
                                duplicateRecords.Add(fullName);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Hata alınan fullname'i listeye ekle
                        errorFullNames.Add($"{errorFullName}: {ex.Message}");
                    }

                }
            }
            SetLoading(false, false, true);
            MessageBox.Show($"Toplam kayıt sayısı: {totalInserts}\nBaşarılı kayıt sayısı: {successfulInserts}\nTekrar eden kayıt sayısı: {duplicateRecords.Count} {string.Join(", ", duplicateRecords)}\nHata alınan kayıt sayısı: {errorFullNames.Count} {string.Join(", ", errorFullNames)}");
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtFullName.Text.Trim().ToLower(); // Küçük harfe dönüştür

            using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();

                string sql = "SELECT id, fullname AS \"Ad Soyad\" FROM customers WHERE fullname ILIKE @searchText";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        dataGridRecords.DataSource = dataTable;

                        // Hide the id column
                        dataGridRecords.Columns["id"].Visible = false;

                        // Set the header text of the fullname column
                        dataGridRecords.Columns["Ad Soyad"].HeaderText = "Ad Soyad:";
                        lblTotalRecord.Text = dataGridRecords.RowCount.ToString();
                        if (dataGridRecords.RowCount == 0)
                        {
                            pictureBoxChosenPhoto.Image = null;
                        }
                    }
                }
            }
        }

        private void dataGridRecords_SelectionChanged(object sender, EventArgs e)
        {
            int selectedId;
            if (dataGridRecords.CurrentRow != null && dataGridRecords.CurrentRow.Cells["id"].Value != null)
            {
                if (int.TryParse(dataGridRecords.CurrentRow.Cells["id"].Value.ToString(), out selectedId))
                {
                    using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
                    {
                        connection.Open();

                        string sql = "SELECT foldername, photodata FROM customers WHERE id = @id";

                        using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@id", selectedId);

                            using (NpgsqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    txtDataUpperFileName.Text = reader["foldername"].ToString();

                                    // Check if photodata is not null
                                    if (!reader.IsDBNull(reader.GetOrdinal("photodata")))
                                    {
                                        byte[] imageData = (byte[])reader["photodata"];
                                        Image image;
                                        using (var ms = new System.IO.MemoryStream(imageData))
                                        {
                                            try
                                            {
                                                image = Image.FromStream(ms);
                                                pictureBoxChosenPhoto.SizeMode = PictureBoxSizeMode.Zoom; // PictureBox'ın SizeMode özelliğini "Zoom" olarak ayarla
                                                pictureBoxChosenPhoto.Image = image;
                                            }
                                            catch (Exception)
                                            {
                                                pictureBoxChosenPhoto.Image = null;
                                            }
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
                        }
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
            if (dataGridRecords.CurrentRow.Cells["Ad Soyad"] != null && dataGridRecords.CurrentRow.Cells["Ad Soyad"].Value != null)
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
                MessageBox.Show("Lütfen Ad-Soyad tablosundan bir kayıt seçin");
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

        private void btnDBtoFolder_Click(object sender, EventArgs e)
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
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT fullname, foldername, photodata, createdate FROM customers";

                    using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string fullName = !reader.IsDBNull(0) ? reader.GetString(0) : string.Empty;
                            string folderName = !reader.IsDBNull(1) ? reader.GetString(1) : string.Empty;
                            byte[]? photoData = !reader.IsDBNull(reader.GetOrdinal("photodata")) ? (byte[])reader["photodata"] : null;
                            DateTime createDate = !reader.IsDBNull(reader.GetOrdinal("createdate")) ? reader.GetDateTime(reader.GetOrdinal("createdate")) : DateTime.Now;


                            string fileName = $"{fullName}_{folderName}.jpg";
                            string filePath = Path.Combine(folderPath, fileName);

                            // Veriyi JPEG dosyasına dönüştür ve kaydet
                            SavePhotoDataAsJPEG(photoData, filePath, createDate);
                        }
                    }
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

        private void SavePhotoDataAsJPEG(byte[]? photoData, string filePath, DateTime createDate)
        {
            try
            {
                if (photoData != null && photoData.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(photoData))
                    using (Image image = Image.FromStream(ms))
                    {
                        image.Save(filePath, ImageFormat.Jpeg);
                        File.SetCreationTime(filePath, createDate);
                    }
                }
                else
                {
                    // Fotoğraf verisi bulunamadığında klasör oluştur
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
            catch (Exception)
            {
                // Hata durumunda klasör oluştur
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
}
