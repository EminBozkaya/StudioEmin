using PhotoEmin.Helpers;

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
                Text = LanguageManager.GetString("pwd_enterPassword"),
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
                Text = LanguageManager.GetString("pwd_confirm"),
                DialogResult = DialogResult.OK,
                Location = new Point(10, 80),
                Size = new Size(75, 23)
            };

            Button cancelButton = new()
            {
                Text = LanguageManager.GetString("pwd_cancel"),
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

        public static bool Authenticate(Form parent, string requiredPassword, string title = "")
        {
            if (string.IsNullOrEmpty(title))
                title = LanguageManager.GetString("pwd_title");

            while (true)
            {
                using var dialog = new PasswordDialog(title);
                if (dialog.ShowDialog(parent) != DialogResult.OK)
                    return false;

                if (dialog._textBox.Text == requiredPassword)
                    return true;

                MessageBox.Show(
                    LanguageManager.GetString("pwd_wrong"),
                    LanguageManager.GetString("msg_error"),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
