namespace PhotoEmin.Forms
{
    public class PasswordDialog : Form
    {
        private TextBox _textBox = null!;

        private PasswordDialog(string title)
        {
            Text = title;
            Size = new Size(300, 150);
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            BuildUI();
        }

        private void BuildUI()
        {
            Label label = new()
            {
                Text = "Lütfen şifreyi giriniz:",
                Location = new Point(10, 20),
                AutoSize = true
            };

            _textBox = new TextBox
            {
                PasswordChar = '*',
                Location = new Point(10, 50),
                Size = new Size(200, 20)
            };

            Button confirmButton = new()
            {
                Text = "Onayla",
                DialogResult = DialogResult.OK,
                Location = new Point(10, 80),
                Size = new Size(75, 23)
            };

            Button cancelButton = new()
            {
                Text = "İptal",
                DialogResult = DialogResult.Cancel,
                Location = new Point(90, 80),
                Size = new Size(75, 23)
            };

            _textBox.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            };

            Controls.AddRange([label, _textBox, confirmButton, cancelButton]);
        }

        /// <summary>
        /// Kullanıcıdan şifre ister ve doğrular. Doğruysa true, iptal edilirse false döner.
        /// </summary>
        public static bool Authenticate(Form parent, string requiredPassword, string title = "Şifre Girişi")
        {
            while (true)
            {
                using var dialog = new PasswordDialog(title);
                if (dialog.ShowDialog(parent) != DialogResult.OK)
                    return false; // Kullanıcı iptal etti

                if (dialog._textBox.Text == requiredPassword)
                    return true; // Şifre doğru

                MessageBox.Show("Yanlış şifre girdiniz. Lütfen tekrar deneyin.",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
