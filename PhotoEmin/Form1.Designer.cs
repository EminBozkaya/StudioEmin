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
            lblFileLocation = new Label();
            lblReceiptName = new Label();
            label11 = new Label();
            label10 = new Label();
            label15 = new Label();
            label26 = new Label();
            label14 = new Label();
            label25 = new Label();
            label24 = new Label();
            lblReceiptCaption = new Label();
            label13 = new Label();
            btnTrash = new Button();
            btnPrint = new Button();
            btnChooseFileLocation = new Button();
            btnSaveAndPrint = new Button();
            btnSave = new Button();
            btnGoReceipt = new Button();
            btnGoTheFolder = new Button();
            pnlReceiptInputs = new Panel();
            numQty = new NumericUpDown();
            txtDeliveryDate = new TextBox();
            txtRemainingAmount = new TextBox();
            txtReceivedAmount = new TextBox();
            txtTotalAmount = new TextBox();
            txtDimensions = new TextBox();
            txtName = new TextBox();
            txtBoxNotes = new RichTextBox();
            label5 = new Label();
            label3 = new Label();
            label6 = new Label();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            label2 = new Label();
            lblName = new Label();
            pnlFindFolder = new Panel();
            listBoxFiles = new ListBox();
            txtFileNameInput = new TextBox();
            btnSearchFile = new Button();
            cmbBoxDriver = new ComboBox();
            label18 = new Label();
            label17 = new Label();
            label20 = new Label();
            label19 = new Label();
            label16 = new Label();
            label9 = new Label();
            errorProvider1 = new ErrorProvider(components);
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            label21 = new Label();
            label22 = new Label();
            btnMyComputer = new Button();
            pnlReceipt.SuspendLayout();
            pnlReceiptInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQty).BeginInit();
            pnlFindFolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnFindFolder
            // 
            btnFindFolder.BackColor = Color.Transparent;
            btnFindFolder.BackgroundImage = Properties.Resources.btnFindFolder;
            btnFindFolder.BackgroundImageLayout = ImageLayout.Stretch;
            btnFindFolder.FlatAppearance.BorderSize = 0;
            btnFindFolder.FlatStyle = FlatStyle.Flat;
            btnFindFolder.Location = new Point(69, 380);
            btnFindFolder.Margin = new Padding(6);
            btnFindFolder.Name = "btnFindFolder";
            btnFindFolder.Size = new Size(186, 213);
            btnFindFolder.TabIndex = 0;
            btnFindFolder.UseVisualStyleBackColor = false;
            btnFindFolder.Click += btnFindFolder_Click;
            // 
            // btnCreateReceipt
            // 
            btnCreateReceipt.BackColor = Color.Transparent;
            btnCreateReceipt.BackgroundImage = Properties.Resources.btnrNewReceipt;
            btnCreateReceipt.BackgroundImageLayout = ImageLayout.Stretch;
            btnCreateReceipt.FlatAppearance.BorderSize = 0;
            btnCreateReceipt.FlatStyle = FlatStyle.Flat;
            btnCreateReceipt.Location = new Point(69, 47);
            btnCreateReceipt.Margin = new Padding(6);
            btnCreateReceipt.Name = "btnCreateReceipt";
            btnCreateReceipt.Size = new Size(186, 213);
            btnCreateReceipt.TabIndex = 0;
            btnCreateReceipt.UseVisualStyleBackColor = false;
            btnCreateReceipt.Click += btnCreateReceipt_Click;
            // 
            // pnlReceipt
            // 
            pnlReceipt.BackColor = Color.Transparent;
            pnlReceipt.Controls.Add(textBoxFileLocation);
            pnlReceipt.Controls.Add(label12);
            pnlReceipt.Controls.Add(lblFileLocation);
            pnlReceipt.Controls.Add(lblReceiptName);
            pnlReceipt.Controls.Add(label11);
            pnlReceipt.Controls.Add(label10);
            pnlReceipt.Controls.Add(label15);
            pnlReceipt.Controls.Add(label26);
            pnlReceipt.Controls.Add(label14);
            pnlReceipt.Controls.Add(label25);
            pnlReceipt.Controls.Add(label24);
            pnlReceipt.Controls.Add(lblReceiptCaption);
            pnlReceipt.Controls.Add(label13);
            pnlReceipt.Controls.Add(btnTrash);
            pnlReceipt.Controls.Add(btnPrint);
            pnlReceipt.Controls.Add(btnChooseFileLocation);
            pnlReceipt.Controls.Add(btnSaveAndPrint);
            pnlReceipt.Controls.Add(btnSave);
            pnlReceipt.Controls.Add(btnGoReceipt);
            pnlReceipt.Controls.Add(btnGoTheFolder);
            pnlReceipt.Controls.Add(pnlReceiptInputs);
            pnlReceipt.Location = new Point(433, 98);
            pnlReceipt.Margin = new Padding(6);
            pnlReceipt.Name = "pnlReceipt";
            pnlReceipt.Size = new Size(2351, 1387);
            pnlReceipt.TabIndex = 1;
            // 
            // textBoxFileLocation
            // 
            textBoxFileLocation.BackColor = SystemColors.ScrollBar;
            textBoxFileLocation.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFileLocation.Location = new Point(916, 418);
            textBoxFileLocation.Margin = new Padding(6);
            textBoxFileLocation.Name = "textBoxFileLocation";
            textBoxFileLocation.ReadOnly = true;
            textBoxFileLocation.Size = new Size(520, 47);
            textBoxFileLocation.TabIndex = 14;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(1107, 1269);
            label12.Margin = new Padding(6, 0, 6, 0);
            label12.Name = "label12";
            label12.Size = new Size(111, 44);
            label12.TabIndex = 2;
            label12.Text = "Yazdır";
            // 
            // lblFileLocation
            // 
            lblFileLocation.AutoSize = true;
            lblFileLocation.FlatStyle = FlatStyle.Flat;
            lblFileLocation.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold);
            lblFileLocation.ForeColor = SystemColors.ButtonHighlight;
            lblFileLocation.Location = new Point(1491, 514);
            lblFileLocation.Margin = new Padding(6, 0, 6, 0);
            lblFileLocation.Name = "lblFileLocation";
            lblFileLocation.Size = new Size(0, 35);
            lblFileLocation.TabIndex = 2;
            // 
            // lblReceiptName
            // 
            lblReceiptName.AutoSize = true;
            lblReceiptName.FlatStyle = FlatStyle.Flat;
            lblReceiptName.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold);
            lblReceiptName.ForeColor = SystemColors.ButtonHighlight;
            lblReceiptName.Location = new Point(1491, 621);
            lblReceiptName.Margin = new Padding(6, 0, 6, 0);
            lblReceiptName.Name = "lblReceiptName";
            lblReceiptName.Size = new Size(0, 35);
            lblReceiptName.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.FlatStyle = FlatStyle.Flat;
            label11.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(1105, 1067);
            label11.Margin = new Padding(6, 0, 6, 0);
            label11.Name = "label11";
            label11.Size = new Size(125, 44);
            label11.TabIndex = 2;
            label11.Text = "Kaydet";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(1023, 819);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(266, 44);
            label10.TabIndex = 2;
            label10.Text = "Kaydet ve Yazdır";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(1473, 1265);
            label15.Margin = new Padding(6, 0, 6, 0);
            label15.Name = "label15";
            label15.Size = new Size(238, 44);
            label15.TabIndex = 2;
            label15.Text = "Formu Temizle";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.ForeColor = SystemColors.ButtonFace;
            label26.Location = new Point(1714, 930);
            label26.Margin = new Padding(6, 0, 6, 0);
            label26.Name = "label26";
            label26.Size = new Size(174, 35);
            label26.TabIndex = 2;
            label26.Text = "Makbuza Git";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ButtonFace;
            label14.Location = new Point(1495, 930);
            label14.Margin = new Padding(6, 0, 6, 0);
            label14.Name = "label14";
            label14.Size = new Size(151, 35);
            label14.TabIndex = 2;
            label14.Text = "Klasöre Git";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label25.Location = new Point(1491, 553);
            label25.Margin = new Padding(6, 0, 6, 0);
            label25.Name = "label25";
            label25.Size = new Size(252, 51);
            label25.TabIndex = 2;
            label25.Text = "Makbuz Adı:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label24.Location = new Point(1491, 439);
            label24.Margin = new Padding(6, 0, 6, 0);
            label24.Name = "label24";
            label24.Size = new Size(256, 51);
            label24.TabIndex = 2;
            label24.Text = "Klasör           :";
            // 
            // lblReceiptCaption
            // 
            lblReceiptCaption.AutoSize = true;
            lblReceiptCaption.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblReceiptCaption.Location = new Point(1491, 373);
            lblReceiptCaption.Margin = new Padding(6, 0, 6, 0);
            lblReceiptCaption.Name = "lblReceiptCaption";
            lblReceiptCaption.Size = new Size(446, 57);
            lblReceiptCaption.TabIndex = 2;
            lblReceiptCaption.Text = "Oluşturulan Makbuz:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(1051, 361);
            label13.Margin = new Padding(6, 0, 6, 0);
            label13.Name = "label13";
            label13.Size = new Size(205, 35);
            label13.TabIndex = 2;
            label13.Text = "Seçilen Konum:";
            // 
            // btnTrash
            // 
            btnTrash.BackgroundImage = Properties.Resources.btnTrash;
            btnTrash.BackgroundImageLayout = ImageLayout.Stretch;
            btnTrash.FlatAppearance.BorderSize = 0;
            btnTrash.FlatStyle = FlatStyle.Flat;
            btnTrash.Location = new Point(1495, 1090);
            btnTrash.Margin = new Padding(6);
            btnTrash.Name = "btnTrash";
            btnTrash.Size = new Size(149, 171);
            btnTrash.TabIndex = 15;
            btnTrash.UseVisualStyleBackColor = true;
            btnTrash.Click += btnTrash_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackgroundImage = Properties.Resources.btnPrint;
            btnPrint.BackgroundImageLayout = ImageLayout.Stretch;
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Location = new Point(1088, 1133);
            btnPrint.Margin = new Padding(6);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(149, 156);
            btnPrint.TabIndex = 13;
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnChooseFileLocation
            // 
            btnChooseFileLocation.BackgroundImage = Properties.Resources.btnHardDrive;
            btnChooseFileLocation.BackgroundImageLayout = ImageLayout.Stretch;
            btnChooseFileLocation.FlatAppearance.BorderSize = 0;
            btnChooseFileLocation.FlatStyle = FlatStyle.Flat;
            btnChooseFileLocation.Location = new Point(1051, 190);
            btnChooseFileLocation.Margin = new Padding(6);
            btnChooseFileLocation.Name = "btnChooseFileLocation";
            btnChooseFileLocation.Size = new Size(201, 173);
            btnChooseFileLocation.TabIndex = 10;
            btnChooseFileLocation.UseVisualStyleBackColor = true;
            btnChooseFileLocation.Click += btnChooseFileLocation_Click;
            // 
            // btnSaveAndPrint
            // 
            btnSaveAndPrint.BackgroundImage = Properties.Resources.btnSaveAndPrind;
            btnSaveAndPrint.BackgroundImageLayout = ImageLayout.Stretch;
            btnSaveAndPrint.FlatAppearance.BorderSize = 0;
            btnSaveAndPrint.FlatStyle = FlatStyle.Flat;
            btnSaveAndPrint.Location = new Point(977, 540);
            btnSaveAndPrint.Margin = new Padding(6);
            btnSaveAndPrint.Name = "btnSaveAndPrint";
            btnSaveAndPrint.Size = new Size(362, 314);
            btnSaveAndPrint.TabIndex = 11;
            btnSaveAndPrint.UseVisualStyleBackColor = true;
            btnSaveAndPrint.Click += btnSaveAndPrint_Click;
            // 
            // btnSave
            // 
            btnSave.BackgroundImage = Properties.Resources.btnSave;
            btnSave.BackgroundImageLayout = ImageLayout.Stretch;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(1088, 934);
            btnSave.Margin = new Padding(6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(149, 137);
            btnSave.TabIndex = 12;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnGoReceipt
            // 
            btnGoReceipt.BackgroundImage = Properties.Resources.btnGoReceipt;
            btnGoReceipt.BackgroundImageLayout = ImageLayout.Stretch;
            btnGoReceipt.FlatAppearance.BorderSize = 0;
            btnGoReceipt.FlatStyle = FlatStyle.Flat;
            btnGoReceipt.Location = new Point(1710, 757);
            btnGoReceipt.Margin = new Padding(6);
            btnGoReceipt.Name = "btnGoReceipt";
            btnGoReceipt.Size = new Size(149, 171);
            btnGoReceipt.TabIndex = 14;
            btnGoReceipt.UseVisualStyleBackColor = true;
            btnGoReceipt.Click += btnGoTheReceipt_Click;
            // 
            // btnGoTheFolder
            // 
            btnGoTheFolder.BackgroundImage = Properties.Resources.btnOpenFolder;
            btnGoTheFolder.BackgroundImageLayout = ImageLayout.Stretch;
            btnGoTheFolder.FlatAppearance.BorderSize = 0;
            btnGoTheFolder.FlatStyle = FlatStyle.Flat;
            btnGoTheFolder.Location = new Point(1491, 757);
            btnGoTheFolder.Margin = new Padding(6);
            btnGoTheFolder.Name = "btnGoTheFolder";
            btnGoTheFolder.Size = new Size(149, 171);
            btnGoTheFolder.TabIndex = 14;
            btnGoTheFolder.UseVisualStyleBackColor = true;
            btnGoTheFolder.Click += btnGoTheFolder_Click;
            // 
            // pnlReceiptInputs
            // 
            pnlReceiptInputs.BackgroundImage = Properties.Resources.printPAPER;
            pnlReceiptInputs.BackgroundImageLayout = ImageLayout.Stretch;
            pnlReceiptInputs.Controls.Add(numQty);
            pnlReceiptInputs.Controls.Add(txtDeliveryDate);
            pnlReceiptInputs.Controls.Add(txtRemainingAmount);
            pnlReceiptInputs.Controls.Add(txtReceivedAmount);
            pnlReceiptInputs.Controls.Add(txtTotalAmount);
            pnlReceiptInputs.Controls.Add(txtDimensions);
            pnlReceiptInputs.Controls.Add(txtName);
            pnlReceiptInputs.Controls.Add(txtBoxNotes);
            pnlReceiptInputs.Controls.Add(label5);
            pnlReceiptInputs.Controls.Add(label3);
            pnlReceiptInputs.Controls.Add(label6);
            pnlReceiptInputs.Controls.Add(label4);
            pnlReceiptInputs.Controls.Add(label7);
            pnlReceiptInputs.Controls.Add(label8);
            pnlReceiptInputs.Controls.Add(label2);
            pnlReceiptInputs.Controls.Add(lblName);
            pnlReceiptInputs.Font = new Font("MV Boli", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlReceiptInputs.ForeColor = Color.DimGray;
            pnlReceiptInputs.Location = new Point(15, 58);
            pnlReceiptInputs.Margin = new Padding(6);
            pnlReceiptInputs.Name = "pnlReceiptInputs";
            pnlReceiptInputs.Size = new Size(890, 1318);
            pnlReceiptInputs.TabIndex = 0;
            // 
            // numQty
            // 
            numQty.Location = new Point(568, 307);
            numQty.Margin = new Padding(6);
            numQty.Name = "numQty";
            numQty.Size = new Size(156, 56);
            numQty.TabIndex = 4;
            // 
            // txtDeliveryDate
            // 
            txtDeliveryDate.Location = new Point(499, 599);
            txtDeliveryDate.Margin = new Padding(6);
            txtDeliveryDate.Name = "txtDeliveryDate";
            txtDeliveryDate.Size = new Size(212, 56);
            txtDeliveryDate.TabIndex = 8;
            // 
            // txtRemainingAmount
            // 
            txtRemainingAmount.Font = new Font("MV Boli", 9F, FontStyle.Bold);
            txtRemainingAmount.Location = new Point(547, 479);
            txtRemainingAmount.Margin = new Padding(6);
            txtRemainingAmount.Name = "txtRemainingAmount";
            txtRemainingAmount.ReadOnly = true;
            txtRemainingAmount.Size = new Size(173, 46);
            txtRemainingAmount.TabIndex = 7;
            // 
            // txtReceivedAmount
            // 
            txtReceivedAmount.Font = new Font("MV Boli", 9F, FontStyle.Bold);
            txtReceivedAmount.Location = new Point(356, 479);
            txtReceivedAmount.Margin = new Padding(6);
            txtReceivedAmount.Name = "txtReceivedAmount";
            txtReceivedAmount.Size = new Size(173, 46);
            txtReceivedAmount.TabIndex = 6;
            txtReceivedAmount.TextChanged += TextBox_TextChanged;
            txtReceivedAmount.LostFocus += TextBox_LostFocus;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Font = new Font("MV Boli", 9F, FontStyle.Bold);
            txtTotalAmount.Location = new Point(169, 479);
            txtTotalAmount.Margin = new Padding(6);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(173, 46);
            txtTotalAmount.TabIndex = 5;
            txtTotalAmount.TextChanged += TextBox_TextChanged;
            txtTotalAmount.LostFocus += TextBox_LostFocus;
            // 
            // txtDimensions
            // 
            txtDimensions.Location = new Point(258, 307);
            txtDimensions.Margin = new Padding(6);
            txtDimensions.Name = "txtDimensions";
            txtDimensions.Size = new Size(197, 56);
            txtDimensions.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(169, 202);
            txtName.Margin = new Padding(6);
            txtName.Name = "txtName";
            txtName.Size = new Size(542, 56);
            txtName.TabIndex = 2;
            // 
            // txtBoxNotes
            // 
            txtBoxNotes.Location = new Point(169, 735);
            txtBoxNotes.Margin = new Padding(6);
            txtBoxNotes.Name = "txtBoxNotes";
            txtBoxNotes.Size = new Size(543, 463);
            txtBoxNotes.TabIndex = 9;
            txtBoxNotes.Text = "";
            // 
            // label5
            // 
            label5.Location = new Point(458, 313);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(104, 49);
            label5.TabIndex = 0;
            label5.Text = "Adet:";
            // 
            // label3
            // 
            label3.Location = new Point(568, 422);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(143, 49);
            label3.TabIndex = 0;
            label3.Text = "Kalan:";
            // 
            // label6
            // 
            label6.Location = new Point(187, 422);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(119, 49);
            label6.TabIndex = 0;
            label6.Text = "Tutar:";
            // 
            // label4
            // 
            label4.Location = new Point(169, 313);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(186, 49);
            label4.TabIndex = 0;
            label4.Text = "Ebat:";
            // 
            // label7
            // 
            label7.Location = new Point(278, 605);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(234, 49);
            label7.TabIndex = 0;
            label7.Text = "Teslim Tarihi:";
            // 
            // label8
            // 
            label8.Location = new Point(169, 680);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(186, 49);
            label8.TabIndex = 0;
            label8.Text = "Not:";
            // 
            // label2
            // 
            label2.Location = new Point(364, 424);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(141, 49);
            label2.TabIndex = 0;
            label2.Text = "Alınan:";
            // 
            // lblName
            // 
            lblName.Location = new Point(169, 150);
            lblName.Margin = new Padding(6, 0, 6, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(238, 49);
            lblName.TabIndex = 0;
            lblName.Text = "Ad - Soyad:";
            // 
            // pnlFindFolder
            // 
            pnlFindFolder.BackColor = Color.Transparent;
            pnlFindFolder.Controls.Add(listBoxFiles);
            pnlFindFolder.Controls.Add(txtFileNameInput);
            pnlFindFolder.Controls.Add(btnSearchFile);
            pnlFindFolder.Controls.Add(cmbBoxDriver);
            pnlFindFolder.Controls.Add(label18);
            pnlFindFolder.Controls.Add(label17);
            pnlFindFolder.Controls.Add(label20);
            pnlFindFolder.Controls.Add(label19);
            pnlFindFolder.Controls.Add(label16);
            pnlFindFolder.Location = new Point(436, 60);
            pnlFindFolder.Margin = new Padding(4, 2, 4, 2);
            pnlFindFolder.Name = "pnlFindFolder";
            pnlFindFolder.Size = new Size(1917, 1423);
            pnlFindFolder.TabIndex = 16;
            // 
            // listBoxFiles
            // 
            listBoxFiles.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxFiles.FormattingEnabled = true;
            listBoxFiles.HorizontalScrollbar = true;
            listBoxFiles.ItemHeight = 45;
            listBoxFiles.Location = new Point(854, 841);
            listBoxFiles.Margin = new Padding(4, 2, 4, 2);
            listBoxFiles.Name = "listBoxFiles";
            listBoxFiles.Size = new Size(634, 184);
            listBoxFiles.TabIndex = 5;
            listBoxFiles.DoubleClick += ListBoxFiles_DoubleClick;
            // 
            // txtFileNameInput
            // 
            txtFileNameInput.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFileNameInput.Location = new Point(925, 299);
            txtFileNameInput.Margin = new Padding(4, 2, 4, 2);
            txtFileNameInput.Name = "txtFileNameInput";
            txtFileNameInput.Size = new Size(492, 58);
            txtFileNameInput.TabIndex = 3;
            txtFileNameInput.KeyDown += txtFileNameInput_KeyDown;
            // 
            // btnSearchFile
            // 
            btnSearchFile.BackColor = Color.Transparent;
            btnSearchFile.BackgroundImage = Properties.Resources.btnSearchFolder;
            btnSearchFile.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearchFile.FlatAppearance.BorderSize = 0;
            btnSearchFile.FlatStyle = FlatStyle.Flat;
            btnSearchFile.Location = new Point(654, 465);
            btnSearchFile.Margin = new Padding(6);
            btnSearchFile.Name = "btnSearchFile";
            btnSearchFile.Size = new Size(223, 213);
            btnSearchFile.TabIndex = 0;
            btnSearchFile.UseVisualStyleBackColor = false;
            btnSearchFile.Click += btnSearchFile_Click;
            // 
            // cmbBoxDriver
            // 
            cmbBoxDriver.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBoxDriver.FormattingEnabled = true;
            cmbBoxDriver.Location = new Point(336, 297);
            cmbBoxDriver.Margin = new Padding(4, 2, 4, 2);
            cmbBoxDriver.Name = "cmbBoxDriver";
            cmbBoxDriver.Size = new Size(242, 59);
            cmbBoxDriver.TabIndex = 0;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Palatino Linotype", 19.875F, FontStyle.Bold);
            label18.ForeColor = SystemColors.ButtonFace;
            label18.Location = new Point(747, 282);
            label18.Margin = new Padding(6, 0, 6, 0);
            label18.Name = "label18";
            label18.Size = new Size(57, 72);
            label18.TabIndex = 2;
            label18.Text = ">";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Palatino Linotype", 13.875F, FontStyle.Bold);
            label17.ForeColor = SystemColors.ActiveCaptionText;
            label17.Location = new Point(358, 224);
            label17.Margin = new Padding(6, 0, 6, 0);
            label17.Name = "label17";
            label17.Size = new Size(220, 50);
            label17.TabIndex = 2;
            label17.Text = "Sürücü Seç:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = SystemColors.ActiveCaptionText;
            label20.Location = new Point(717, 683);
            label20.Margin = new Padding(6, 0, 6, 0);
            label20.Name = "label20";
            label20.Size = new Size(108, 65);
            label20.TabIndex = 2;
            label20.Text = "Ara";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = SystemColors.ActiveCaptionText;
            label19.Location = new Point(327, 898);
            label19.Margin = new Padding(6, 0, 6, 0);
            label19.Name = "label19";
            label19.Size = new Size(437, 65);
            label19.TabIndex = 2;
            label19.Text = "Bulunan Dosyalar:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Palatino Linotype", 13.875F, FontStyle.Bold);
            label16.ForeColor = SystemColors.ActiveCaptionText;
            label16.Location = new Point(1033, 224);
            label16.Margin = new Padding(6, 0, 6, 0);
            label16.Name = "label16";
            label16.Size = new Size(276, 50);
            label16.TabIndex = 2;
            label16.Text = "Dosya Adı Gir:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(69, 260);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(206, 44);
            label9.TabIndex = 2;
            label9.Text = "Makbuz Kes";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += PrintDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = SystemColors.ButtonFace;
            label21.Location = new Point(69, 604);
            label21.Margin = new Padding(6, 0, 6, 0);
            label21.Name = "label21";
            label21.Size = new Size(171, 44);
            label21.TabIndex = 2;
            label21.Text = "Dosya Ara";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = SystemColors.ButtonFace;
            label22.Location = new Point(69, 932);
            label22.Margin = new Padding(6, 0, 6, 0);
            label22.Name = "label22";
            label22.Size = new Size(201, 44);
            label22.TabIndex = 2;
            label22.Text = "Bilgisayarım";
            // 
            // btnMyComputer
            // 
            btnMyComputer.BackColor = Color.Transparent;
            btnMyComputer.BackgroundImage = Properties.Resources.btnMyComputer;
            btnMyComputer.BackgroundImageLayout = ImageLayout.Stretch;
            btnMyComputer.FlatAppearance.BorderSize = 0;
            btnMyComputer.FlatStyle = FlatStyle.Flat;
            btnMyComputer.Location = new Point(69, 708);
            btnMyComputer.Margin = new Padding(6);
            btnMyComputer.Name = "btnMyComputer";
            btnMyComputer.Size = new Size(186, 213);
            btnMyComputer.TabIndex = 0;
            btnMyComputer.UseVisualStyleBackColor = false;
            btnMyComputer.Click += btnMyComputer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ArkaFon;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2834, 1500);
            Controls.Add(pnlFindFolder);
            Controls.Add(btnMyComputer);
            Controls.Add(btnFindFolder);
            Controls.Add(label22);
            Controls.Add(btnCreateReceipt);
            Controls.Add(label21);
            Controls.Add(label9);
            Controls.Add(pnlReceipt);
            DoubleBuffered = true;
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Stüdyo-emin";
            pnlReceipt.ResumeLayout(false);
            pnlReceipt.PerformLayout();
            pnlReceiptInputs.ResumeLayout(false);
            pnlReceiptInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQty).EndInit();
            pnlFindFolder.ResumeLayout(false);
            pnlFindFolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnFindFolder;
        private Button btnCreateReceipt;
        private Panel pnlReceipt;
        private Button btnSave;
        private Panel pnlReceiptInputs;
        private Label lblName;
        private Label label5;
        private Label label3;
        private Label label6;
        private Label label4;
        private Label label7;
        private Label label2;
        private TextBox txtDeliveryDate;
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
        private Label label14;
        private Button btnGoTheFolder;
        private Label lblReceiptCaption;
        private Label lblReceiptName;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Button btnTrash;
        private Label label15;
        private NumericUpDown numQty;
        private Panel pnlFindFolder;
        private Label label16;
        private ComboBox cmbBoxDriver;
        private TextBox txtFileNameInput;
        private Label label17;
        private Label label18;
        private Button btnSearchFile;
        private Label label20;
        private Button btnMyComputer;
        private Label label22;
        private Label label21;
        private Label label19;
        private ListBox listBoxFiles;
        private Label label25;
        private Label label24;
        private Label lblFileLocation;
        private Label label26;
        private Button btnGoReceipt;
    }
}
