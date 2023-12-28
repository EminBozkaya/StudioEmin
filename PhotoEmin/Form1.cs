using PhotoEmin.Model;
using System.Data;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Globalization;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PhotoEmin
{
    public partial class Form1 : Form
    {
        // Declare a string to hold the entire document contents.
        private string documentContents = "";

        // Declare a variable to hold the portion of the document that
        // is not printed.
        private string stringToPrint = "";

        private Receipt newReceipt = new Receipt();
        public Form1()
        {
            InitializeComponent();
            this.Load += (s, e) =>
            {
                // Formun genişlik ve yüksekliğini belirleyin (örneğin, 800x600)
                this.Width = 1500;
                this.Height = 900;
                textBoxFileLocation.Multiline = false;
                textBoxFileLocation.ScrollBars = ScrollBars.Vertical;

                pnlReceipt.Visible = false;
                pnlFindFolder.Visible = false;
            };

            // Form üzerinde herhangi bir yere tıklandığında
            this.Click += (s, e) =>
            {
                pnlReceipt.Visible = false;
                pnlFindFolder.Visible = false;
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
            pnlReceipt.Visible = true;
            pnlFindFolder.Visible = false;

            //pnlFindFolder.SendToBack();
            //pnlReceipt.BringToFront();
        }

        private void btnGoTheFolder_Click(object sender, EventArgs e)
        {
            string folderPath = lblFileLocation.Text; // Klasör yolunu buraya ekleyin
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
            string folderPath = Path.Combine(lblFileLocation.Text, lblReceiptName.Text);
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
            newReceipt = new Receipt();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
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
            string lastName = newReceipt.LastName!;
            string dimensions = newReceipt.Dimensions!;
            decimal? qty = newReceipt.Quantity == 0 ? null : newReceipt.Quantity;
            string totalAmountText = (newReceipt.TotalAmount != 0) ? $"Tutar: {newReceipt.TotalAmount} ₺" : "Tutar: ";
            string receivedAmountText = (newReceipt.ReceivedAmount != 0) ? $"Alınan: {newReceipt.ReceivedAmount} ₺" : "Alınan: ";
            string remainingAmountText = (newReceipt.RemainingAmount != 0) ? $"Kalan: {newReceipt.RemainingAmount} ₺" : "Kalan: ";
            string deliveryDate = newReceipt.DeliveryDate!;
            string note = newReceipt.Note!;

            //string name = "John";
            //string lastName = "Doe";
            //string dimensions = "25x25";
            //int qty = 2;
            //decimal totalAmount = 10200;
            //decimal receivedAmount = 200;
            //decimal remainingAmount = 10000;
            //string deliveryDate = "12.12.2022";
            //string note = "heeey";

            // Logo eklemek
            Bitmap logo = Properties.Resources.makbuzResim;
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
            Font tableFont = new Font("Arial", 15, FontStyle.Regular);
            table.Columns.Add("Özellik", typeof(string));
            table.Columns.Add("Değer", typeof(string));

            // İlk satırı eklemek
            table.Rows.Add($"Adı Soyadı: {name} {lastName}");

            // İkinci satırı eklemek
            table.Rows.Add($"Ebat: {dimensions}", $"Adet: {qty}");

            // Üçüncü satırı eklemek
            table.Rows.Add(totalAmountText, receivedAmountText);

            // Dördüncü satırı eklemek
            table.Rows.Add(remainingAmountText, $"Teslim Tarihi: {deliveryDate}");

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
                    if(row == 0)
                    {
                        e.Graphics.FillRectangle(Brushes.White, new Rectangle(tableStartX, (int)currentY, tableWidth, cellHeight));
                        e.Graphics.DrawRectangle(Pens.Black, new Rectangle(tableStartX, (int)currentY, tableWidth, cellHeight));
                        e.Graphics.DrawString(table.Rows[row][0].ToString(), tableFont, Brushes.Black, new RectangleF(tableStartX, (int)currentY, tableWidth, cellHeight), new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });
                    }
                    else
                    {
                        int noteCellHeight = 30;
                        Font noteFont = new Font("Arial", 13, FontStyle.Regular);
                        string yourString = table.Rows[row][0].ToString()!;
                        string[] lines = yourString.Split("\n");
                        int noteHeight = lines.Length < 7 ? 280 : noteCellHeight * lines.Length;
                        for (int i = 0; i < lines.Length; i++)
                        {
                            if(i == 0)
                            {
                                e.Graphics.FillRectangle(Brushes.White, new Rectangle(tableStartX, (int)currentY, tableWidth, noteCellHeight));
                                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(tableStartX, (int)currentY, tableWidth, noteHeight));
                                e.Graphics.DrawString(lines[i], noteFont, Brushes.Black, new RectangleF(tableStartX, (int)currentY, tableWidth, noteCellHeight), new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });
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
                        e.Graphics.DrawString(table.Rows[row][i].ToString(), tableFont, Brushes.Black, new RectangleF(tableStartX + i * cellWidth, (int)currentY, cellWidth, cellHeight), new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });
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
                MessageBox.Show("Ad alanı boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string lastName = txtLastName.Text.Trim();
            if (String.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Soyad alanı boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (String.IsNullOrEmpty(textBoxFileLocation.Text))
            {
                MessageBox.Show("Lütfen kayıt için konum seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string dimensions = txtDimensions.Text.Trim(); ;
            decimal quantity = numQty.Value;
            decimal totalAmount = 0;
            decimal receivedAmount = 0;
            decimal remainingAmount = 0;
            if (decimal.TryParse(txtTotalAmount.Text, out totalAmount)) { }
            if (decimal.TryParse(txtReceivedAmount.Text, out receivedAmount)) { }
            if (decimal.TryParse(txtRemainingAmount.Text, out remainingAmount)) { }
            string deliveryDate = txtDeliveryDate.Text;
            string note = txtBoxNotes.Text.Trim();

            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(lastName) && !string.IsNullOrWhiteSpace(textBoxFileLocation.Text))
            {
                try
                {
                    // Klasör oluştur
                    string folderName = $"{name} {lastName}";
                    string folderPath = Path.Combine(textBoxFileLocation.Text, folderName);
                    // Eğer klasör zaten varsa, farklı bir isim belirle
                    int count = 1;
                    while (Directory.Exists(folderPath))
                    {
                        folderName = $"{name} {lastName}_{count}";
                        folderPath = Path.Combine(textBoxFileLocation.Text, folderName);
                        count++;
                    }
                    Directory.CreateDirectory(folderPath);

                    // Dosya oluştur ve içine verileri yaz
                    string fileName = $"{DateTime.Now:yyyyMMdd-HHmmss}.txt";
                    string filePath = Path.Combine(folderPath, fileName);
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine($"Ad: {name}");
                        writer.WriteLine($"Soyad: {lastName}");
                        writer.WriteLine($"Ebat: {dimensions}");
                        writer.WriteLine($"Adet: {quantity}");
                        writer.WriteLine($"Toplam Tutar: {totalAmount}");
                        writer.WriteLine($"Alınan Tutar: {receivedAmount}");
                        writer.WriteLine($"Kalan Tutar: {remainingAmount}");
                        writer.WriteLine($"Teslim Tarihi: {deliveryDate}");
                        writer.WriteLine($"Not: {note}");
                    }
                    lblReceiptName.Text = fileName;
                    lblFileLocation.Text = folderPath;
                    if (!isSaveAndPrint)
                    {
                        MessageBox.Show("Klasör ve dosya başarıyla oluşturuldu.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    newReceipt.Name = name;
                    newReceipt.LastName = lastName;
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
                MessageBox.Show("Lütfen ad ve soyadı girin, ve bir klasör seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
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
            pnlReceipt.Visible = false;
            pnlFindFolder.Visible = true;

            //pnlReceipt.SendToBack();
            //pnlFindFolder.BringToFront();

            PopulateDriveComboBox();
        }

        private void PopulateDriveComboBox()
        {
            // ComboBox'ı temizle
            cmbBoxDriver.Items.Clear();

            // Bilgisayardaki sürücüleri al
            DriveInfo[] drives = DriveInfo.GetDrives();

            // Sürücüleri ComboBox'a ekle
            foreach (DriveInfo drive in drives)
            {
                cmbBoxDriver.Items.Add(drive.Name);
            }

            // ComboBox'da bir öğe seçili hale getirebilirsiniz, örneğin:
            if (cmbBoxDriver.Items.Count > 0)
            {
                cmbBoxDriver.SelectedIndex = 0;
            }
        }

        private void btnSearchFile_Click(object sender, EventArgs e)
        {
            // Dosya adını ve sürücüyü al
            string klasorAdi = txtFileNameInput.Text.Trim();
            string secilenSurucu = cmbBoxDriver.SelectedItem as string;

            // Geçerli bir dosya adı ve sürücü var mı kontrol et
            if (!string.IsNullOrEmpty(klasorAdi) && !string.IsNullOrEmpty(secilenSurucu))
            {
                // Klasörleri ara ve bulunanları ListBox'a ekle
                ListFolderNames(secilenSurucu, klasorAdi);
            }
            else
            {
                MessageBox.Show("Lütfen klasör adını ve sürücüyü seçin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ListFolderNames(string dizinYolu, string arananKlasorAdi)
        {
            try
            {
                listBoxFiles.Items.Clear(); // ListBox'ı temizle

                // Dizin içindeki klasörleri kontrol et
                DirectoryInfo di = new DirectoryInfo(dizinYolu);

                // Tüm dizinleri al
                var klasorlerVeDosyalar = di.GetFileSystemInfos("*", SearchOption.AllDirectories);

                // Sadece klasörleri eklemek için filtreleme adımı
                var filtrelenmisKlasorler = klasorlerVeDosyalar
                    .Where(info => (info.Attributes & FileAttributes.Directory) == FileAttributes.Directory && info.Name.Contains(arananKlasorAdi, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                foreach (var klasorDosya in filtrelenmisKlasorler)
                {
                    // Klasör isimlerini alıyoruz
                    string klasorAdi = klasorDosya.FullName;
                    listBoxFiles.Items.Add(klasorAdi);
                    // Yatay kaydırma çubuğunu güncelle
                }

                if (listBoxFiles.Items.Count == 0)
                {
                    listBoxFiles.Items.Add("Bulunamadı");
                }

                listBoxFiles.SelectedIndex = 0; // İlk öğeyi seç
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Bu dizine erişme izniniz yok.", "Erişim İzni Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ListBoxFiles_DoubleClick(object sender, EventArgs e)
        {
            // ListBox'ta çift tıklanan öğenin adını al
            string secilenKlasor = listBoxFiles.SelectedItem as string;

            // Geçerli bir öğe seçildiyse ve "Bulunamadı" öğesi değilse işlem yap
            if (!string.IsNullOrEmpty(secilenKlasor) && secilenKlasor != "Bulunamadı")
            {
                // Klasör yolunu oluştur ve aç
                string secilenSurucu = cmbBoxDriver.SelectedItem as string;
                string klasorYolu = Path.Combine(secilenSurucu, secilenKlasor);

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

    }
}
