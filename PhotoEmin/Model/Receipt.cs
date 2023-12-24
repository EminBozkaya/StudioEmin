namespace PhotoEmin.Model
{
    public class Receipt
    {
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Dimensions { get; set; }
        public decimal Quantity { get; set; } = 0;
        public decimal TotalAmount { get; set; } = 0;
        public decimal ReceivedAmount { get; set; } = 0;
        public decimal RemainingAmount { get; set; } = 0;
        public string? DeliveryDate { get; set; }
        public string? Note { get; set; }

        public Receipt ReceiptReader(string fullPath)
        {
            string[] satirlar = File.ReadAllLines(fullPath);

            Receipt receipt = new Receipt();

            // Satırları oku ve ilgili değişkenlere atama yap
            foreach (string satir in satirlar)
            {
                if (satir.StartsWith("Ad:"))
                {
                    receipt.Name = satir.Replace("Ad:", "").Trim();
                }
                else if (satir.StartsWith("Soyad:"))
                {
                    receipt.LastName = satir.Replace("Soyad:", "").Trim();
                }
                else if (satir.StartsWith("Ebat:"))
                {
                    receipt.Dimensions = satir.Replace("Ebat:", "").Trim();
                }
                else if (satir.StartsWith("Adet:"))
                {
                    receipt.Quantity = Convert.ToDecimal(satir.Replace("Adet:", "").Trim());
                }
                else if (satir.StartsWith("Toplam Tutar:"))
                {
                    receipt.TotalAmount = Convert.ToDecimal(satir.Replace("Toplam Tutar:", "").Trim());
                }
                else if (satir.StartsWith("Alınan Tutar:"))
                {
                    receipt.ReceivedAmount = Convert.ToDecimal(satir.Replace("Alınan Tutar:", "").Trim());
                }
                else if (satir.StartsWith("Kalan Tutar:"))
                {
                    receipt.RemainingAmount = Convert.ToDecimal(satir.Replace("Kalan Tutar:", "").Trim());
                }
                else if (satir.StartsWith("Teslim Tarihi:"))
                {
                    receipt.DeliveryDate = satir.Replace("Teslim Tarihi:", "").Trim();
                }
                else if (satir.StartsWith("Not:"))
                {
                    receipt.Note = satir.Replace("Not:", "").Trim();
                }
            }
            return receipt;
        }
    }
}
