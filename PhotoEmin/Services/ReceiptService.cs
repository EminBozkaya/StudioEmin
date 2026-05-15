using PhotoEmin.Helpers;
using PhotoEmin.Model;
using System.Drawing.Imaging;
using System.Data;
using System.Drawing.Printing;
using System.Globalization;

namespace PhotoEmin.Services
{
    /// <summary>
    /// Makbuz (Receipt) ile ilgili tüm işlemleri yürüten servis sınıfı.
    /// Makbuz oluşturma, klasöre kaydetme ve yazdırma işlemlerini kapsar.
    /// </summary>
    public class ReceiptService
    {
        // ──────────────────────────────────────────────
        //  MAKBUZ MODEL OLUŞTURMA
        // ──────────────────────────────────────────────

        /// <summary>
        /// Form alanlarından gelen ham verilerle bir Receipt nesnesi oluşturur.
        /// </summary>
        public Receipt CreateReceipt(
            string name,
            string dimensions,
            string quantity,
            string totalAmountText,
            string receivedAmountText,
            string remainingAmountText,
            string deliveryDate,
            string note)
        {
            var receipt = new Receipt();

            name = name.Trim().Replace("_", " ").ToUpper(new CultureInfo("tr-TR"));
            if (string.IsNullOrEmpty(name))
                return receipt;

            var turkishCulture = new CultureInfo("tr-TR");
            decimal.TryParse(totalAmountText, turkishCulture, out decimal totalAmount);
            decimal.TryParse(receivedAmountText, turkishCulture, out decimal receivedAmount);
            decimal.TryParse(remainingAmountText, turkishCulture, out decimal remainingAmount);

            receipt.Name = name;
            receipt.Dimensions = dimensions.Trim();
            receipt.Quantity = quantity.Trim();
            receipt.TotalAmount = totalAmount;
            receipt.ReceivedAmount = receivedAmount;
            receipt.RemainingAmount = remainingAmount;
            receipt.DeliveryDate = deliveryDate.Trim();
            receipt.Note = note.Trim();

            return receipt;
        }

        // ──────────────────────────────────────────────
        //  MAKBUZ KAYDETME (Klasör + Dosya)
        // ──────────────────────────────────────────────

        /// <summary>
        /// Makbuz bilgilerini dosya sistemi üzerinde klasör ve txt dosyası olarak kaydeder.
        /// Aynı isimli klasör varsa otomatik numaralama yapar.
        /// </summary>
        /// <returns>
        /// Başarılı: (true, oluşturulan klasör adı, dosya adı, tekrar sayısı).
        /// Başarısız: (false, null, null, 0).
        /// </returns>
        public (bool success, string? folderName, string? fileName, int duplicateCount) SaveReceiptToFolder(
            Receipt receipt, string baseFolderPath)
        {
            if (string.IsNullOrWhiteSpace(receipt.Name))
                return (false, null, null, 0);

            string folderName = receipt.Name;
            string folderPath = Path.Combine(baseFolderPath, folderName);

            // Aynı isimli klasör varsa farklı bir isim belirle
            int count = 1;
            while (Directory.Exists(folderPath))
            {
                folderName = $"{receipt.Name}-{count}";
                folderPath = Path.Combine(baseFolderPath, folderName);
                count++;
            }
            Directory.CreateDirectory(folderPath);

            // Dosya oluştur ve içine verileri yaz
            string fileName = $"{DateTime.Now:yyyyMMdd-HHmmss}.txt";
            string filePath = Path.Combine(folderPath, fileName);

            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine($"Ad-Soyad: {receipt.Name}");
                writer.WriteLine($"Ebat: {receipt.Dimensions}");
                writer.WriteLine($"Adet: {receipt.Quantity}");
                writer.WriteLine($"Toplam Tutar: {receipt.TotalAmount}");
                writer.WriteLine($"Alınan Tutar: {receipt.ReceivedAmount}");
                writer.WriteLine($"Kalan Tutar: {receipt.RemainingAmount}");
                writer.WriteLine($"Teslim Tarihi: {receipt.DeliveryDate}");
                writer.WriteLine($"Not: {receipt.Note}");
            }

            return (true, folderName, fileName, count > 1 ? count - 1 : 0);
        }

        // ──────────────────────────────────────────────
        //  MAKBUZ YAZDIRMA (PrintPage Renderer)
        // ──────────────────────────────────────────────

