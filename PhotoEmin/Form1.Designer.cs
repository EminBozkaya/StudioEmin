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
            lblSave = new Label();
            lblSaveAndPrint = new Label();
            label15 = new Label();
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
            pnlFindFolder = new Panel();
            pictureBoxLoading = new PictureBox();
            listBoxFiles = new ListBox();
            txtFileNameInput = new TextBox();
            btnSearchFile = new Button();
            cmbBoxDriver = new ComboBox();
            label18 = new Label();
            label17 = new Label();
            lblSearchFile = new Label();
            label19 = new Label();
            label16 = new Label();
            label9 = new Label();
            errorProvider1 = new ErrorProvider(components);
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            label21 = new Label();
            label22 = new Label();
            btnMyComputer = new Button();
            button1 = new Button();
            label1 = new Label();
            btnSearchPhoto = new Button();
            pnlBorder = new Panel();
            flowLayoutPanelArchive = new Panel();
            pnlArchiveContents = new Panel();
            lblExplanation = new Label();
            lblMainArchiveCaption = new Label();
            lblEmpty = new Label();
            btnAddSpareToArchive = new Button();
            btnMakeSpare = new Button();
            btnAddFoldersToArchive = new Button();
            pnlSearchPhoto = new Panel();
            pnlAddFoldersToArchive = new Panel();
            pnlMakeSpare = new Panel();
            pnlAddSpareToArchive = new Panel();
            pnlReceipt.SuspendLayout();
            pnlReceiptInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQty).BeginInit();
            pnlFindFolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoading).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            pnlBorder.SuspendLayout();
            flowLayoutPanelArchive.SuspendLayout();
            pnlArchiveContents.SuspendLayout();
            SuspendLayout();
            // 
            // btnFindFolder
            // 
            btnFindFolder.BackColor = Color.Transparent;
            btnFindFolder.BackgroundImage = Properties.Resources.btnFindFolder;
            btnFindFolder.BackgroundImageLayout = ImageLayout.Stretch;
            btnFindFolder.FlatAppearance.BorderSize = 0;
            btnFindFolder.FlatStyle = FlatStyle.Flat;
            btnFindFolder.Location = new Point(65, 341);
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
            btnCreateReceipt.Location = new Point(65, 636);
            btnCreateReceipt.Margin = new Padding(6);
            btnCreateReceipt.Name = "btnCreateReceipt";
            btnCreateReceipt.Size = new Size(186, 213);
            btnCreateReceipt.TabIndex = 0;
            btnCreateReceipt.UseVisualStyleBackColor = false;
            btnCreateReceipt.Click += btnCreateReceipt_Click;
            // 
            // pnlReceipt
            // 
            pnlReceipt.AutoSize = true;
            pnlReceipt.BackColor = Color.Transparent;
            pnlReceipt.Controls.Add(textBoxFileLocation);
            pnlReceipt.Controls.Add(label12);
            pnlReceipt.Controls.Add(lblFileLocation);
            pnlReceipt.Controls.Add(lblReceiptName);
            pnlReceipt.Controls.Add(lblSave);
            pnlReceipt.Controls.Add(lblSaveAndPrint);
            pnlReceipt.Controls.Add(label15);
            pnlReceipt.Controls.Add(pnlReceiptInputs);
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
            pnlReceipt.Location = new Point(128, 30);
            pnlReceipt.Margin = new Padding(6);
            pnlReceipt.Name = "pnlReceipt";
            pnlReceipt.Size = new Size(2305, 1355);
            pnlReceipt.TabIndex = 1;
            // 
            // textBoxFileLocation
            // 
            textBoxFileLocation.BackColor = SystemColors.ScrollBar;
            textBoxFileLocation.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFileLocation.Location = new Point(904, 410);
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
            label12.Location = new Point(1094, 1261);
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
            lblFileLocation.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFileLocation.ForeColor = SystemColors.MenuHighlight;
            lblFileLocation.Location = new Point(1478, 506);
            lblFileLocation.Margin = new Padding(6, 0, 6, 0);
            lblFileLocation.Name = "lblFileLocation";
            lblFileLocation.Size = new Size(0, 35);
            lblFileLocation.TabIndex = 2;
            // 
            // lblReceiptName
            // 
            lblReceiptName.AutoSize = true;
            lblReceiptName.FlatStyle = FlatStyle.Flat;
            lblReceiptName.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReceiptName.ForeColor = SystemColors.MenuHighlight;
            lblReceiptName.Location = new Point(1478, 629);
            lblReceiptName.Margin = new Padding(6, 0, 6, 0);
            lblReceiptName.Name = "lblReceiptName";
            lblReceiptName.Size = new Size(0, 35);
            lblReceiptName.TabIndex = 2;
            // 
            // lblSave
            // 
            lblSave.AutoSize = true;
            lblSave.FlatStyle = FlatStyle.Flat;
            lblSave.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSave.Location = new Point(1094, 1058);
            lblSave.Margin = new Padding(6, 0, 6, 0);
            lblSave.Name = "lblSave";
            lblSave.Size = new Size(125, 44);
            lblSave.TabIndex = 2;
            lblSave.Text = "Kaydet";
            // 
            // lblSaveAndPrint
            // 
            lblSaveAndPrint.AutoSize = true;
            lblSaveAndPrint.FlatStyle = FlatStyle.Flat;
            lblSaveAndPrint.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaveAndPrint.Location = new Point(1010, 811);
            lblSaveAndPrint.Margin = new Padding(6, 0, 6, 0);
            lblSaveAndPrint.Name = "lblSaveAndPrint";
            lblSaveAndPrint.Size = new Size(266, 44);
            lblSaveAndPrint.TabIndex = 2;
            lblSaveAndPrint.Text = "Kaydet ve Yazdır";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(1462, 1257);
            label15.Margin = new Padding(6, 0, 6, 0);
            label15.Name = "label15";
            label15.Size = new Size(238, 44);
            label15.TabIndex = 2;
            label15.Text = "Formu Temizle";
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
            pnlReceiptInputs.Location = new Point(11, 36);
            pnlReceiptInputs.Margin = new Padding(6);
            pnlReceiptInputs.Name = "pnlReceiptInputs";
            pnlReceiptInputs.Size = new Size(880, 1267);
            pnlReceiptInputs.TabIndex = 0;
            // 
            // numQty
            // 
            numQty.Font = new Font("Arial", 14.25F);
            numQty.Location = new Point(568, 309);
            numQty.Margin = new Padding(4, 2, 4, 2);
            numQty.Name = "numQty";
            numQty.Size = new Size(139, 51);
            numQty.TabIndex = 4;
            numQty.ValueChanged += txtName_TextChanged;
            // 
            // txtDeliveryDate
            // 
            txtDeliveryDate.Font = new Font("Arial", 14.25F);
            txtDeliveryDate.Location = new Point(500, 599);
            txtDeliveryDate.Margin = new Padding(6);
            txtDeliveryDate.Name = "txtDeliveryDate";
            txtDeliveryDate.Size = new Size(212, 51);
            txtDeliveryDate.TabIndex = 8;
            txtDeliveryDate.TextChanged += txtName_TextChanged;
            // 
            // txtRemainingAmount
            // 
            txtRemainingAmount.Font = new Font("Arial", 14.25F);
            txtRemainingAmount.Location = new Point(548, 480);
            txtRemainingAmount.Margin = new Padding(6);
            txtRemainingAmount.Name = "txtRemainingAmount";
            txtRemainingAmount.ReadOnly = true;
            txtRemainingAmount.Size = new Size(173, 51);
            txtRemainingAmount.TabIndex = 7;
            txtRemainingAmount.TextChanged += txtName_TextChanged;
            // 
            // txtReceivedAmount
            // 
            txtReceivedAmount.Font = new Font("Arial", 14.25F);
            txtReceivedAmount.Location = new Point(357, 480);
            txtReceivedAmount.Margin = new Padding(6);
            txtReceivedAmount.Name = "txtReceivedAmount";
            txtReceivedAmount.Size = new Size(173, 51);
            txtReceivedAmount.TabIndex = 6;
            txtReceivedAmount.TextChanged += TextBoxesAmount_TextChanged;
            txtReceivedAmount.LostFocus += TextBox_LostFocus;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Font = new Font("Arial", 14.25F);
            txtTotalAmount.Location = new Point(169, 480);
            txtTotalAmount.Margin = new Padding(6);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(173, 51);
            txtTotalAmount.TabIndex = 5;
            txtTotalAmount.TextChanged += TextBoxesAmount_TextChanged;
            txtTotalAmount.LostFocus += TextBox_LostFocus;
            // 
            // txtDimensions
            // 
            txtDimensions.Font = new Font("Arial", 14.25F);
            txtDimensions.Location = new Point(258, 307);
            txtDimensions.Margin = new Padding(6);
            txtDimensions.Name = "txtDimensions";
            txtDimensions.Size = new Size(197, 51);
            txtDimensions.TabIndex = 3;
            txtDimensions.TextChanged += txtName_TextChanged;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.Font = new Font("Arial", 14.25F);
            txtName.Location = new Point(169, 203);
            txtName.Margin = new Padding(6);
            txtName.Name = "txtName";
            txtName.Size = new Size(543, 51);
            txtName.TabIndex = 2;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtBoxNotes
            // 
            txtBoxNotes.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxNotes.Location = new Point(169, 736);
            txtBoxNotes.Margin = new Padding(6);
            txtBoxNotes.Name = "txtBoxNotes";
            txtBoxNotes.Size = new Size(543, 463);
            txtBoxNotes.TabIndex = 9;
            txtBoxNotes.Text = "";
            txtBoxNotes.TextChanged += txtName_TextChanged;
            // 
            // label5
            // 
            label5.Location = new Point(459, 314);
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
            label6.Location = new Point(188, 422);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(119, 49);
            label6.TabIndex = 0;
            label6.Text = "Tutar:";
            // 
            // label4
            // 
            label4.Location = new Point(169, 314);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(186, 49);
            label4.TabIndex = 0;
            label4.Text = "Ebat:";
            // 
            // label7
            // 
            label7.Location = new Point(279, 606);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(234, 49);
            label7.TabIndex = 0;
            label7.Text = "Teslim Tarihi:";
            // 
            // label8
            // 
            label8.Location = new Point(169, 681);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(186, 49);
            label8.TabIndex = 0;
            label8.Text = "Not:";
            // 
            // label2
            // 
            label2.Location = new Point(364, 425);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(141, 49);
            label2.TabIndex = 0;
            label2.Text = "Alınan:";
            // 
            // lblName
            // 
            lblName.Location = new Point(169, 149);
            lblName.Margin = new Padding(6, 0, 6, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(238, 49);
            lblName.TabIndex = 0;
            lblName.Text = "Ad - Soyad:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            label26.ForeColor = SystemColors.ControlText;
            label26.Location = new Point(1681, 926);
            label26.Margin = new Padding(6, 0, 6, 0);
            label26.Name = "label26";
            label26.Size = new Size(215, 44);
            label26.TabIndex = 2;
            label26.Text = "Makbuza Git";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            label14.ForeColor = SystemColors.ControlText;
            label14.Location = new Point(1462, 926);
            label14.Margin = new Padding(6, 0, 6, 0);
            label14.Name = "label14";
            label14.Size = new Size(186, 44);
            label14.TabIndex = 2;
            label14.Text = "Klasöre Git";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label25.Location = new Point(1478, 561);
            label25.Margin = new Padding(6, 0, 6, 0);
            label25.Name = "label25";
            label25.Size = new Size(280, 57);
            label25.TabIndex = 2;
            label25.Text = "Makbuz Adı:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label24.Location = new Point(1478, 431);
            label24.Margin = new Padding(6, 0, 6, 0);
            label24.Name = "label24";
            label24.Size = new Size(282, 57);
            label24.TabIndex = 2;
            label24.Text = "Klasör           :";
            // 
            // lblReceiptCaption
            // 
            lblReceiptCaption.AutoSize = true;
            lblReceiptCaption.Font = new Font("Palatino Linotype", 17.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblReceiptCaption.Location = new Point(1478, 365);
            lblReceiptCaption.Margin = new Padding(6, 0, 6, 0);
            lblReceiptCaption.Name = "lblReceiptCaption";
            lblReceiptCaption.Size = new Size(483, 62);
            lblReceiptCaption.TabIndex = 2;
            lblReceiptCaption.Text = "Oluşturulan Makbuz:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(995, 346);
            label13.Margin = new Padding(6, 0, 6, 0);
            label13.Name = "label13";
            label13.Size = new Size(299, 51);
            label13.TabIndex = 2;
            label13.Text = "Seçilen Konum:";
            // 
            // btnTrash
            // 
            btnTrash.BackgroundImage = Properties.Resources.btnTrash;
            btnTrash.BackgroundImageLayout = ImageLayout.Stretch;
            btnTrash.FlatAppearance.BorderSize = 0;
            btnTrash.FlatStyle = FlatStyle.Flat;
            btnTrash.Location = new Point(1484, 1082);
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
            btnPrint.Location = new Point(1075, 1124);
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
            btnChooseFileLocation.Location = new Point(1038, 181);
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
            btnSaveAndPrint.Location = new Point(966, 531);
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
            btnSave.Location = new Point(1075, 926);
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
            btnGoReceipt.Location = new Point(1697, 749);
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
            btnGoTheFolder.Location = new Point(1478, 749);
            btnGoTheFolder.Margin = new Padding(6);
            btnGoTheFolder.Name = "btnGoTheFolder";
            btnGoTheFolder.Size = new Size(149, 171);
            btnGoTheFolder.TabIndex = 14;
            btnGoTheFolder.UseVisualStyleBackColor = true;
            btnGoTheFolder.Click += btnGoTheFolder_Click;
            // 
            // pnlFindFolder
            // 
            pnlFindFolder.BackColor = Color.Transparent;
            pnlFindFolder.Controls.Add(pictureBoxLoading);
            pnlFindFolder.Controls.Add(listBoxFiles);
            pnlFindFolder.Controls.Add(txtFileNameInput);
            pnlFindFolder.Controls.Add(btnSearchFile);
            pnlFindFolder.Controls.Add(cmbBoxDriver);
            pnlFindFolder.Controls.Add(label18);
            pnlFindFolder.Controls.Add(label17);
            pnlFindFolder.Controls.Add(lblSearchFile);
            pnlFindFolder.Controls.Add(label19);
            pnlFindFolder.Controls.Add(label16);
            pnlFindFolder.Location = new Point(386, 9);
            pnlFindFolder.Margin = new Padding(4, 2, 4, 2);
            pnlFindFolder.Name = "pnlFindFolder";
            pnlFindFolder.Size = new Size(1842, 1237);
            pnlFindFolder.TabIndex = 16;
            // 
            // pictureBoxLoading
            // 
            pictureBoxLoading.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxLoading.Image = Properties.Resources.loading;
            pictureBoxLoading.InitialImage = Properties.Resources.loading;
            pictureBoxLoading.Location = new Point(654, 459);
            pictureBoxLoading.Margin = new Padding(4, 2, 4, 2);
            pictureBoxLoading.Name = "pictureBoxLoading";
            pictureBoxLoading.Size = new Size(251, 250);
            pictureBoxLoading.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLoading.TabIndex = 6;
            pictureBoxLoading.TabStop = false;
            // 
            // listBoxFiles
            // 
            listBoxFiles.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxFiles.FormattingEnabled = true;
            listBoxFiles.HorizontalScrollbar = true;
            listBoxFiles.ItemHeight = 45;
            listBoxFiles.Location = new Point(358, 930);
            listBoxFiles.Margin = new Padding(4, 2, 4, 2);
            listBoxFiles.Name = "listBoxFiles";
            listBoxFiles.Size = new Size(938, 184);
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
            label17.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold);
            label17.ForeColor = SystemColors.ActiveCaptionText;
            label17.Location = new Point(323, 224);
            label17.Margin = new Padding(6, 0, 6, 0);
            label17.Name = "label17";
            label17.Size = new Size(282, 65);
            label17.TabIndex = 2;
            label17.Text = "Sürücü Seç:";
            // 
            // lblSearchFile
            // 
            lblSearchFile.AutoSize = true;
            lblSearchFile.BackColor = Color.Transparent;
            lblSearchFile.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchFile.ForeColor = SystemColors.ActiveCaptionText;
            lblSearchFile.Location = new Point(728, 710);
            lblSearchFile.Margin = new Padding(6, 0, 6, 0);
            lblSearchFile.Name = "lblSearchFile";
            lblSearchFile.Size = new Size(108, 65);
            lblSearchFile.TabIndex = 2;
            lblSearchFile.Text = "Ara";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = SystemColors.ActiveCaptionText;
            label19.Location = new Point(589, 860);
            label19.Margin = new Padding(6, 0, 6, 0);
            label19.Name = "label19";
            label19.Size = new Size(443, 65);
            label19.TabIndex = 2;
            label19.Text = "Bulunan Klasörler:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold);
            label16.ForeColor = SystemColors.ActiveCaptionText;
            label16.Location = new Point(1033, 224);
            label16.Margin = new Padding(6, 0, 6, 0);
            label16.Name = "label16";
            label16.Size = new Size(363, 65);
            label16.TabIndex = 2;
            label16.Text = "Klasör Adı Gir:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(65, 849);
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
            label21.Location = new Point(65, 565);
            label21.Margin = new Padding(6, 0, 6, 0);
            label21.Name = "label21";
            label21.Size = new Size(174, 44);
            label21.TabIndex = 2;
            label21.Text = "Klasör Ara";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = SystemColors.ButtonFace;
            label22.Location = new Point(65, 279);
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
            btnMyComputer.Location = new Point(65, 60);
            btnMyComputer.Margin = new Padding(6);
            btnMyComputer.Name = "btnMyComputer";
            btnMyComputer.Size = new Size(186, 213);
            btnMyComputer.TabIndex = 0;
            btnMyComputer.UseVisualStyleBackColor = false;
            btnMyComputer.Click += btnMyComputer_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.btnArchive;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(65, 938);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(186, 213);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += flowLayoutPanelArchive_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(110, 1158);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 44);
            label1.TabIndex = 2;
            label1.Text = "Arşiv";
            // 
            // btnSearchPhoto
            // 
            btnSearchPhoto.BackColor = Color.Gold;
            btnSearchPhoto.BackgroundImageLayout = ImageLayout.None;
            btnSearchPhoto.FlatAppearance.BorderColor = Color.Black;
            btnSearchPhoto.FlatAppearance.BorderSize = 3;
            btnSearchPhoto.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnSearchPhoto.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnSearchPhoto.FlatStyle = FlatStyle.Flat;
            btnSearchPhoto.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchPhoto.Location = new Point(14, 311);
            btnSearchPhoto.Margin = new Padding(15);
            btnSearchPhoto.Name = "btnSearchPhoto";
            btnSearchPhoto.Size = new Size(275, 200);
            btnSearchPhoto.TabIndex = 19;
            btnSearchPhoto.Text = "Arşivde Fotoğraf Ara";
            btnSearchPhoto.UseVisualStyleBackColor = false;
            btnSearchPhoto.Click += btnSearchPhoto_Click;
            // 
            // pnlBorder
            // 
            pnlBorder.Anchor = AnchorStyles.Top;
            pnlBorder.BackColor = Color.Silver;
            pnlBorder.Controls.Add(flowLayoutPanelArchive);
            pnlBorder.Controls.Add(pnlReceipt);
            pnlBorder.Controls.Add(pnlFindFolder);
            pnlBorder.Location = new Point(334, 203);
            pnlBorder.Margin = new Padding(6);
            pnlBorder.Name = "pnlBorder";
            pnlBorder.Size = new Size(2535, 1401);
            pnlBorder.TabIndex = 18;
            // 
            // flowLayoutPanelArchive
            // 
            flowLayoutPanelArchive.BackColor = Color.Transparent;
            flowLayoutPanelArchive.Controls.Add(pnlArchiveContents);
            flowLayoutPanelArchive.Controls.Add(lblExplanation);
            flowLayoutPanelArchive.Controls.Add(lblMainArchiveCaption);
            flowLayoutPanelArchive.Controls.Add(lblEmpty);
            flowLayoutPanelArchive.Controls.Add(btnAddSpareToArchive);
            flowLayoutPanelArchive.Controls.Add(btnMakeSpare);
            flowLayoutPanelArchive.Controls.Add(btnAddFoldersToArchive);
            flowLayoutPanelArchive.Controls.Add(btnSearchPhoto);
            flowLayoutPanelArchive.Location = new Point(10, 51);
            flowLayoutPanelArchive.Margin = new Padding(6);
            flowLayoutPanelArchive.Name = "flowLayoutPanelArchive";
            flowLayoutPanelArchive.Size = new Size(2507, 1244);
            flowLayoutPanelArchive.TabIndex = 17;
            // 
            // pnlArchiveContents
            // 
            pnlArchiveContents.Controls.Add(pnlAddSpareToArchive);
            pnlArchiveContents.Controls.Add(pnlMakeSpare);
            pnlArchiveContents.Controls.Add(pnlAddFoldersToArchive);
            pnlArchiveContents.Controls.Add(pnlSearchPhoto);
            pnlArchiveContents.Location = new Point(307, 319);
            pnlArchiveContents.Name = "pnlArchiveContents";
            pnlArchiveContents.Size = new Size(2186, 913);
            pnlArchiveContents.TabIndex = 21;
            // 
            // lblExplanation
            // 
            lblExplanation.BackColor = Color.Silver;
            lblExplanation.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblExplanation.ForeColor = SystemColors.WindowFrame;
            lblExplanation.Location = new Point(391, 15);
            lblExplanation.Name = "lblExplanation";
            lblExplanation.Size = new Size(2102, 301);
            lblExplanation.TabIndex = 20;
            // 
            // lblMainArchiveCaption
            // 
            lblMainArchiveCaption.AutoSize = true;
            lblMainArchiveCaption.Font = new Font("Comic Sans MS", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMainArchiveCaption.ForeColor = Color.Black;
            lblMainArchiveCaption.Location = new Point(567, 44);
            lblMainArchiveCaption.Name = "lblMainArchiveCaption";
            lblMainArchiveCaption.Size = new Size(1278, 178);
            lblMainArchiveCaption.TabIndex = 0;
            lblMainArchiveCaption.Text = "ARŞİV İŞLEMLERİ";
            // 
            // lblEmpty
            // 
            lblEmpty.Font = new Font("Comic Sans MS", 14.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmpty.Location = new Point(14, 69);
            lblEmpty.Name = "lblEmpty";
            lblEmpty.Size = new Size(351, 174);
            lblEmpty.TabIndex = 1;
            // 
            // btnAddSpareToArchive
            // 
            btnAddSpareToArchive.BackColor = Color.Gold;
            btnAddSpareToArchive.BackgroundImageLayout = ImageLayout.None;
            btnAddSpareToArchive.FlatAppearance.BorderColor = Color.Black;
            btnAddSpareToArchive.FlatAppearance.BorderSize = 3;
            btnAddSpareToArchive.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnAddSpareToArchive.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnAddSpareToArchive.FlatStyle = FlatStyle.Flat;
            btnAddSpareToArchive.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddSpareToArchive.Location = new Point(14, 1001);
            btnAddSpareToArchive.Margin = new Padding(15);
            btnAddSpareToArchive.Name = "btnAddSpareToArchive";
            btnAddSpareToArchive.Size = new Size(275, 200);
            btnAddSpareToArchive.TabIndex = 19;
            btnAddSpareToArchive.Text = "Yedeği Arşive Yükle";
            btnAddSpareToArchive.UseVisualStyleBackColor = false;
            btnAddSpareToArchive.Click += btnAddSpareToArchive_Click;
            // 
            // btnMakeSpare
            // 
            btnMakeSpare.BackColor = Color.Gold;
            btnMakeSpare.BackgroundImageLayout = ImageLayout.None;
            btnMakeSpare.FlatAppearance.BorderColor = Color.Black;
            btnMakeSpare.FlatAppearance.BorderSize = 3;
            btnMakeSpare.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnMakeSpare.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnMakeSpare.FlatStyle = FlatStyle.Flat;
            btnMakeSpare.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMakeSpare.Location = new Point(14, 771);
            btnMakeSpare.Margin = new Padding(15);
            btnMakeSpare.Name = "btnMakeSpare";
            btnMakeSpare.Size = new Size(275, 200);
            btnMakeSpare.TabIndex = 19;
            btnMakeSpare.Text = "Arşivi Yedekle";
            btnMakeSpare.UseVisualStyleBackColor = false;
            btnMakeSpare.Click += btnMakeSpare_Click;
            // 
            // btnAddFoldersToArchive
            // 
            btnAddFoldersToArchive.BackColor = Color.Gold;
            btnAddFoldersToArchive.BackgroundImageLayout = ImageLayout.None;
            btnAddFoldersToArchive.FlatAppearance.BorderColor = Color.Black;
            btnAddFoldersToArchive.FlatAppearance.BorderSize = 3;
            btnAddFoldersToArchive.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnAddFoldersToArchive.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnAddFoldersToArchive.FlatStyle = FlatStyle.Flat;
            btnAddFoldersToArchive.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddFoldersToArchive.Location = new Point(14, 541);
            btnAddFoldersToArchive.Margin = new Padding(15);
            btnAddFoldersToArchive.Name = "btnAddFoldersToArchive";
            btnAddFoldersToArchive.Size = new Size(275, 200);
            btnAddFoldersToArchive.TabIndex = 19;
            btnAddFoldersToArchive.Text = "Hazırlanan Dosyaları Arşive Ekle";
            btnAddFoldersToArchive.UseVisualStyleBackColor = false;
            btnAddFoldersToArchive.Click += btnAddFoldersToArchive_Click;
            // 
            // pnlSearchPhoto
            // 
            pnlSearchPhoto.Location = new Point(10, 60);
            pnlSearchPhoto.Name = "pnlSearchPhoto";
            pnlSearchPhoto.Size = new Size(2163, 802);
            pnlSearchPhoto.TabIndex = 0;
            // 
            // pnlAddFoldersToArchive
            // 
            pnlAddFoldersToArchive.Location = new Point(24, 36);
            pnlAddFoldersToArchive.Name = "pnlAddFoldersToArchive";
            pnlAddFoldersToArchive.Size = new Size(2135, 840);
            pnlAddFoldersToArchive.TabIndex = 1;
            // 
            // pnlMakeSpare
            // 
            pnlMakeSpare.Location = new Point(45, 25);
            pnlMakeSpare.Name = "pnlMakeSpare";
            pnlMakeSpare.Size = new Size(2101, 870);
            pnlMakeSpare.TabIndex = 2;
            // 
            // pnlAddSpareToArchive
            // 
            pnlAddSpareToArchive.Location = new Point(69, 3);
            pnlAddSpareToArchive.Name = "pnlAddSpareToArchive";
            pnlAddSpareToArchive.Size = new Size(2069, 898);
            pnlAddSpareToArchive.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ArkaFon;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2884, 1759);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(label21);
            Controls.Add(button1);
            Controls.Add(btnCreateReceipt);
            Controls.Add(btnFindFolder);
            Controls.Add(btnMyComputer);
            Controls.Add(label22);
            Controls.Add(pnlBorder);
            DoubleBuffered = true;
            Margin = new Padding(6);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stüdyo-emin";
            pnlReceipt.ResumeLayout(false);
            pnlReceipt.PerformLayout();
            pnlReceiptInputs.ResumeLayout(false);
            pnlReceiptInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQty).EndInit();
            pnlFindFolder.ResumeLayout(false);
            pnlFindFolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoading).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            pnlBorder.ResumeLayout(false);
            pnlBorder.PerformLayout();
            flowLayoutPanelArchive.ResumeLayout(false);
            flowLayoutPanelArchive.PerformLayout();
            pnlArchiveContents.ResumeLayout(false);
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
        private Label lblSaveAndPrint;
        private Label label9;
        private Label label12;
        private Label lblSave;
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
        private Label lblSearchFile;
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
        private PictureBox pictureBoxLoading;
        private ToolStripMenuItem arşivİşlemleriToolStripMenuItem;
        private TabControl tabControlMenu;
        private TabPage tabMenu;
        private TabPage tabPage2;
        private Label label1;
        private Button button1;
        private Button btnSearchPhoto;
        private Panel pnlBorder;
        private Panel flowLayoutPanelArchive;
        private Button btnMakeSpare;
        private Button btnAddFoldersToArchive;
        private Button btnAddSpareToArchive;
        private Label lblMainArchiveCaption;
        private Label lblEmpty;
        private Label lblExplanation;
        private Panel pnlArchiveContents;
        private Panel pnlSearchPhoto;
        private Panel pnlAddFoldersToArchive;
        private Panel pnlMakeSpare;
        private Panel pnlAddSpareToArchive;
    }
}
