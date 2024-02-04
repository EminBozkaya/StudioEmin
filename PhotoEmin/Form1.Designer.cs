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
            pnlAddSpareToArchive = new Panel();
            label34 = new Label();
            label35 = new Label();
            button2 = new Button();
            txtLocationOfSpareFolder = new TextBox();
            label36 = new Label();
            button3 = new Button();
            label37 = new Label();
            label38 = new Label();
            pnlMakeSpare = new Panel();
            label33 = new Label();
            label32 = new Label();
            btnDBtoFolder = new Button();
            txtLocationForArchive = new TextBox();
            label31 = new Label();
            btnLocationForArchive = new Button();
            label30 = new Label();
            label29 = new Label();
            pnlAddFoldersToArchive = new Panel();
            label28 = new Label();
            btnAddFolderToArchive = new Button();
            label27 = new Label();
            txtChosenUpperFolder = new TextBox();
            label23 = new Label();
            btnChooseUpperFolder = new Button();
            label20 = new Label();
            label11 = new Label();
            label10 = new Label();
            pnlSearchPhoto = new Panel();
            lblGoRecord = new Label();
            btnGoRecord = new Button();
            comboBoxDriversForRecord = new ComboBox();
            lblChooseDriver = new Label();
            pictureBoxChosenPhoto = new PictureBox();
            dataGridRecords = new DataGridView();
            lblFoundPhoto = new Label();
            lblFound = new Label();
            txtFullName = new TextBox();
            lblFullName = new Label();
            lblExplanation = new Label();
            lblMainArchiveCaption = new Label();
            lblEmpty = new Label();
            btnAddSpareToArchive = new Button();
            btnMakeSpare = new Button();
            btnAddFoldersToArchive = new Button();
            pnlReceipt.SuspendLayout();
            pnlReceiptInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQty).BeginInit();
            pnlFindFolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoading).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            pnlBorder.SuspendLayout();
            flowLayoutPanelArchive.SuspendLayout();
            pnlArchiveContents.SuspendLayout();
            pnlAddSpareToArchive.SuspendLayout();
            pnlMakeSpare.SuspendLayout();
            pnlAddFoldersToArchive.SuspendLayout();
            pnlSearchPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChosenPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridRecords).BeginInit();
            SuspendLayout();
            // 
            // btnFindFolder
            // 
            btnFindFolder.BackColor = Color.Transparent;
            btnFindFolder.BackgroundImage = Extensions.Resources.btnFindFolder;
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
            btnCreateReceipt.BackgroundImage = Extensions.Resources.btnrNewReceipt;
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
            pnlReceipt.Size = new Size(2381, 1355);
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
            pnlReceiptInputs.BackgroundImage = Extensions.Resources.printPAPER;
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
            btnTrash.BackgroundImage = Extensions.Resources.btnTrash;
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
            btnPrint.BackgroundImage = Extensions.Resources.btnPrint;
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
            btnChooseFileLocation.BackgroundImage = Extensions.Resources.btnHardDrive;
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
            btnSaveAndPrint.BackgroundImage = Extensions.Resources.btnSaveAndPrind;
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
            btnSave.BackgroundImage = Extensions.Resources.btnSave;
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
            btnGoReceipt.BackgroundImage = Extensions.Resources.btnGoReceipt;
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
            btnGoTheFolder.BackgroundImage = Extensions.Resources.btnOpenFolder;
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
            pictureBoxLoading.Image = Extensions.Resources.loading;
            pictureBoxLoading.InitialImage = Extensions.Resources.loading;
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
            listBoxFiles.Size = new Size(938, 139);
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
            btnSearchFile.BackgroundImage = Extensions.Resources.btnSearchFolder;
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
            btnMyComputer.BackgroundImage = Extensions.Resources.btnMyComputer;
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
            button1.BackgroundImage = Extensions.Resources.btnArchive;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(65, 939);
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
            btnSearchPhoto.BackColor = SystemColors.ControlDarkDark;
            btnSearchPhoto.BackgroundImageLayout = ImageLayout.None;
            btnSearchPhoto.FlatAppearance.BorderColor = Color.White;
            btnSearchPhoto.FlatAppearance.BorderSize = 5;
            btnSearchPhoto.FlatAppearance.MouseDownBackColor = Color.Gold;
            btnSearchPhoto.FlatAppearance.MouseOverBackColor = Color.Black;
            btnSearchPhoto.FlatStyle = FlatStyle.Flat;
            btnSearchPhoto.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnSearchPhoto.ForeColor = Color.White;
            btnSearchPhoto.Location = new Point(15, 332);
            btnSearchPhoto.Margin = new Padding(15);
            btnSearchPhoto.Name = "btnSearchPhoto";
            btnSearchPhoto.Size = new Size(275, 201);
            btnSearchPhoto.TabIndex = 19;
            btnSearchPhoto.Text = "Arşivde Kayıt Ara";
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
            pnlBorder.Location = new Point(500, 198);
            pnlBorder.Margin = new Padding(6);
            pnlBorder.Name = "pnlBorder";
            pnlBorder.Size = new Size(2535, 1402);
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
            flowLayoutPanelArchive.Location = new Point(9, 51);
            flowLayoutPanelArchive.Margin = new Padding(6);
            flowLayoutPanelArchive.Name = "flowLayoutPanelArchive";
            flowLayoutPanelArchive.Size = new Size(2507, 1244);
            flowLayoutPanelArchive.TabIndex = 17;
            // 
            // pnlArchiveContents
            // 
            pnlArchiveContents.BorderStyle = BorderStyle.FixedSingle;
            pnlArchiveContents.Controls.Add(pnlAddSpareToArchive);
            pnlArchiveContents.Controls.Add(pnlMakeSpare);
            pnlArchiveContents.Controls.Add(pnlAddFoldersToArchive);
            pnlArchiveContents.Controls.Add(pnlSearchPhoto);
            pnlArchiveContents.Location = new Point(306, 320);
            pnlArchiveContents.Margin = new Padding(4, 2, 4, 2);
            pnlArchiveContents.Name = "pnlArchiveContents";
            pnlArchiveContents.Size = new Size(2186, 913);
            pnlArchiveContents.TabIndex = 21;
            // 
            // pnlAddSpareToArchive
            // 
            pnlAddSpareToArchive.Controls.Add(label34);
            pnlAddSpareToArchive.Controls.Add(label35);
            pnlAddSpareToArchive.Controls.Add(button2);
            pnlAddSpareToArchive.Controls.Add(txtLocationOfSpareFolder);
            pnlAddSpareToArchive.Controls.Add(label36);
            pnlAddSpareToArchive.Controls.Add(button3);
            pnlAddSpareToArchive.Controls.Add(label37);
            pnlAddSpareToArchive.Controls.Add(label38);
            pnlAddSpareToArchive.Location = new Point(69, 2);
            pnlAddSpareToArchive.Margin = new Padding(4, 2, 4, 2);
            pnlAddSpareToArchive.Name = "pnlAddSpareToArchive";
            pnlAddSpareToArchive.Size = new Size(2069, 898);
            pnlAddSpareToArchive.TabIndex = 0;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label34.ForeColor = Color.GhostWhite;
            label34.Location = new Point(916, 303);
            label34.Margin = new Padding(6, 0, 6, 0);
            label34.Name = "label34";
            label34.Size = new Size(300, 254);
            label34.TabIndex = 28;
            label34.Text = "➪";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.BackColor = Color.Gray;
            label35.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label35.ForeColor = SystemColors.ButtonHighlight;
            label35.Location = new Point(1361, 587);
            label35.Margin = new Padding(6, 0, 6, 0);
            label35.Name = "label35";
            label35.Size = new Size(492, 51);
            label35.TabIndex = 27;
            label35.Text = "Yedek Dosyayı Arşive Ekle";
            // 
            // button2
            // 
            button2.BackgroundImage = Extensions.Resources.btnFolderToDB;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1332, 256);
            button2.Margin = new Padding(6);
            button2.Name = "button2";
            button2.Size = new Size(552, 343);
            button2.TabIndex = 26;
            button2.UseVisualStyleBackColor = true;
            // 
            // txtLocationOfSpareFolder
            // 
            txtLocationOfSpareFolder.BackColor = SystemColors.ScrollBar;
            txtLocationOfSpareFolder.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLocationOfSpareFolder.Location = new Point(146, 659);
            txtLocationOfSpareFolder.Margin = new Padding(6);
            txtLocationOfSpareFolder.Name = "txtLocationOfSpareFolder";
            txtLocationOfSpareFolder.ReadOnly = true;
            txtLocationOfSpareFolder.Size = new Size(768, 57);
            txtLocationOfSpareFolder.TabIndex = 25;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label36.Location = new Point(319, 597);
            label36.Margin = new Padding(6, 0, 6, 0);
            label36.Name = "label36";
            label36.Size = new Size(424, 51);
            label36.TabIndex = 23;
            label36.Text = "Seçilen Yedek Dosyası:";
            // 
            // button3
            // 
            button3.BackgroundImage = Extensions.Resources.btnSpareFolder;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(366, 356);
            button3.Margin = new Padding(6);
            button3.Name = "button3";
            button3.Size = new Size(258, 235);
            button3.TabIndex = 24;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label37.ForeColor = Color.Black;
            label37.Location = new Point(366, 262);
            label37.Margin = new Padding(6, 0, 6, 0);
            label37.Name = "label37";
            label37.Size = new Size(304, 51);
            label37.TabIndex = 22;
            label37.Text = "Dosyayı Seçiniz:";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label38.ForeColor = Color.Black;
            label38.Location = new Point(254, 188);
            label38.Margin = new Padding(6, 0, 6, 0);
            label38.Name = "label38";
            label38.Size = new Size(547, 51);
            label38.TabIndex = 21;
            label38.Text = "Daha önceden yedeklediğiniz";
            // 
            // pnlMakeSpare
            // 
            pnlMakeSpare.Controls.Add(label33);
            pnlMakeSpare.Controls.Add(label32);
            pnlMakeSpare.Controls.Add(btnDBtoFolder);
            pnlMakeSpare.Controls.Add(txtLocationForArchive);
            pnlMakeSpare.Controls.Add(label31);
            pnlMakeSpare.Controls.Add(btnLocationForArchive);
            pnlMakeSpare.Controls.Add(label30);
            pnlMakeSpare.Controls.Add(label29);
            pnlMakeSpare.Location = new Point(45, 26);
            pnlMakeSpare.Margin = new Padding(4, 2, 4, 2);
            pnlMakeSpare.Name = "pnlMakeSpare";
            pnlMakeSpare.Size = new Size(2100, 870);
            pnlMakeSpare.TabIndex = 2;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label33.ForeColor = Color.GhostWhite;
            label33.Location = new Point(895, 241);
            label33.Margin = new Padding(6, 0, 6, 0);
            label33.Name = "label33";
            label33.Size = new Size(300, 254);
            label33.TabIndex = 20;
            label33.Text = "➪";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.BackColor = Color.Gray;
            label32.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label32.ForeColor = SystemColors.ButtonHighlight;
            label32.Location = new Point(1404, 533);
            label32.Margin = new Padding(6, 0, 6, 0);
            label32.Name = "label32";
            label32.Size = new Size(437, 51);
            label32.TabIndex = 19;
            label32.Text = "Arşivi Dosyaya Yedekle";
            // 
            // btnDBtoFolder
            // 
            btnDBtoFolder.BackgroundImage = Extensions.Resources.btnDBtoFolder;
            btnDBtoFolder.BackgroundImageLayout = ImageLayout.Stretch;
            btnDBtoFolder.FlatAppearance.BorderSize = 0;
            btnDBtoFolder.FlatStyle = FlatStyle.Flat;
            btnDBtoFolder.Location = new Point(1311, 194);
            btnDBtoFolder.Margin = new Padding(6);
            btnDBtoFolder.Name = "btnDBtoFolder";
            btnDBtoFolder.Size = new Size(552, 343);
            btnDBtoFolder.TabIndex = 18;
            btnDBtoFolder.UseVisualStyleBackColor = true;
            // 
            // txtLocationForArchive
            // 
            txtLocationForArchive.BackColor = SystemColors.ScrollBar;
            txtLocationForArchive.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLocationForArchive.Location = new Point(90, 600);
            txtLocationForArchive.Margin = new Padding(6);
            txtLocationForArchive.Name = "txtLocationForArchive";
            txtLocationForArchive.ReadOnly = true;
            txtLocationForArchive.Size = new Size(827, 57);
            txtLocationForArchive.TabIndex = 17;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label31.Location = new Point(347, 535);
            label31.Margin = new Padding(6, 0, 6, 0);
            label31.Name = "label31";
            label31.Size = new Size(299, 51);
            label31.TabIndex = 15;
            label31.Text = "Seçilen Konum:";
            // 
            // btnLocationForArchive
            // 
            btnLocationForArchive.BackgroundImage = Extensions.Resources.btnChosenLocation;
            btnLocationForArchive.BackgroundImageLayout = ImageLayout.Stretch;
            btnLocationForArchive.FlatAppearance.BorderSize = 0;
            btnLocationForArchive.FlatStyle = FlatStyle.Flat;
            btnLocationForArchive.Location = new Point(371, 314);
            btnLocationForArchive.Margin = new Padding(6);
            btnLocationForArchive.Name = "btnLocationForArchive";
            btnLocationForArchive.Size = new Size(232, 215);
            btnLocationForArchive.TabIndex = 16;
            btnLocationForArchive.UseVisualStyleBackColor = true;
            btnLocationForArchive.Click += btnLocationForArchive_Click;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label30.ForeColor = Color.Black;
            label30.Location = new Point(279, 194);
            label30.Margin = new Padding(6, 0, 6, 0);
            label30.Name = "label30";
            label30.Size = new Size(435, 51);
            label30.TabIndex = 4;
            label30.Text = "Dosya Konumu Seçiniz:";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label29.ForeColor = Color.Black;
            label29.Location = new Point(167, 119);
            label29.Margin = new Padding(6, 0, 6, 0);
            label29.Name = "label29";
            label29.Size = new Size(722, 51);
            label29.TabIndex = 3;
            label29.Text = "Veri Tabanındaki arşivi yedeklemek için";
            // 
            // pnlAddFoldersToArchive
            // 
            pnlAddFoldersToArchive.Controls.Add(label28);
            pnlAddFoldersToArchive.Controls.Add(btnAddFolderToArchive);
            pnlAddFoldersToArchive.Controls.Add(label27);
            pnlAddFoldersToArchive.Controls.Add(txtChosenUpperFolder);
            pnlAddFoldersToArchive.Controls.Add(label23);
            pnlAddFoldersToArchive.Controls.Add(btnChooseUpperFolder);
            pnlAddFoldersToArchive.Controls.Add(label20);
            pnlAddFoldersToArchive.Controls.Add(label11);
            pnlAddFoldersToArchive.Controls.Add(label10);
            pnlAddFoldersToArchive.Location = new Point(24, 36);
            pnlAddFoldersToArchive.Margin = new Padding(4, 2, 4, 2);
            pnlAddFoldersToArchive.Name = "pnlAddFoldersToArchive";
            pnlAddFoldersToArchive.Size = new Size(2136, 841);
            pnlAddFoldersToArchive.TabIndex = 1;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.BackColor = Color.DarkOrange;
            label28.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label28.ForeColor = Color.White;
            label28.Location = new Point(1543, 555);
            label28.Margin = new Padding(6, 0, 6, 0);
            label28.Name = "label28";
            label28.Size = new Size(247, 57);
            label28.TabIndex = 20;
            label28.Text = "Arşive Ekle";
            // 
            // btnAddFolderToArchive
            // 
            btnAddFolderToArchive.BackColor = Color.Transparent;
            btnAddFolderToArchive.BackgroundImage = Extensions.Resources.btnDB;
            btnAddFolderToArchive.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddFolderToArchive.FlatAppearance.BorderSize = 0;
            btnAddFolderToArchive.FlatStyle = FlatStyle.Flat;
            btnAddFolderToArchive.Location = new Point(1488, 173);
            btnAddFolderToArchive.Margin = new Padding(6);
            btnAddFolderToArchive.Name = "btnAddFolderToArchive";
            btnAddFolderToArchive.Size = new Size(334, 382);
            btnAddFolderToArchive.TabIndex = 19;
            btnAddFolderToArchive.UseVisualStyleBackColor = false;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label27.ForeColor = Color.GhostWhite;
            label27.Location = new Point(971, 258);
            label27.Margin = new Padding(6, 0, 6, 0);
            label27.Name = "label27";
            label27.Size = new Size(300, 254);
            label27.TabIndex = 18;
            label27.Text = "➪";
            // 
            // txtChosenUpperFolder
            // 
            txtChosenUpperFolder.BackColor = SystemColors.ScrollBar;
            txtChosenUpperFolder.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtChosenUpperFolder.ForeColor = SystemColors.MenuHighlight;
            txtChosenUpperFolder.Location = new Point(87, 678);
            txtChosenUpperFolder.Margin = new Padding(6);
            txtChosenUpperFolder.Name = "txtChosenUpperFolder";
            txtChosenUpperFolder.ReadOnly = true;
            txtChosenUpperFolder.Size = new Size(864, 58);
            txtChosenUpperFolder.TabIndex = 17;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.Location = new Point(156, 610);
            label23.Margin = new Padding(6, 0, 6, 0);
            label23.Name = "label23";
            label23.Size = new Size(709, 51);
            label23.TabIndex = 15;
            label23.Text = "Arşive Eklemek İçin Seçilen Üst Klasör";
            // 
            // btnChooseUpperFolder
            // 
            btnChooseUpperFolder.BackgroundImage = Extensions.Resources.btnChooseUpperFolder;
            btnChooseUpperFolder.BackgroundImageLayout = ImageLayout.Stretch;
            btnChooseUpperFolder.FlatAppearance.BorderSize = 0;
            btnChooseUpperFolder.FlatStyle = FlatStyle.Flat;
            btnChooseUpperFolder.Location = new Point(347, 322);
            btnChooseUpperFolder.Margin = new Padding(6);
            btnChooseUpperFolder.Name = "btnChooseUpperFolder";
            btnChooseUpperFolder.Size = new Size(290, 277);
            btnChooseUpperFolder.TabIndex = 16;
            btnChooseUpperFolder.UseVisualStyleBackColor = true;
            btnChooseUpperFolder.Click += btnChooseUpperFolder_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.Black;
            label20.Location = new Point(188, 162);
            label20.Margin = new Padding(6, 0, 6, 0);
            label20.Name = "label20";
            label20.Size = new Size(771, 51);
            label20.TabIndex = 3;
            label20.Text = "müşterilerin kayıt dosyalarını bulunduran,";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(191, 239);
            label11.Margin = new Padding(6, 0, 6, 0);
            label11.Name = "label11";
            label11.Size = new Size(526, 51);
            label11.TabIndex = 2;
            label11.Text = "ÜST KLASÖRÜNÜZÜ Seçiniz:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(191, 87);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(421, 51);
            label10.TabIndex = 1;
            label10.Text = "Hazırlamış olduğunuz,";
            // 
            // pnlSearchPhoto
            // 
            pnlSearchPhoto.Controls.Add(lblGoRecord);
            pnlSearchPhoto.Controls.Add(btnGoRecord);
            pnlSearchPhoto.Controls.Add(comboBoxDriversForRecord);
            pnlSearchPhoto.Controls.Add(lblChooseDriver);
            pnlSearchPhoto.Controls.Add(pictureBoxChosenPhoto);
            pnlSearchPhoto.Controls.Add(dataGridRecords);
            pnlSearchPhoto.Controls.Add(lblFoundPhoto);
            pnlSearchPhoto.Controls.Add(lblFound);
            pnlSearchPhoto.Controls.Add(txtFullName);
            pnlSearchPhoto.Controls.Add(lblFullName);
            pnlSearchPhoto.Location = new Point(9, 60);
            pnlSearchPhoto.Margin = new Padding(4, 2, 4, 2);
            pnlSearchPhoto.Name = "pnlSearchPhoto";
            pnlSearchPhoto.Size = new Size(2164, 802);
            pnlSearchPhoto.TabIndex = 0;
            // 
            // lblGoRecord
            // 
            lblGoRecord.AutoSize = true;
            lblGoRecord.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            lblGoRecord.ForeColor = SystemColors.ControlText;
            lblGoRecord.Location = new Point(1814, 450);
            lblGoRecord.Margin = new Padding(6, 0, 6, 0);
            lblGoRecord.Name = "lblGoRecord";
            lblGoRecord.Size = new Size(315, 44);
            lblGoRecord.TabIndex = 15;
            lblGoRecord.Text = "Kayıt Dosyasına Git";
            // 
            // btnGoRecord
            // 
            btnGoRecord.BackgroundImage = Extensions.Resources.btnOpenFolder;
            btnGoRecord.BackgroundImageLayout = ImageLayout.Stretch;
            btnGoRecord.FlatAppearance.BorderSize = 0;
            btnGoRecord.FlatStyle = FlatStyle.Flat;
            btnGoRecord.Location = new Point(1879, 273);
            btnGoRecord.Margin = new Padding(6);
            btnGoRecord.Name = "btnGoRecord";
            btnGoRecord.Size = new Size(149, 171);
            btnGoRecord.TabIndex = 16;
            btnGoRecord.UseVisualStyleBackColor = true;
            // 
            // comboBoxDriversForRecord
            // 
            comboBoxDriversForRecord.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxDriversForRecord.FormattingEnabled = true;
            comboBoxDriversForRecord.Location = new Point(1514, 420);
            comboBoxDriversForRecord.Margin = new Padding(4, 2, 4, 2);
            comboBoxDriversForRecord.Name = "comboBoxDriversForRecord";
            comboBoxDriversForRecord.Size = new Size(242, 59);
            comboBoxDriversForRecord.TabIndex = 5;
            // 
            // lblChooseDriver
            // 
            lblChooseDriver.AutoSize = true;
            lblChooseDriver.BackColor = Color.Transparent;
            lblChooseDriver.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChooseDriver.ForeColor = Color.Black;
            lblChooseDriver.Location = new Point(1514, 358);
            lblChooseDriver.Margin = new Padding(6, 0, 6, 0);
            lblChooseDriver.Name = "lblChooseDriver";
            lblChooseDriver.Size = new Size(252, 57);
            lblChooseDriver.TabIndex = 6;
            lblChooseDriver.Text = "Sürücü Seç:";
            // 
            // pictureBoxChosenPhoto
            // 
            pictureBoxChosenPhoto.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxChosenPhoto.Location = new Point(897, 149);
            pictureBoxChosenPhoto.Margin = new Padding(6);
            pictureBoxChosenPhoto.Name = "pictureBoxChosenPhoto";
            pictureBoxChosenPhoto.Size = new Size(503, 591);
            pictureBoxChosenPhoto.TabIndex = 4;
            pictureBoxChosenPhoto.TabStop = false;
            // 
            // dataGridRecords
            // 
            dataGridRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridRecords.Location = new Point(6, 149);
            dataGridRecords.Margin = new Padding(6);
            dataGridRecords.Name = "dataGridRecords";
            dataGridRecords.RowHeadersWidth = 82;
            dataGridRecords.Size = new Size(773, 593);
            dataGridRecords.TabIndex = 3;
            // 
            // lblFoundPhoto
            // 
            lblFoundPhoto.AutoSize = true;
            lblFoundPhoto.BackColor = Color.Gold;
            lblFoundPhoto.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFoundPhoto.ForeColor = Color.Black;
            lblFoundPhoto.Location = new Point(1007, 98);
            lblFoundPhoto.Margin = new Padding(6, 0, 6, 0);
            lblFoundPhoto.Name = "lblFoundPhoto";
            lblFoundPhoto.Size = new Size(326, 45);
            lblFoundPhoto.TabIndex = 2;
            lblFoundPhoto.Text = "Temsili Kayıt Fotoğrafı";
            // 
            // lblFound
            // 
            lblFound.AutoSize = true;
            lblFound.BackColor = Color.Gold;
            lblFound.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFound.ForeColor = Color.Black;
            lblFound.Location = new Point(230, 98);
            lblFound.Margin = new Padding(6, 0, 6, 0);
            lblFound.Name = "lblFound";
            lblFound.Size = new Size(256, 45);
            lblFound.TabIndex = 2;
            lblFound.Text = "Bulunan Kayıtlar:";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(806, 8);
            txtFullName.Margin = new Padding(6);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(697, 58);
            txtFullName.TabIndex = 1;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = Color.Black;
            lblFullName.Location = new Point(15, 11);
            lblFullName.Margin = new Padding(6, 0, 6, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(782, 51);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Aradığınız kaydın ismini giriniz (ad soyad):";
            // 
            // lblExplanation
            // 
            lblExplanation.BackColor = Color.Silver;
            lblExplanation.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblExplanation.ForeColor = SystemColors.WindowFrame;
            lblExplanation.Location = new Point(392, 15);
            lblExplanation.Margin = new Padding(4, 0, 4, 0);
            lblExplanation.Name = "lblExplanation";
            lblExplanation.Size = new Size(2102, 301);
            lblExplanation.TabIndex = 20;
            // 
            // lblMainArchiveCaption
            // 
            lblMainArchiveCaption.AutoSize = true;
            lblMainArchiveCaption.Font = new Font("Comic Sans MS", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMainArchiveCaption.ForeColor = Color.Black;
            lblMainArchiveCaption.Location = new Point(566, 45);
            lblMainArchiveCaption.Margin = new Padding(4, 0, 4, 0);
            lblMainArchiveCaption.Name = "lblMainArchiveCaption";
            lblMainArchiveCaption.Size = new Size(1278, 178);
            lblMainArchiveCaption.TabIndex = 0;
            lblMainArchiveCaption.Text = "ARŞİV İŞLEMLERİ";
            // 
            // lblEmpty
            // 
            lblEmpty.Font = new Font("Comic Sans MS", 14.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmpty.Location = new Point(15, 68);
            lblEmpty.Margin = new Padding(4, 0, 4, 0);
            lblEmpty.Name = "lblEmpty";
            lblEmpty.Size = new Size(351, 175);
            lblEmpty.TabIndex = 1;
            // 
            // btnAddSpareToArchive
            // 
            btnAddSpareToArchive.BackColor = SystemColors.ControlDarkDark;
            btnAddSpareToArchive.BackgroundImageLayout = ImageLayout.None;
            btnAddSpareToArchive.FlatAppearance.BorderColor = Color.White;
            btnAddSpareToArchive.FlatAppearance.BorderSize = 5;
            btnAddSpareToArchive.FlatAppearance.MouseDownBackColor = Color.Gold;
            btnAddSpareToArchive.FlatAppearance.MouseOverBackColor = Color.Black;
            btnAddSpareToArchive.FlatStyle = FlatStyle.Flat;
            btnAddSpareToArchive.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnAddSpareToArchive.ForeColor = Color.White;
            btnAddSpareToArchive.Location = new Point(15, 1022);
            btnAddSpareToArchive.Margin = new Padding(15);
            btnAddSpareToArchive.Name = "btnAddSpareToArchive";
            btnAddSpareToArchive.Size = new Size(275, 201);
            btnAddSpareToArchive.TabIndex = 19;
            btnAddSpareToArchive.Text = "Yedeği Arşive Yükle";
            btnAddSpareToArchive.UseVisualStyleBackColor = false;
            btnAddSpareToArchive.Click += btnAddSpareToArchive_Click;
            // 
            // btnMakeSpare
            // 
            btnMakeSpare.BackColor = SystemColors.ControlDarkDark;
            btnMakeSpare.BackgroundImageLayout = ImageLayout.None;
            btnMakeSpare.FlatAppearance.BorderColor = Color.White;
            btnMakeSpare.FlatAppearance.BorderSize = 5;
            btnMakeSpare.FlatAppearance.MouseDownBackColor = Color.Gold;
            btnMakeSpare.FlatAppearance.MouseOverBackColor = Color.Black;
            btnMakeSpare.FlatStyle = FlatStyle.Flat;
            btnMakeSpare.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnMakeSpare.ForeColor = Color.White;
            btnMakeSpare.Location = new Point(15, 791);
            btnMakeSpare.Margin = new Padding(15);
            btnMakeSpare.Name = "btnMakeSpare";
            btnMakeSpare.Size = new Size(275, 201);
            btnMakeSpare.TabIndex = 19;
            btnMakeSpare.Text = "Arşivi Yedekle";
            btnMakeSpare.UseVisualStyleBackColor = false;
            btnMakeSpare.Click += btnMakeSpare_Click;
            // 
            // btnAddFoldersToArchive
            // 
            btnAddFoldersToArchive.BackColor = SystemColors.ControlDarkDark;
            btnAddFoldersToArchive.BackgroundImageLayout = ImageLayout.None;
            btnAddFoldersToArchive.FlatAppearance.BorderColor = Color.White;
            btnAddFoldersToArchive.FlatAppearance.BorderSize = 5;
            btnAddFoldersToArchive.FlatAppearance.MouseDownBackColor = Color.Gold;
            btnAddFoldersToArchive.FlatAppearance.MouseOverBackColor = Color.Black;
            btnAddFoldersToArchive.FlatStyle = FlatStyle.Flat;
            btnAddFoldersToArchive.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnAddFoldersToArchive.ForeColor = Color.White;
            btnAddFoldersToArchive.Location = new Point(15, 563);
            btnAddFoldersToArchive.Margin = new Padding(15);
            btnAddFoldersToArchive.Name = "btnAddFoldersToArchive";
            btnAddFoldersToArchive.Size = new Size(275, 201);
            btnAddFoldersToArchive.TabIndex = 19;
            btnAddFoldersToArchive.Text = "Hazırlanan Dosyaları Arşive Ekle";
            btnAddFoldersToArchive.UseVisualStyleBackColor = false;
            btnAddFoldersToArchive.Click += btnAddFoldersToArchive_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Extensions.Resources.ArkaFon;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2884, 1626);
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
            pnlAddSpareToArchive.ResumeLayout(false);
            pnlAddSpareToArchive.PerformLayout();
            pnlMakeSpare.ResumeLayout(false);
            pnlMakeSpare.PerformLayout();
            pnlAddFoldersToArchive.ResumeLayout(false);
            pnlAddFoldersToArchive.PerformLayout();
            pnlSearchPhoto.ResumeLayout(false);
            pnlSearchPhoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChosenPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridRecords).EndInit();
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
        private Label lblFullName;
        private Label lblFound;
        private TextBox txtFullName;
        private DataGridView dataGridRecords;
        private Label lblFoundPhoto;
        private PictureBox pictureBoxChosenPhoto;
        private ComboBox comboBoxDriversForRecord;
        private Label lblChooseDriver;
        private Label lblGoRecord;
        private Button btnGoRecord;
        private Label label10;
        private Label label20;
        private Label label11;
        private TextBox txtChosenUpperFolder;
        private Label label23;
        private Button btnChooseUpperFolder;
        private Label label27;
        private Label label28;
        private Button btnAddFolderToArchive;
        private Label label30;
        private Label label29;
        private TextBox txtLocationForArchive;
        private Label label31;
        private Button btnLocationForArchive;
        private Label label33;
        private Label label32;
        private Button btnDBtoFolder;
        private Label label34;
        private Label label35;
        private Button button2;
        private TextBox txtLocationOfSpareFolder;
        private Label label36;
        private Button button3;
        private Label label37;
        private Label label38;
    }
}