        /// <summary>
        /// PrintDocument'ın PrintPage olayında çağrılarak makbuzu çizer.
        /// Form1'deki PrintDocument1_PrintPage mantığının tamamı buraya taşınmıştır.
        /// </summary>
        public void RenderReceiptPage(Receipt receipt, PrintPageEventArgs e)
        {
            string name = receipt.Name!;
            string dimensions = receipt.Dimensions!;
            string qty = receipt.Quantity!;
            string totalAmountText = (receipt.TotalAmount != 0) ? $"Tutar: {receipt.TotalAmount} ₺" : "Tutar: ";
            string receivedAmountText = (receipt.ReceivedAmount != 0) ? $"Alınan: {receipt.ReceivedAmount} ₺" : "Alınan: ";
            string remainingAmountText = (receipt.RemainingAmount != 0) ? $"Kalan: {receipt.RemainingAmount} ₺" : "Kalan: ";
            string deliveryDate = receipt.DeliveryDate!;
            string note = receipt.Note!;

            // Logo eklemek
            using Bitmap logo = Extensions.Resources.Studyoeminlogo;
            int logoWidth = 240;
            int logoHeight = 75;
            e.Graphics!.DrawImage(logo, new Rectangle((e.PageBounds.Width - logoWidth) / 2, 0, logoWidth, logoHeight));

            // İkinci metin eklemek
            using Font titleFont2 = new Font("Arial", 8, FontStyle.Regular);
            string titleText2 = "Adres: Camicedit Mah. Cumhuriyet Cad.";
            SizeF titleSize2 = e.Graphics.MeasureString(titleText2, titleFont2);
            float currentY = logoHeight - 7;
            e.Graphics.DrawString(titleText2, titleFont2, Brushes.Black,
                new PointF((e.PageBounds.Width - titleSize2.Width) / 2, currentY));

            // İkinciye devam metin eklemek
            using Font titleFont2_2 = new Font("Arial", 8, FontStyle.Regular);
            string titleText2_2 = "No:119/A - Merzifon/Amasya";
            SizeF titleSize2_2 = e.Graphics.MeasureString(titleText2_2, titleFont2_2);
            currentY += (int)titleSize2.Height;
            e.Graphics.DrawString(titleText2_2, titleFont2_2, Brushes.Black,
                new PointF((e.PageBounds.Width - titleSize2_2.Width) / 2, currentY));

            // Üçüncü metin eklemek
            using Font titleFont3 = new Font("Arial", 8, FontStyle.Regular);
            string titleText3 = "0358 514 33 11 / info@studyoemin.com";
            SizeF titleSize3 = e.Graphics.MeasureString(titleText3, titleFont3);
            currentY += (int)titleSize2.Height;
            e.Graphics.DrawString(titleText3, titleFont3, Brushes.Black,
                new PointF((e.PageBounds.Width - titleSize3.Width) / 2, currentY));

            // Tabloyu oluşturmak
            using DataTable table = new DataTable();
            using Font tableCapitalFont = new Font("Arial", 8, FontStyle.Bold);
            using Font tableFont = new Font("Arial", 8, FontStyle.Regular);
            table.Columns.Add("Özellik", typeof(string));
            table.Columns.Add("Değer", typeof(string));

            table.Rows.Add($"Ad-Soyad:{name}");
            table.Rows.Add($"Ebat: {dimensions}", $"Adet: {qty}");
            table.Rows.Add(totalAmountText, receivedAmountText);
            table.Rows.Add(remainingAmountText, $"Teslim Tarihi:{deliveryDate}");
            table.Rows.Add($"Not: {note}");

            // Tablonun boyutları ve hücre boyutları
            int tableWidth = 240;
            int cellWidth = 120;
            int cellHeight = 27;

            currentY += (int)titleSize3.Height + 1;
            float currentYlast = 0;
            int tableStartX = (e.PageBounds.Width - tableWidth) / 2;

            // Tabloyu çizmek
            for (int row = 0; row < table.Rows.Count; row++)
            {
                if (row == 0 || row == table.Rows.Count - 1)
                {
                    if (row == 0)
                    {
                        e.Graphics.FillRectangle(Brushes.White,
                            new Rectangle(tableStartX, (int)currentY, tableWidth, cellHeight));
                        e.Graphics.DrawRectangle(Pens.Black,
                            new Rectangle(tableStartX, (int)currentY, tableWidth, cellHeight));

                        string[] rowItems = TurkishStringHelper.SplitAndReturn(table.Rows[row][0].ToString()!);

                        e.Graphics.DrawString(rowItems[0], tableCapitalFont, Brushes.Black,
                            new RectangleF(tableStartX, (int)currentY, tableWidth, cellHeight),
                            new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });
                        e.Graphics.DrawString(rowItems[1], tableFont, Brushes.Black,
                            new RectangleF(tableStartX + (rowItems[0].Length * 8), (int)currentY, tableWidth, cellHeight),
                            new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });
                    }
                    else
                    {
                        int noteCellHeight = 20;
                        int noteLinesCellHeight = 20;
                        using Font noteCapitalFont = new Font("Arial", 8, FontStyle.Bold);
                        using Font noteFont = new Font("Arial", 7, FontStyle.Regular);
                        string yourString = table.Rows[row][0].ToString()!;
                        string[] lines = yourString.Split("\n");
                        int noteHeight = lines.Length < 2 ? 20 : noteCellHeight * lines.Length;

                        for (int i = 0; i < lines.Length; i++)
                        {
                            if (i == 0)
                            {
                                string[] lineItems = TurkishStringHelper.SplitAndReturn(lines[i]);

                                e.Graphics.FillRectangle(Brushes.White,
                                    new Rectangle(tableStartX, (int)currentY, tableWidth, noteCellHeight));
                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle(tableStartX, (int)currentY, tableWidth, noteHeight));
                                e.Graphics.DrawString(lineItems[0], noteCapitalFont, Brushes.Black,
                                    new RectangleF(tableStartX, (int)currentY, tableWidth, noteLinesCellHeight),
                                    new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });
                                e.Graphics.DrawString(lineItems[1], noteFont, Brushes.Black,
                                    new RectangleF(tableStartX + (lineItems[0].Length * 8), (int)currentY, tableWidth, noteLinesCellHeight),
                                    new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });
                                currentYlast = currentY + noteHeight;
                            }
                            else
                            {
                                e.Graphics.DrawString(lines[i], noteFont, Brushes.Black,
                                    new RectangleF(tableStartX, (int)currentY, tableWidth, noteLinesCellHeight),
                                    new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });
                            }
                            currentY += noteLinesCellHeight;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < table.Columns.Count; i++)
                    {
                        e.Graphics.FillRectangle(Brushes.White,
                            new Rectangle(tableStartX + i * cellWidth, (int)currentY, cellWidth, cellHeight));
                        e.Graphics.DrawRectangle(Pens.Black,
                            new Rectangle(tableStartX + i * cellWidth, (int)currentY, cellWidth, cellHeight));

                        string[] columnItems = TurkishStringHelper.SplitAndReturn(table.Rows[row][i].ToString()!);

                        if (row == 3 && i == table.Columns.Count - 1)
                        {
                            e.Graphics.DrawString(columnItems[0], tableCapitalFont, Brushes.Black,
                                new RectangleF(tableStartX + i * cellWidth, (int)currentY, cellWidth, cellHeight / 2),
                                new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });
                            e.Graphics.DrawString(columnItems[1], tableFont, Brushes.Black,
                                new RectangleF(tableStartX + i * cellWidth, (int)currentY + cellHeight / 2, cellWidth, cellHeight / 2),
                                new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });
                        }
                        else
                        {
                            e.Graphics.DrawString(columnItems[0], tableCapitalFont, Brushes.Black,
                                new RectangleF(tableStartX + i * cellWidth, (int)currentY, cellWidth, cellHeight),
                                new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });
                            e.Graphics.DrawString(columnItems[1], tableFont, Brushes.Black,
                                new RectangleF(
                                    columnItems[0].Length > 8
                                        ? (tableStartX + i * cellWidth + (float)(columnItems[0].Length * 2))
                                        : (tableStartX + i * cellWidth + (float)(columnItems[0].Length * 6)),
                                    (int)currentY, cellWidth, cellHeight),
                                new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });
                        }
                    }
                }

                currentY += cellHeight;
            }

            // Footer metin eklemek
            using Font titleFont5 = new Font("Arial", 6, FontStyle.Regular);
            string titleText5 = "1) Makbuzsuz fotoğraf verilmez.\n2) 1 ay içerisinde alınmayan fotoğraftan mesul değiliz.\n3) Özel çekimleriniz için lütfen randevu alınız.\n4) Çekimleri tarafımızca yapılan bütün işler 5846 sayılı fikir ve sanat eserleri yasasıyla koruma altındadır.\n5) Çekimleri tarafımızca yapılmış olan bütün işlerin telif ve mülkiyet hakkı firmamıza aittir. Çekim öncesi özel bir anlaşma yapılmadı ise; dijital, negatif, orijinal görüntü ve çalışmalar müşteriye teslim edilmez. Kullanım hakkının ihlâli, yasal olmayan kopyalama, çoğaltma, yasa uyarınca suç teşkil etmektedir.";
            e.Graphics.DrawString(titleText5, titleFont5, Brushes.Black,
                new RectangleF(20, (int)currentYlast + 2, 235, 120),
                new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Near });

            using Font emptyTitleFont = new Font("Arial", 6, FontStyle.Regular);
            string emptyTitleText = "\n.";
            e.Graphics.DrawString(emptyTitleText, emptyTitleFont, Brushes.Black,
                new RectangleF(20, (int)currentYlast + 110, 235, 18),
                new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Near });
        }
    }
}
