using System.Windows.Forms;

namespace PhotoEmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += (s, e) =>
            {
                // Formun genişlik ve yüksekliğini belirleyin (örneğin, 800x600)
                this.Width = 1250;
                this.Height = 768;
                textBoxFileLocation.Multiline = false;
                textBoxFileLocation.ScrollBars = ScrollBars.Vertical;
                // pnlReceipt panelini görünmez yap
                pnlReceipt.Visible = false;
            };

            // Form üzerinde herhangi bir yere tıklandığında
            this.Click += (s, e) =>
            {
                // pnlReceipt panelini görünmez yap
                pnlReceipt.Visible = false;
            };
        }

        private void txtTotalAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Girilen karakterin kontrolü
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true; // Bu karakteri işleme alma
            }

            // Birden fazla ondalık noktasını engelleme
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtTotalAmount.Text, out _))
            {
                errorProvider1.SetError(txtTotalAmount, "Geçersiz sayı formatı!");
            }
            else
            {
                errorProvider1.SetError(txtTotalAmount, "");
            }
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
            string name = txtName.Text;
            string lastName = txtLastName.Text;
            string dimensions = txtDimensions.Text;
            string quantity = txtQty.Text;
            decimal totalAmount = 0;
            decimal receivedAmount = 0;
            decimal remainingAmount = 0;
            if (decimal.TryParse(txtTotalAmount.Text, out totalAmount)) { }
            if (decimal.TryParse(txtReceivedAmount.Text, out receivedAmount)) { }
            if (decimal.TryParse(txtRemainingAmount.Text, out remainingAmount)) { }
            string deliveryDate = txtDeliveryDate.Text;
            string note = txtBoxNotes.Text;

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

                    MessageBox.Show("Klasör ve dosya başarıyla oluşturuldu.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen ad ve soyadı girin, ve bir klasör seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCreateReceipt_Click(object sender, EventArgs e)
        {
            pnlReceipt.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
