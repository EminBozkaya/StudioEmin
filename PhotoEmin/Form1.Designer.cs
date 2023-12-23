namespace PhotoEmin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnFindFolder = new Button();
            btnCreateReceipt = new Button();
            pnlReceipt = new Panel();
            textBoxFileLocation = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label13 = new Label();
            label9 = new Label();
            btnPrint = new Button();
            btnChooseFileLocation = new Button();
            btnSaveAndPrint = new Button();
            btnSave = new Button();
            panel2 = new Panel();
            txtDeliveryDate = new TextBox();
            txtRemainingAmount = new TextBox();
            txtReceivedAmount = new TextBox();
            txtTotalAmount = new TextBox();
            txtDimensions = new TextBox();
            txtQty = new TextBox();
            txtLastName = new TextBox();
            txtName = new TextBox();
            txtBoxNotes = new RichTextBox();
            label5 = new Label();
            label3 = new Label();
            label6 = new Label();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblName = new Label();
            errorProvider1 = new ErrorProvider(components);
            pnlReceipt.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnFindFolder
            // 
            btnFindFolder.BackColor = Color.Transparent;
            btnFindFolder.BackgroundImage = (Image)resources.GetObject("btnFindFolder.BackgroundImage");
            btnFindFolder.BackgroundImageLayout = ImageLayout.Stretch;
            btnFindFolder.FlatAppearance.BorderSize = 0;
            btnFindFolder.FlatStyle = FlatStyle.Flat;
            btnFindFolder.Location = new Point(37, 150);
            btnFindFolder.Name = "btnFindFolder";
            btnFindFolder.Size = new Size(100, 100);
            btnFindFolder.TabIndex = 0;
            btnFindFolder.UseVisualStyleBackColor = false;
            // 
            // btnCreateReceipt
            // 
            btnCreateReceipt.BackColor = Color.Transparent;
            btnCreateReceipt.BackgroundImage = (Image)resources.GetObject("btnCreateReceipt.BackgroundImage");
            btnCreateReceipt.BackgroundImageLayout = ImageLayout.Stretch;
            btnCreateReceipt.FlatAppearance.BorderSize = 0;
            btnCreateReceipt.FlatStyle = FlatStyle.Flat;
            btnCreateReceipt.Location = new Point(37, 22);
            btnCreateReceipt.Name = "btnCreateReceipt";
            btnCreateReceipt.Size = new Size(100, 100);
            btnCreateReceipt.TabIndex = 0;
            btnCreateReceipt.UseVisualStyleBackColor = false;
            btnCreateReceipt.Click += btnCreateReceipt_Click;
            // 
            // pnlReceipt
            // 
            pnlReceipt.BackColor = Color.Transparent;
            pnlReceipt.Controls.Add(textBoxFileLocation);
            pnlReceipt.Controls.Add(label12);
            pnlReceipt.Controls.Add(label11);
            pnlReceipt.Controls.Add(label10);
            pnlReceipt.Controls.Add(label13);
            pnlReceipt.Controls.Add(label9);
            pnlReceipt.Controls.Add(btnPrint);
            pnlReceipt.Controls.Add(btnChooseFileLocation);
            pnlReceipt.Controls.Add(btnSaveAndPrint);
            pnlReceipt.Controls.Add(btnSave);
            pnlReceipt.Controls.Add(panel2);
            pnlReceipt.Location = new Point(213, 22);
            pnlReceipt.Name = "pnlReceipt";
            pnlReceipt.Size = new Size(836, 686);
            pnlReceipt.TabIndex = 1;
            // 
            // textBoxFileLocation
            // 
            textBoxFileLocation.BackColor = SystemColors.ScrollBar;
            textBoxFileLocation.Location = new Point(604, 212);
            textBoxFileLocation.Name = "textBoxFileLocation";
            textBoxFileLocation.Size = new Size(200, 23);
            textBoxFileLocation.TabIndex = 14;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(667, 616);
            label12.Name = "label12";
            label12.Size = new Size(58, 22);
            label12.TabIndex = 2;
            label12.Text = "Yazdır";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.FlatStyle = FlatStyle.Flat;
            label11.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(666, 521);
            label11.Name = "label11";
            label11.Size = new Size(63, 22);
            label11.TabIndex = 2;
            label11.Text = "Kaydet";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(629, 400);
            label10.Name = "label10";
            label10.Size = new Size(136, 22);
            label10.TabIndex = 2;
            label10.Text = "Kaydet ve Yazdır";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(644, 185);
            label13.Name = "label13";
            label13.Size = new Size(105, 18);
            label13.TabIndex = 2;
            label13.Text = "Seçilen Konum:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(650, 80);
            label9.Name = "label9";
            label9.Size = new Size(99, 22);
            label9.TabIndex = 2;
            label9.Text = "Konum Seç:";
            // 
            // btnPrint
            // 
            btnPrint.BackgroundImage = (Image)resources.GetObject("btnPrint.BackgroundImage");
            btnPrint.BackgroundImageLayout = ImageLayout.Stretch;
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Location = new Point(657, 544);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(80, 80);
            btnPrint.TabIndex = 13;
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnChooseFileLocation
            // 
            btnChooseFileLocation.BackgroundImage = (Image)resources.GetObject("btnChooseFileLocation.BackgroundImage");
            btnChooseFileLocation.BackgroundImageLayout = ImageLayout.Stretch;
            btnChooseFileLocation.FlatAppearance.BorderSize = 0;
            btnChooseFileLocation.FlatStyle = FlatStyle.Flat;
            btnChooseFileLocation.Location = new Point(644, 105);
            btnChooseFileLocation.Name = "btnChooseFileLocation";
            btnChooseFileLocation.Size = new Size(108, 81);
            btnChooseFileLocation.TabIndex = 10;
            btnChooseFileLocation.UseVisualStyleBackColor = true;
            btnChooseFileLocation.Click += btnChooseFileLocation_Click;
            // 
            // btnSaveAndPrint
            // 
            btnSaveAndPrint.BackgroundImage = (Image)resources.GetObject("btnSaveAndPrint.BackgroundImage");
            btnSaveAndPrint.BackgroundImageLayout = ImageLayout.Stretch;
            btnSaveAndPrint.FlatAppearance.BorderSize = 0;
            btnSaveAndPrint.FlatStyle = FlatStyle.Flat;
            btnSaveAndPrint.Location = new Point(604, 269);
            btnSaveAndPrint.Name = "btnSaveAndPrint";
            btnSaveAndPrint.Size = new Size(195, 147);
            btnSaveAndPrint.TabIndex = 11;
            btnSaveAndPrint.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.BackgroundImage = (Image)resources.GetObject("btnSave.BackgroundImage");
            btnSave.BackgroundImageLayout = ImageLayout.Stretch;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(657, 442);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 80);
            btnSave.TabIndex = 12;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(txtDeliveryDate);
            panel2.Controls.Add(txtRemainingAmount);
            panel2.Controls.Add(txtReceivedAmount);
            panel2.Controls.Add(txtTotalAmount);
            panel2.Controls.Add(txtDimensions);
            panel2.Controls.Add(txtQty);
            panel2.Controls.Add(txtLastName);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(txtBoxNotes);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblName);
            panel2.Font = new Font("MV Boli", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel2.ForeColor = Color.DimGray;
            panel2.Location = new Point(80, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(479, 618);
            panel2.TabIndex = 0;
            // 
            // txtDeliveryDate
            // 
            txtDeliveryDate.Location = new Point(272, 306);
            txtDeliveryDate.Name = "txtDeliveryDate";
            txtDeliveryDate.Size = new Size(116, 32);
            txtDeliveryDate.TabIndex = 8;
            // 
            // txtRemainingAmount
            // 
            txtRemainingAmount.Location = new Point(284, 250);
            txtRemainingAmount.Name = "txtRemainingAmount";
            txtRemainingAmount.Size = new Size(77, 32);
            txtRemainingAmount.TabIndex = 7;
            // 
            // txtReceivedAmount
            // 
            txtReceivedAmount.Location = new Point(199, 250);
            txtReceivedAmount.Name = "txtReceivedAmount";
            txtReceivedAmount.Size = new Size(79, 32);
            txtReceivedAmount.TabIndex = 6;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Location = new Point(114, 250);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(79, 32);
            txtTotalAmount.TabIndex = 5;
            // 
            // txtDimensions
            // 
            txtDimensions.Location = new Point(153, 169);
            txtDimensions.Name = "txtDimensions";
            txtDimensions.Size = new Size(82, 32);
            txtDimensions.TabIndex = 3;
            // 
            // txtQty
            // 
            txtQty.Location = new Point(306, 169);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(82, 32);
            txtQty.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(153, 120);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(235, 32);
            txtLastName.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(153, 76);
            txtName.Name = "txtName";
            txtName.Size = new Size(235, 32);
            txtName.TabIndex = 1;
            // 
            // txtBoxNotes
            // 
            txtBoxNotes.Location = new Point(94, 370);
            txtBoxNotes.Name = "txtBoxNotes";
            txtBoxNotes.Size = new Size(294, 219);
            txtBoxNotes.TabIndex = 9;
            txtBoxNotes.Text = "";
            // 
            // label5
            // 
            label5.Location = new Point(250, 172);
            label5.Name = "label5";
            label5.Size = new Size(56, 23);
            label5.TabIndex = 0;
            label5.Text = "Adet:";
            // 
            // label3
            // 
            label3.Location = new Point(284, 224);
            label3.Name = "label3";
            label3.Size = new Size(77, 23);
            label3.TabIndex = 0;
            label3.Text = "Kalan:";
            // 
            // label6
            // 
            label6.Location = new Point(114, 224);
            label6.Name = "label6";
            label6.Size = new Size(64, 23);
            label6.TabIndex = 0;
            label6.Text = "Tutar:";
            // 
            // label4
            // 
            label4.Location = new Point(94, 172);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 0;
            label4.Text = "Ebat:";
            // 
            // label7
            // 
            label7.Location = new Point(153, 309);
            label7.Name = "label7";
            label7.Size = new Size(126, 23);
            label7.TabIndex = 0;
            label7.Text = "Teslim Tarihi:";
            // 
            // label8
            // 
            label8.Location = new Point(94, 344);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 0;
            label8.Text = "Not:";
            // 
            // label2
            // 
            label2.Location = new Point(199, 224);
            label2.Name = "label2";
            label2.Size = new Size(76, 23);
            label2.TabIndex = 0;
            label2.Text = "Alınan:";
            // 
            // label1
            // 
            label1.Location = new Point(94, 123);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "Soyad:";
            // 
            // lblName
            // 
            lblName.Location = new Point(94, 79);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 23);
            lblName.TabIndex = 0;
            lblName.Text = "Ad:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1528, 742);
            Controls.Add(pnlReceipt);
            Controls.Add(btnFindFolder);
            Controls.Add(btnCreateReceipt);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Stüdyo-emin";
            Load += Form1_Load;
            pnlReceipt.ResumeLayout(false);
            pnlReceipt.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnFindFolder;
        private Button btnCreateReceipt;
        private Panel pnlReceipt;
        private Button btnSave;
        private Panel panel2;
        private Label lblName;
        private Label label5;
        private Label label3;
        private Label label6;
        private Label label4;
        private Label label7;
        private Label label2;
        private Label label1;
        private TextBox txtDeliveryDate;
        private TextBox txtQty;
        private TextBox txtLastName;
        private TextBox txtName;
        private RichTextBox txtBoxNotes;
        private Label label8;
        private TextBox txtRemainingAmount;
        private TextBox txtReceivedAmount;
        private TextBox txtTotalAmount;
        private TextBox txtDimensions;
        private Button btnPrint;
        private Button btnChooseFileLocation;
        private Button btnSaveAndPrint;
        private Label label10;
        private Label label9;
        private Label label12;
        private Label label11;
        private Label label13;
        private ErrorProvider errorProvider1;
        private TextBox textBoxFileLocation;
    }
}
