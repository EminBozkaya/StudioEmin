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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridRecords = new DataGridView();
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
            pnlAddFoldersToArchive = new Panel();
            pictureBoxAddFolderToArchive = new PictureBox();
            lblAddFolderToArchive = new Label();
            btnAddFolderToArchive = new Button();
            label27 = new Label();
            txtChosenUpperFolder = new TextBox();
            label23 = new Label();
            btnChooseUpperFolder = new Button();
            label20 = new Label();
            label11 = new Label();
            label10 = new Label();
            pnlAddSpareToArchive = new Panel();
            label34 = new Label();
            label35 = new Label();
            button2 = new Button();
            txtLocationOfSpareFolder = new TextBox();
            label36 = new Label();
            btnChooseSpareFolder = new Button();
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
            pnlSearchPhoto = new Panel();
            panel1 = new Panel();
            lblTotalRecord = new Label();
            label40 = new Label();
            lblSearchArchive = new Label();
            pictureBoxLoadingArchive = new PictureBox();
            btnSearchArchive = new Button();
            listBoxArchive = new ListBox();
            label39 = new Label();
            txtDataUpperFileName = new TextBox();
            lblGoRecord = new Label();
            btnGoRecord = new Button();
            comboBoxDriversForRecord = new ComboBox();
            lblChooseDriver = new Label();
            pictureBoxChosenPhoto = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)dataGridRecords).BeginInit();
            pnlReceipt.SuspendLayout();
            pnlReceiptInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQty).BeginInit();
            pnlFindFolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoading).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            pnlBorder.SuspendLayout();
            flowLayoutPanelArchive.SuspendLayout();
            pnlArchiveContents.SuspendLayout();
            pnlAddFoldersToArchive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAddFolderToArchive).BeginInit();
            pnlAddSpareToArchive.SuspendLayout();
            pnlMakeSpare.SuspendLayout();
            pnlSearchPhoto.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoadingArchive).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChosenPhoto).BeginInit();
            SuspendLayout();
            // 
            // dataGridRecords
            // 
            dataGridRecords.AllowUserToAddRows = false;
            dataGridRecords.AllowUserToDeleteRows = false;
            dataGridRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridRecords.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridRecords.Location = new Point(3, 70);
            dataGridRecords.Name = "dataGridRecords";
            dataGridRecords.ReadOnly = true;
            dataGridRecords.RowHeadersVisible = false;
            dataGridRecords.RowHeadersWidth = 82;
            dataGridRecords.Size = new Size(347, 207);
            dataGridRecords.TabIndex = 3;
            dataGridRecords.SelectionChanged += dataGridRecords_SelectionChanged;
            // 
            // btnFindFolder
            // 
            btnFindFolder.BackColor = Color.Transparent;
            btnFindFolder.BackgroundImage = Extensions.Resources.btnFindFolder;
            btnFindFolder.BackgroundImageLayout = ImageLayout.Stretch;
            btnFindFolder.FlatAppearance.BorderSize = 0;
            btnFindFolder.FlatStyle = FlatStyle.Flat;
            btnFindFolder.Location = new Point(35, 160);
            btnFindFolder.Name = "btnFindFolder";
            btnFindFolder.Size = new Size(100, 100);
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
            btnCreateReceipt.Location = new Point(35, 298);
            btnCreateReceipt.Name = "btnCreateReceipt";
            btnCreateReceipt.Size = new Size(100, 100);
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
            pnlReceipt.Location = new Point(69, 14);
            pnlReceipt.Name = "pnlReceipt";
            pnlReceipt.Size = new Size(1282, 635);
            pnlReceipt.TabIndex = 1;
            // 
            // textBoxFileLocation
            // 
            textBoxFileLocation.BackColor = SystemColors.ScrollBar;
            textBoxFileLocation.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFileLocation.Location = new Point(487, 192);
            textBoxFileLocation.Name = "textBoxFileLocation";
            textBoxFileLocation.ReadOnly = true;
            textBoxFileLocation.Size = new Size(282, 27);
            textBoxFileLocation.TabIndex = 14;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(589, 591);
            label12.Name = "label12";
            label12.Size = new Size(58, 22);
            label12.TabIndex = 2;
            label12.Text = "Yazdır";
            // 
            // lblFileLocation
            // 
            lblFileLocation.AutoSize = true;
            lblFileLocation.FlatStyle = FlatStyle.Flat;
            lblFileLocation.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFileLocation.ForeColor = SystemColors.MenuHighlight;
            lblFileLocation.Location = new Point(796, 237);
            lblFileLocation.Name = "lblFileLocation";
            lblFileLocation.Size = new Size(0, 18);
            lblFileLocation.TabIndex = 2;
            // 
            // lblReceiptName
            // 
            lblReceiptName.AutoSize = true;
            lblReceiptName.FlatStyle = FlatStyle.Flat;
            lblReceiptName.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReceiptName.ForeColor = SystemColors.MenuHighlight;
            lblReceiptName.Location = new Point(796, 295);
            lblReceiptName.Name = "lblReceiptName";
            lblReceiptName.Size = new Size(0, 18);
            lblReceiptName.TabIndex = 2;
            // 
            // lblSave
            // 
            lblSave.AutoSize = true;
            lblSave.FlatStyle = FlatStyle.Flat;
            lblSave.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSave.Location = new Point(589, 496);
            lblSave.Name = "lblSave";
            lblSave.Size = new Size(63, 22);
            lblSave.TabIndex = 2;
            lblSave.Text = "Kaydet";
            // 
            // lblSaveAndPrint
            // 
            lblSaveAndPrint.AutoSize = true;
            lblSaveAndPrint.FlatStyle = FlatStyle.Flat;
            lblSaveAndPrint.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaveAndPrint.Location = new Point(544, 380);
            lblSaveAndPrint.Name = "lblSaveAndPrint";
            lblSaveAndPrint.Size = new Size(136, 22);
            lblSaveAndPrint.TabIndex = 2;
            lblSaveAndPrint.Text = "Kaydet ve Yazdır";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(787, 589);
            label15.Name = "label15";
            label15.Size = new Size(123, 22);
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
            pnlReceiptInputs.Location = new Point(6, 17);
            pnlReceiptInputs.Name = "pnlReceiptInputs";
            pnlReceiptInputs.Size = new Size(474, 594);
            pnlReceiptInputs.TabIndex = 0;
            // 
            // numQty
            // 
            numQty.Font = new Font("Arial", 14.25F);
            numQty.Location = new Point(306, 145);
            numQty.Margin = new Padding(2, 1, 2, 1);
            numQty.Name = "numQty";
            numQty.Size = new Size(75, 29);
            numQty.TabIndex = 4;
            numQty.ValueChanged += txtName_TextChanged;
            // 
            // txtDeliveryDate
            // 
            txtDeliveryDate.Font = new Font("Arial", 14.25F);
            txtDeliveryDate.Location = new Point(269, 281);
            txtDeliveryDate.Name = "txtDeliveryDate";
            txtDeliveryDate.Size = new Size(116, 29);
            txtDeliveryDate.TabIndex = 8;
            txtDeliveryDate.TextChanged += txtName_TextChanged;
            // 
            // txtRemainingAmount
            // 
            txtRemainingAmount.Font = new Font("Arial", 14.25F);
            txtRemainingAmount.Location = new Point(295, 225);
            txtRemainingAmount.Name = "txtRemainingAmount";
            txtRemainingAmount.ReadOnly = true;
            txtRemainingAmount.Size = new Size(95, 29);
            txtRemainingAmount.TabIndex = 7;
            txtRemainingAmount.TextChanged += txtName_TextChanged;
            // 
            // txtReceivedAmount
            // 
            txtReceivedAmount.Font = new Font("Arial", 14.25F);
            txtReceivedAmount.Location = new Point(192, 225);
            txtReceivedAmount.Name = "txtReceivedAmount";
            txtReceivedAmount.Size = new Size(95, 29);
            txtReceivedAmount.TabIndex = 6;
            txtReceivedAmount.TextChanged += TextBoxesAmount_TextChanged;
            txtReceivedAmount.LostFocus += TextBox_LostFocus;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Font = new Font("Arial", 14.25F);
            txtTotalAmount.Location = new Point(91, 225);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(95, 29);
            txtTotalAmount.TabIndex = 5;
            txtTotalAmount.TextChanged += TextBoxesAmount_TextChanged;
            txtTotalAmount.LostFocus += TextBox_LostFocus;
            // 
            // txtDimensions
            // 
            txtDimensions.Font = new Font("Arial", 14.25F);
            txtDimensions.Location = new Point(139, 144);
            txtDimensions.Name = "txtDimensions";
            txtDimensions.Size = new Size(108, 29);
            txtDimensions.TabIndex = 3;
            txtDimensions.TextChanged += txtName_TextChanged;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.Font = new Font("Arial", 14.25F);
            txtName.Location = new Point(91, 95);
            txtName.Name = "txtName";
            txtName.Size = new Size(294, 29);
            txtName.TabIndex = 2;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtBoxNotes
            // 
            txtBoxNotes.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxNotes.Location = new Point(91, 345);
            txtBoxNotes.Name = "txtBoxNotes";
            txtBoxNotes.Size = new Size(294, 219);
            txtBoxNotes.TabIndex = 9;
            txtBoxNotes.Text = "";
            txtBoxNotes.TextChanged += txtName_TextChanged;
            // 
            // label5
            // 
            label5.Location = new Point(247, 147);
            label5.Name = "label5";
            label5.Size = new Size(56, 23);
            label5.TabIndex = 0;
            label5.Text = "Adet:";
            // 
            // label3
            // 
            label3.Location = new Point(306, 198);
            label3.Name = "label3";
            label3.Size = new Size(77, 23);
            label3.TabIndex = 0;
            label3.Text = "Kalan:";
            // 
            // label6
            // 
            label6.Location = new Point(101, 198);
            label6.Name = "label6";
            label6.Size = new Size(64, 23);
            label6.TabIndex = 0;
            label6.Text = "Tutar:";
            // 
            // label4
            // 
            label4.Location = new Point(91, 147);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 0;
            label4.Text = "Ebat:";
            // 
            // label7
            // 
            label7.Location = new Point(150, 284);
            label7.Name = "label7";
            label7.Size = new Size(126, 23);
            label7.TabIndex = 0;
            label7.Text = "Teslim Tarihi:";
            // 
            // label8
            // 
            label8.Location = new Point(91, 319);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 0;
            label8.Text = "Not:";
            // 
            // label2
            // 
            label2.Location = new Point(196, 199);
            label2.Name = "label2";
            label2.Size = new Size(76, 23);
            label2.TabIndex = 0;
            label2.Text = "Alınan:";
            // 
            // lblName
            // 
            lblName.Location = new Point(91, 70);
            lblName.Name = "lblName";
            lblName.Size = new Size(128, 23);
            lblName.TabIndex = 0;
            lblName.Text = "Ad - Soyad:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            label26.ForeColor = SystemColors.ControlText;
            label26.Location = new Point(905, 434);
            label26.Name = "label26";
            label26.Size = new Size(108, 22);
            label26.TabIndex = 2;
            label26.Text = "Makbuza Git";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            label14.ForeColor = SystemColors.ControlText;
            label14.Location = new Point(787, 434);
            label14.Name = "label14";
            label14.Size = new Size(94, 22);
            label14.TabIndex = 2;
            label14.Text = "Klasöre Git";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label25.Location = new Point(796, 263);
            label25.Name = "label25";
            label25.Size = new Size(140, 28);
            label25.TabIndex = 2;
            label25.Text = "Makbuz Adı:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label24.Location = new Point(796, 202);
            label24.Name = "label24";
            label24.Size = new Size(135, 28);
            label24.TabIndex = 2;
            label24.Text = "Klasör           :";
            // 
            // lblReceiptCaption
            // 
            lblReceiptCaption.AutoSize = true;
            lblReceiptCaption.Font = new Font("Palatino Linotype", 17.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblReceiptCaption.Location = new Point(796, 171);
            lblReceiptCaption.Name = "lblReceiptCaption";
            lblReceiptCaption.Size = new Size(243, 31);
            lblReceiptCaption.TabIndex = 2;
            lblReceiptCaption.Text = "Oluşturulan Makbuz:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(536, 162);
            label13.Name = "label13";
            label13.Size = new Size(154, 26);
            label13.TabIndex = 2;
            label13.Text = "Seçilen Konum:";
            // 
            // btnTrash
            // 
            btnTrash.BackgroundImage = Extensions.Resources.btnTrash;
            btnTrash.BackgroundImageLayout = ImageLayout.Stretch;
            btnTrash.FlatAppearance.BorderSize = 0;
            btnTrash.FlatStyle = FlatStyle.Flat;
            btnTrash.Location = new Point(799, 507);
            btnTrash.Name = "btnTrash";
            btnTrash.Size = new Size(80, 80);
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
            btnPrint.Location = new Point(579, 527);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(80, 73);
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
            btnChooseFileLocation.Location = new Point(559, 85);
            btnChooseFileLocation.Name = "btnChooseFileLocation";
            btnChooseFileLocation.Size = new Size(108, 81);
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
            btnSaveAndPrint.Location = new Point(520, 249);
            btnSaveAndPrint.Name = "btnSaveAndPrint";
            btnSaveAndPrint.Size = new Size(195, 147);
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
            btnSave.Location = new Point(579, 434);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 64);
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
            btnGoReceipt.Location = new Point(914, 351);
            btnGoReceipt.Name = "btnGoReceipt";
            btnGoReceipt.Size = new Size(80, 80);
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
            btnGoTheFolder.Location = new Point(796, 351);
            btnGoTheFolder.Name = "btnGoTheFolder";
            btnGoTheFolder.Size = new Size(80, 80);
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
            pnlFindFolder.Location = new Point(208, 4);
            pnlFindFolder.Margin = new Padding(2, 1, 2, 1);
            pnlFindFolder.Name = "pnlFindFolder";
            pnlFindFolder.Size = new Size(992, 580);
            pnlFindFolder.TabIndex = 16;
            // 
            // pictureBoxLoading
            // 
            pictureBoxLoading.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxLoading.Image = Extensions.Resources.loading;
            pictureBoxLoading.InitialImage = Extensions.Resources.loading;
            pictureBoxLoading.Location = new Point(352, 215);
            pictureBoxLoading.Margin = new Padding(2, 1, 2, 1);
            pictureBoxLoading.Name = "pictureBoxLoading";
            pictureBoxLoading.Size = new Size(135, 117);
            pictureBoxLoading.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLoading.TabIndex = 6;
            pictureBoxLoading.TabStop = false;
            // 
            // listBoxFiles
            // 
            listBoxFiles.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxFiles.FormattingEnabled = true;
            listBoxFiles.HorizontalScrollbar = true;
            listBoxFiles.ItemHeight = 21;
            listBoxFiles.Location = new Point(193, 436);
            listBoxFiles.Margin = new Padding(2, 1, 2, 1);
            listBoxFiles.Name = "listBoxFiles";
            listBoxFiles.Size = new Size(507, 67);
            listBoxFiles.TabIndex = 5;
            listBoxFiles.DoubleClick += ListBoxFiles_DoubleClick;
            // 
            // txtFileNameInput
            // 
            txtFileNameInput.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFileNameInput.Location = new Point(498, 140);
            txtFileNameInput.Margin = new Padding(2, 1, 2, 1);
            txtFileNameInput.Name = "txtFileNameInput";
            txtFileNameInput.Size = new Size(267, 33);
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
            btnSearchFile.Location = new Point(352, 218);
            btnSearchFile.Name = "btnSearchFile";
            btnSearchFile.Size = new Size(120, 100);
            btnSearchFile.TabIndex = 0;
            btnSearchFile.UseVisualStyleBackColor = false;
            btnSearchFile.Click += btnSearchFile_Click;
            // 
            // cmbBoxDriver
            // 
            cmbBoxDriver.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBoxDriver.FormattingEnabled = true;
            cmbBoxDriver.Location = new Point(181, 139);
            cmbBoxDriver.Margin = new Padding(2, 1, 2, 1);
            cmbBoxDriver.Name = "cmbBoxDriver";
            cmbBoxDriver.Size = new Size(132, 33);
            cmbBoxDriver.TabIndex = 0;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Palatino Linotype", 19.875F, FontStyle.Bold);
            label18.ForeColor = SystemColors.ButtonFace;
            label18.Location = new Point(402, 132);
            label18.Name = "label18";
            label18.Size = new Size(31, 37);
            label18.TabIndex = 2;
            label18.Text = ">";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold);
            label17.ForeColor = SystemColors.ActiveCaptionText;
            label17.Location = new Point(174, 105);
            label17.Name = "label17";
            label17.Size = new Size(144, 32);
            label17.TabIndex = 2;
            label17.Text = "Sürücü Seç:";
            // 
            // lblSearchFile
            // 
            lblSearchFile.AutoSize = true;
            lblSearchFile.BackColor = Color.Transparent;
            lblSearchFile.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchFile.ForeColor = SystemColors.ActiveCaptionText;
            lblSearchFile.Location = new Point(392, 333);
            lblSearchFile.Name = "lblSearchFile";
            lblSearchFile.Size = new Size(54, 32);
            lblSearchFile.TabIndex = 2;
            lblSearchFile.Text = "Ara";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = SystemColors.ActiveCaptionText;
            label19.Location = new Point(317, 403);
            label19.Name = "label19";
            label19.Size = new Size(219, 32);
            label19.TabIndex = 2;
            label19.Text = "Bulunan Klasörler:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold);
            label16.ForeColor = SystemColors.ActiveCaptionText;
            label16.Location = new Point(556, 105);
            label16.Name = "label16";
            label16.Size = new Size(177, 32);
            label16.TabIndex = 2;
            label16.Text = "Klasör Adı Gir:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(35, 398);
            label9.Name = "label9";
            label9.Size = new Size(103, 22);
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
            label21.Location = new Point(35, 265);
            label21.Name = "label21";
            label21.Size = new Size(88, 22);
            label21.TabIndex = 2;
            label21.Text = "Klasör Ara";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = SystemColors.ButtonFace;
            label22.Location = new Point(35, 131);
            label22.Name = "label22";
            label22.Size = new Size(104, 22);
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
            btnMyComputer.Location = new Point(35, 28);
            btnMyComputer.Name = "btnMyComputer";
            btnMyComputer.Size = new Size(100, 100);
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
            button1.Location = new Point(35, 440);
            button1.Name = "button1";
            button1.Size = new Size(100, 100);
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
            label1.Location = new Point(59, 543);
            label1.Name = "label1";
            label1.Size = new Size(50, 22);
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
            btnSearchPhoto.Location = new Point(8, 156);
            btnSearchPhoto.Margin = new Padding(8, 7, 8, 7);
            btnSearchPhoto.Name = "btnSearchPhoto";
            btnSearchPhoto.Size = new Size(148, 94);
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
            pnlBorder.Location = new Point(214, 71);
            pnlBorder.Name = "pnlBorder";
            pnlBorder.Size = new Size(1365, 657);
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
            flowLayoutPanelArchive.Location = new Point(5, 24);
            flowLayoutPanelArchive.Name = "flowLayoutPanelArchive";
            flowLayoutPanelArchive.Size = new Size(1350, 583);
            flowLayoutPanelArchive.TabIndex = 17;
            // 
            // pnlArchiveContents
            // 
            pnlArchiveContents.BorderStyle = BorderStyle.FixedSingle;
            pnlArchiveContents.Controls.Add(pnlAddFoldersToArchive);
            pnlArchiveContents.Controls.Add(pnlAddSpareToArchive);
            pnlArchiveContents.Controls.Add(pnlMakeSpare);
            pnlArchiveContents.Controls.Add(pnlSearchPhoto);
            pnlArchiveContents.Location = new Point(165, 150);
            pnlArchiveContents.Margin = new Padding(2, 1, 2, 1);
            pnlArchiveContents.Name = "pnlArchiveContents";
            pnlArchiveContents.Size = new Size(1178, 429);
            pnlArchiveContents.TabIndex = 21;
            // 
            // pnlAddFoldersToArchive
            // 
            pnlAddFoldersToArchive.Controls.Add(pictureBoxAddFolderToArchive);
            pnlAddFoldersToArchive.Controls.Add(lblAddFolderToArchive);
            pnlAddFoldersToArchive.Controls.Add(btnAddFolderToArchive);
            pnlAddFoldersToArchive.Controls.Add(label27);
            pnlAddFoldersToArchive.Controls.Add(txtChosenUpperFolder);
            pnlAddFoldersToArchive.Controls.Add(label23);
            pnlAddFoldersToArchive.Controls.Add(btnChooseUpperFolder);
            pnlAddFoldersToArchive.Controls.Add(label20);
            pnlAddFoldersToArchive.Controls.Add(label11);
            pnlAddFoldersToArchive.Controls.Add(label10);
            pnlAddFoldersToArchive.Location = new Point(13, 17);
            pnlAddFoldersToArchive.Margin = new Padding(2, 1, 2, 1);
            pnlAddFoldersToArchive.Name = "pnlAddFoldersToArchive";
            pnlAddFoldersToArchive.Size = new Size(1150, 394);
            pnlAddFoldersToArchive.TabIndex = 1;
            // 
            // pictureBoxAddFolderToArchive
            // 
            pictureBoxAddFolderToArchive.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxAddFolderToArchive.Image = Extensions.Resources.loading;
            pictureBoxAddFolderToArchive.InitialImage = Extensions.Resources.loading;
            pictureBoxAddFolderToArchive.Location = new Point(823, 112);
            pictureBoxAddFolderToArchive.Margin = new Padding(2, 1, 2, 1);
            pictureBoxAddFolderToArchive.Name = "pictureBoxAddFolderToArchive";
            pictureBoxAddFolderToArchive.Size = new Size(135, 117);
            pictureBoxAddFolderToArchive.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAddFolderToArchive.TabIndex = 21;
            pictureBoxAddFolderToArchive.TabStop = false;
            // 
            // lblAddFolderToArchive
            // 
            lblAddFolderToArchive.AutoSize = true;
            lblAddFolderToArchive.BackColor = Color.DarkOrange;
            lblAddFolderToArchive.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddFolderToArchive.ForeColor = Color.White;
            lblAddFolderToArchive.Location = new Point(831, 260);
            lblAddFolderToArchive.Name = "lblAddFolderToArchive";
            lblAddFolderToArchive.Size = new Size(124, 28);
            lblAddFolderToArchive.TabIndex = 20;
            lblAddFolderToArchive.Text = "Arşive Ekle";
            // 
            // btnAddFolderToArchive
            // 
            btnAddFolderToArchive.BackColor = Color.Transparent;
            btnAddFolderToArchive.BackgroundImage = Extensions.Resources.btnDB;
            btnAddFolderToArchive.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddFolderToArchive.FlatAppearance.BorderSize = 0;
            btnAddFolderToArchive.FlatStyle = FlatStyle.Flat;
            btnAddFolderToArchive.Location = new Point(801, 81);
            btnAddFolderToArchive.Name = "btnAddFolderToArchive";
            btnAddFolderToArchive.Size = new Size(180, 179);
            btnAddFolderToArchive.TabIndex = 19;
            btnAddFolderToArchive.UseVisualStyleBackColor = false;
            btnAddFolderToArchive.Click += btnAddFolderToArchive_Click;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label27.ForeColor = Color.GhostWhite;
            label27.Location = new Point(523, 121);
            label27.Name = "label27";
            label27.Size = new Size(151, 128);
            label27.TabIndex = 18;
            label27.Text = "➪";
            // 
            // txtChosenUpperFolder
            // 
            txtChosenUpperFolder.BackColor = SystemColors.ScrollBar;
            txtChosenUpperFolder.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtChosenUpperFolder.ForeColor = SystemColors.MenuHighlight;
            txtChosenUpperFolder.Location = new Point(47, 318);
            txtChosenUpperFolder.Name = "txtChosenUpperFolder";
            txtChosenUpperFolder.ReadOnly = true;
            txtChosenUpperFolder.Size = new Size(467, 33);
            txtChosenUpperFolder.TabIndex = 17;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.Location = new Point(84, 286);
            label23.Name = "label23";
            label23.Size = new Size(360, 26);
            label23.TabIndex = 15;
            label23.Text = "Arşive Eklemek İçin Seçilen Üst Klasör";
            // 
            // btnChooseUpperFolder
            // 
            btnChooseUpperFolder.BackgroundImage = Extensions.Resources.btnChooseUpperFolder;
            btnChooseUpperFolder.BackgroundImageLayout = ImageLayout.Stretch;
            btnChooseUpperFolder.FlatAppearance.BorderSize = 0;
            btnChooseUpperFolder.FlatStyle = FlatStyle.Flat;
            btnChooseUpperFolder.Location = new Point(187, 151);
            btnChooseUpperFolder.Name = "btnChooseUpperFolder";
            btnChooseUpperFolder.Size = new Size(156, 130);
            btnChooseUpperFolder.TabIndex = 16;
            btnChooseUpperFolder.UseVisualStyleBackColor = true;
            btnChooseUpperFolder.Click += btnChooseUpperFolder_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.Black;
            label20.Location = new Point(101, 76);
            label20.Name = "label20";
            label20.Size = new Size(386, 25);
            label20.TabIndex = 3;
            label20.Text = "müşterilerin kayıt dosyalarını bulunduran,";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(103, 112);
            label11.Name = "label11";
            label11.Size = new Size(265, 25);
            label11.TabIndex = 2;
            label11.Text = "ÜST KLASÖRÜNÜZÜ Seçiniz:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(103, 41);
            label10.Name = "label10";
            label10.Size = new Size(212, 25);
            label10.TabIndex = 1;
            label10.Text = "Hazırlamış olduğunuz,";
            // 
            // pnlAddSpareToArchive
            // 
            pnlAddSpareToArchive.Controls.Add(label34);
            pnlAddSpareToArchive.Controls.Add(label35);
            pnlAddSpareToArchive.Controls.Add(button2);
            pnlAddSpareToArchive.Controls.Add(txtLocationOfSpareFolder);
            pnlAddSpareToArchive.Controls.Add(label36);
            pnlAddSpareToArchive.Controls.Add(btnChooseSpareFolder);
            pnlAddSpareToArchive.Controls.Add(label37);
            pnlAddSpareToArchive.Controls.Add(label38);
            pnlAddSpareToArchive.Location = new Point(37, 1);
            pnlAddSpareToArchive.Margin = new Padding(2, 1, 2, 1);
            pnlAddSpareToArchive.Name = "pnlAddSpareToArchive";
            pnlAddSpareToArchive.Size = new Size(1114, 421);
            pnlAddSpareToArchive.TabIndex = 0;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label34.ForeColor = Color.GhostWhite;
            label34.Location = new Point(493, 142);
            label34.Name = "label34";
            label34.Size = new Size(151, 128);
            label34.TabIndex = 28;
            label34.Text = "➪";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.BackColor = Color.Gray;
            label35.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label35.ForeColor = SystemColors.ButtonHighlight;
            label35.Location = new Point(733, 275);
            label35.Name = "label35";
            label35.Size = new Size(251, 26);
            label35.TabIndex = 27;
            label35.Text = "Yedek Dosyayı Arşive Ekle";
            // 
            // button2
            // 
            button2.BackgroundImage = Extensions.Resources.btnFolderToDB;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(717, 120);
            button2.Name = "button2";
            button2.Size = new Size(297, 161);
            button2.TabIndex = 26;
            button2.UseVisualStyleBackColor = true;
            // 
            // txtLocationOfSpareFolder
            // 
            txtLocationOfSpareFolder.BackColor = SystemColors.ScrollBar;
            txtLocationOfSpareFolder.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLocationOfSpareFolder.Location = new Point(79, 309);
            txtLocationOfSpareFolder.Name = "txtLocationOfSpareFolder";
            txtLocationOfSpareFolder.ReadOnly = true;
            txtLocationOfSpareFolder.Size = new Size(415, 32);
            txtLocationOfSpareFolder.TabIndex = 25;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label36.Location = new Point(172, 280);
            label36.Name = "label36";
            label36.Size = new Size(215, 26);
            label36.TabIndex = 23;
            label36.Text = "Seçilen Yedek Dosyası:";
            // 
            // btnChooseSpareFolder
            // 
            btnChooseSpareFolder.BackgroundImage = Extensions.Resources.btnSpareFolder;
            btnChooseSpareFolder.BackgroundImageLayout = ImageLayout.Stretch;
            btnChooseSpareFolder.FlatAppearance.BorderSize = 0;
            btnChooseSpareFolder.FlatStyle = FlatStyle.Flat;
            btnChooseSpareFolder.Location = new Point(197, 167);
            btnChooseSpareFolder.Name = "btnChooseSpareFolder";
            btnChooseSpareFolder.Size = new Size(139, 110);
            btnChooseSpareFolder.TabIndex = 24;
            btnChooseSpareFolder.UseVisualStyleBackColor = true;
            btnChooseSpareFolder.Click += btnChooseSpareFolder_Click;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label37.ForeColor = Color.Black;
            label37.Location = new Point(197, 123);
            label37.Name = "label37";
            label37.Size = new Size(152, 25);
            label37.TabIndex = 22;
            label37.Text = "Dosyayı Seçiniz:";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label38.ForeColor = Color.Black;
            label38.Location = new Point(137, 88);
            label38.Name = "label38";
            label38.Size = new Size(272, 25);
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
            pnlMakeSpare.Location = new Point(24, 12);
            pnlMakeSpare.Margin = new Padding(2, 1, 2, 1);
            pnlMakeSpare.Name = "pnlMakeSpare";
            pnlMakeSpare.Size = new Size(1131, 408);
            pnlMakeSpare.TabIndex = 2;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label33.ForeColor = Color.GhostWhite;
            label33.Location = new Point(482, 113);
            label33.Name = "label33";
            label33.Size = new Size(151, 128);
            label33.TabIndex = 20;
            label33.Text = "➪";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.BackColor = Color.Gray;
            label32.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label32.ForeColor = SystemColors.ButtonHighlight;
            label32.Location = new Point(756, 250);
            label32.Name = "label32";
            label32.Size = new Size(222, 26);
            label32.TabIndex = 19;
            label32.Text = "Arşivi Dosyaya Yedekle";
            // 
            // btnDBtoFolder
            // 
            btnDBtoFolder.BackgroundImage = Extensions.Resources.btnDBtoFolder;
            btnDBtoFolder.BackgroundImageLayout = ImageLayout.Stretch;
            btnDBtoFolder.FlatAppearance.BorderSize = 0;
            btnDBtoFolder.FlatStyle = FlatStyle.Flat;
            btnDBtoFolder.Location = new Point(706, 91);
            btnDBtoFolder.Name = "btnDBtoFolder";
            btnDBtoFolder.Size = new Size(297, 161);
            btnDBtoFolder.TabIndex = 18;
            btnDBtoFolder.UseVisualStyleBackColor = true;
            // 
            // txtLocationForArchive
            // 
            txtLocationForArchive.BackColor = SystemColors.ScrollBar;
            txtLocationForArchive.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLocationForArchive.Location = new Point(48, 281);
            txtLocationForArchive.Name = "txtLocationForArchive";
            txtLocationForArchive.ReadOnly = true;
            txtLocationForArchive.Size = new Size(447, 32);
            txtLocationForArchive.TabIndex = 17;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label31.Location = new Point(187, 251);
            label31.Name = "label31";
            label31.Size = new Size(154, 26);
            label31.TabIndex = 15;
            label31.Text = "Seçilen Konum:";
            // 
            // btnLocationForArchive
            // 
            btnLocationForArchive.BackgroundImage = Extensions.Resources.btnChosenLocation;
            btnLocationForArchive.BackgroundImageLayout = ImageLayout.Stretch;
            btnLocationForArchive.FlatAppearance.BorderSize = 0;
            btnLocationForArchive.FlatStyle = FlatStyle.Flat;
            btnLocationForArchive.Location = new Point(200, 147);
            btnLocationForArchive.Name = "btnLocationForArchive";
            btnLocationForArchive.Size = new Size(125, 101);
            btnLocationForArchive.TabIndex = 16;
            btnLocationForArchive.UseVisualStyleBackColor = true;
            btnLocationForArchive.Click += btnLocationForArchive_Click;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label30.ForeColor = Color.Black;
            label30.Location = new Point(150, 91);
            label30.Name = "label30";
            label30.Size = new Size(219, 25);
            label30.TabIndex = 4;
            label30.Text = "Dosya Konumu Seçiniz:";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label29.ForeColor = Color.Black;
            label29.Location = new Point(90, 56);
            label29.Name = "label29";
            label29.Size = new Size(358, 25);
            label29.TabIndex = 3;
            label29.Text = "Veri Tabanındaki arşivi yedeklemek için";
            // 
            // pnlSearchPhoto
            // 
            pnlSearchPhoto.Controls.Add(panel1);
            pnlSearchPhoto.Controls.Add(lblSearchArchive);
            pnlSearchPhoto.Controls.Add(pictureBoxLoadingArchive);
            pnlSearchPhoto.Controls.Add(btnSearchArchive);
            pnlSearchPhoto.Controls.Add(listBoxArchive);
            pnlSearchPhoto.Controls.Add(label39);
            pnlSearchPhoto.Controls.Add(txtDataUpperFileName);
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
            pnlSearchPhoto.Location = new Point(5, 28);
            pnlSearchPhoto.Margin = new Padding(2, 1, 2, 1);
            pnlSearchPhoto.Name = "pnlSearchPhoto";
            pnlSearchPhoto.Size = new Size(1165, 376);
            pnlSearchPhoto.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblTotalRecord);
            panel1.Controls.Add(label40);
            panel1.Location = new Point(3, 279);
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 25);
            panel1.TabIndex = 26;
            // 
            // lblTotalRecord
            // 
            lblTotalRecord.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalRecord.ForeColor = Color.Black;
            lblTotalRecord.Location = new Point(100, 0);
            lblTotalRecord.Name = "lblTotalRecord";
            lblTotalRecord.Size = new Size(242, 21);
            lblTotalRecord.TabIndex = 27;
            lblTotalRecord.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label40.ForeColor = Color.Black;
            label40.Location = new Point(-1, 0);
            label40.Name = "label40";
            label40.Size = new Size(108, 21);
            label40.TabIndex = 26;
            label40.Text = "Kayıt Sayısı=";
            // 
            // lblSearchArchive
            // 
            lblSearchArchive.AutoSize = true;
            lblSearchArchive.BackColor = Color.Transparent;
            lblSearchArchive.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchArchive.ForeColor = Color.Black;
            lblSearchArchive.Location = new Point(921, 152);
            lblSearchArchive.Name = "lblSearchArchive";
            lblSearchArchive.Size = new Size(154, 26);
            lblSearchArchive.TabIndex = 25;
            lblSearchArchive.Text = "Üst Klasörü Ara";
            // 
            // pictureBoxLoadingArchive
            // 
            pictureBoxLoadingArchive.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxLoadingArchive.Image = Extensions.Resources.loading;
            pictureBoxLoadingArchive.InitialImage = Extensions.Resources.loading;
            pictureBoxLoadingArchive.Location = new Point(954, 75);
            pictureBoxLoadingArchive.Margin = new Padding(2, 1, 2, 1);
            pictureBoxLoadingArchive.Name = "pictureBoxLoadingArchive";
            pictureBoxLoadingArchive.Size = new Size(89, 81);
            pictureBoxLoadingArchive.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLoadingArchive.TabIndex = 24;
            pictureBoxLoadingArchive.TabStop = false;
            // 
            // btnSearchArchive
            // 
            btnSearchArchive.BackColor = Color.Transparent;
            btnSearchArchive.BackgroundImage = Extensions.Resources.btnSearchFolder;
            btnSearchArchive.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearchArchive.FlatAppearance.BorderSize = 0;
            btnSearchArchive.FlatStyle = FlatStyle.Flat;
            btnSearchArchive.Location = new Point(954, 85);
            btnSearchArchive.Name = "btnSearchArchive";
            btnSearchArchive.Size = new Size(80, 64);
            btnSearchArchive.TabIndex = 22;
            btnSearchArchive.UseVisualStyleBackColor = false;
            btnSearchArchive.Click += btnSearchArchive_Click;
            // 
            // listBoxArchive
            // 
            listBoxArchive.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxArchive.FormattingEnabled = true;
            listBoxArchive.HorizontalScrollbar = true;
            listBoxArchive.ItemHeight = 21;
            listBoxArchive.Location = new Point(853, 198);
            listBoxArchive.Margin = new Padding(2, 1, 2, 1);
            listBoxArchive.Name = "listBoxArchive";
            listBoxArchive.Size = new Size(303, 67);
            listBoxArchive.TabIndex = 21;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.BackColor = Color.Gold;
            label39.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label39.ForeColor = Color.Black;
            label39.Location = new Point(32, 313);
            label39.Name = "label39";
            label39.Size = new Size(268, 21);
            label39.TabIndex = 19;
            label39.Text = "Seçilen Kaydın Bulunduğu Üst Klasör:";
            // 
            // txtDataUpperFileName
            // 
            txtDataUpperFileName.BackColor = SystemColors.ScrollBar;
            txtDataUpperFileName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDataUpperFileName.ForeColor = SystemColors.MenuHighlight;
            txtDataUpperFileName.Location = new Point(32, 337);
            txtDataUpperFileName.Name = "txtDataUpperFileName";
            txtDataUpperFileName.ReadOnly = true;
            txtDataUpperFileName.Size = new Size(268, 33);
            txtDataUpperFileName.TabIndex = 18;
            // 
            // lblGoRecord
            // 
            lblGoRecord.AutoSize = true;
            lblGoRecord.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            lblGoRecord.ForeColor = SystemColors.ControlText;
            lblGoRecord.Location = new Point(934, 352);
            lblGoRecord.Name = "lblGoRecord";
            lblGoRecord.Size = new Size(158, 22);
            lblGoRecord.TabIndex = 15;
            lblGoRecord.Text = "Kayıt Dosyasına Git";
            // 
            // btnGoRecord
            // 
            btnGoRecord.BackgroundImage = Extensions.Resources.btnOpenFolder;
            btnGoRecord.BackgroundImageLayout = ImageLayout.Stretch;
            btnGoRecord.FlatAppearance.BorderSize = 0;
            btnGoRecord.FlatStyle = FlatStyle.Flat;
            btnGoRecord.Location = new Point(969, 269);
            btnGoRecord.Name = "btnGoRecord";
            btnGoRecord.Size = new Size(80, 80);
            btnGoRecord.TabIndex = 16;
            btnGoRecord.UseVisualStyleBackColor = true;
            btnGoRecord.Click += btnGoRecord_Click;
            // 
            // comboBoxDriversForRecord
            // 
            comboBoxDriversForRecord.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxDriversForRecord.FormattingEnabled = true;
            comboBoxDriversForRecord.Location = new Point(930, 36);
            comboBoxDriversForRecord.Margin = new Padding(2, 1, 2, 1);
            comboBoxDriversForRecord.Name = "comboBoxDriversForRecord";
            comboBoxDriversForRecord.Size = new Size(132, 33);
            comboBoxDriversForRecord.TabIndex = 5;
            // 
            // lblChooseDriver
            // 
            lblChooseDriver.AutoSize = true;
            lblChooseDriver.BackColor = Color.Transparent;
            lblChooseDriver.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChooseDriver.ForeColor = Color.Black;
            lblChooseDriver.Location = new Point(930, 7);
            lblChooseDriver.Name = "lblChooseDriver";
            lblChooseDriver.Size = new Size(116, 26);
            lblChooseDriver.TabIndex = 6;
            lblChooseDriver.Text = "Sürücü Seç:";
            // 
            // pictureBoxChosenPhoto
            // 
            pictureBoxChosenPhoto.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxChosenPhoto.Location = new Point(387, 70);
            pictureBoxChosenPhoto.Name = "pictureBoxChosenPhoto";
            pictureBoxChosenPhoto.Size = new Size(446, 303);
            pictureBoxChosenPhoto.TabIndex = 4;
            pictureBoxChosenPhoto.TabStop = false;
            // 
            // lblFoundPhoto
            // 
            lblFoundPhoto.AutoSize = true;
            lblFoundPhoto.BackColor = Color.Gold;
            lblFoundPhoto.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFoundPhoto.ForeColor = Color.Black;
            lblFoundPhoto.Location = new Point(523, 46);
            lblFoundPhoto.Name = "lblFoundPhoto";
            lblFoundPhoto.Size = new Size(166, 21);
            lblFoundPhoto.TabIndex = 2;
            lblFoundPhoto.Text = "Temsili Kayıt Fotoğrafı";
            // 
            // lblFound
            // 
            lblFound.AutoSize = true;
            lblFound.BackColor = Color.Gold;
            lblFound.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFound.ForeColor = Color.Black;
            lblFound.Location = new Point(95, 45);
            lblFound.Name = "lblFound";
            lblFound.Size = new Size(130, 21);
            lblFound.TabIndex = 2;
            lblFound.Text = "Bulunan Kayıtlar:";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(434, 4);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(369, 33);
            txtFullName.TabIndex = 1;
            txtFullName.TextChanged += txtFullName_TextChanged;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = Color.Black;
            lblFullName.Location = new Point(8, 5);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(389, 25);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Aradığınız kaydın ismini giriniz (ad soyad):";
            // 
            // lblExplanation
            // 
            lblExplanation.BackColor = Color.Silver;
            lblExplanation.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblExplanation.ForeColor = SystemColors.WindowFrame;
            lblExplanation.Location = new Point(211, 7);
            lblExplanation.Margin = new Padding(2, 0, 2, 0);
            lblExplanation.Name = "lblExplanation";
            lblExplanation.Size = new Size(1132, 141);
            lblExplanation.TabIndex = 20;
            // 
            // lblMainArchiveCaption
            // 
            lblMainArchiveCaption.AutoSize = true;
            lblMainArchiveCaption.Font = new Font("Comic Sans MS", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMainArchiveCaption.ForeColor = Color.Black;
            lblMainArchiveCaption.Location = new Point(305, 21);
            lblMainArchiveCaption.Margin = new Padding(2, 0, 2, 0);
            lblMainArchiveCaption.Name = "lblMainArchiveCaption";
            lblMainArchiveCaption.Size = new Size(638, 90);
            lblMainArchiveCaption.TabIndex = 0;
            lblMainArchiveCaption.Text = "ARŞİV İŞLEMLERİ";
            // 
            // lblEmpty
            // 
            lblEmpty.Font = new Font("Comic Sans MS", 14.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmpty.Location = new Point(8, 32);
            lblEmpty.Margin = new Padding(2, 0, 2, 0);
            lblEmpty.Name = "lblEmpty";
            lblEmpty.Size = new Size(189, 82);
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
            btnAddSpareToArchive.Location = new Point(8, 479);
            btnAddSpareToArchive.Margin = new Padding(8, 7, 8, 7);
            btnAddSpareToArchive.Name = "btnAddSpareToArchive";
            btnAddSpareToArchive.Size = new Size(148, 94);
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
            btnMakeSpare.Location = new Point(8, 371);
            btnMakeSpare.Margin = new Padding(8, 7, 8, 7);
            btnMakeSpare.Name = "btnMakeSpare";
            btnMakeSpare.Size = new Size(148, 94);
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
            btnAddFoldersToArchive.Location = new Point(8, 264);
            btnAddFoldersToArchive.Margin = new Padding(8, 7, 8, 7);
            btnAddFoldersToArchive.Name = "btnAddFoldersToArchive";
            btnAddFoldersToArchive.Size = new Size(148, 94);
            btnAddFoldersToArchive.TabIndex = 19;
            btnAddFoldersToArchive.Text = "Hazırlanan Dosyaları Arşive Ekle";
            btnAddFoldersToArchive.UseVisualStyleBackColor = false;
            btnAddFoldersToArchive.Click += btnAddFoldersToArchive_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Extensions.Resources.ArkaFon;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1732, 752);
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
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stüdyo-emin";
            ((System.ComponentModel.ISupportInitialize)dataGridRecords).EndInit();
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
            pnlAddFoldersToArchive.ResumeLayout(false);
            pnlAddFoldersToArchive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAddFolderToArchive).EndInit();
            pnlAddSpareToArchive.ResumeLayout(false);
            pnlAddSpareToArchive.PerformLayout();
            pnlMakeSpare.ResumeLayout(false);
            pnlMakeSpare.PerformLayout();
            pnlSearchPhoto.ResumeLayout(false);
            pnlSearchPhoto.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoadingArchive).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChosenPhoto).EndInit();
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
        private Label lblAddFolderToArchive;
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
        private Button btnChooseSpareFolder;
        private Label label37;
        private Label label38;
        private TextBox txtDataUpperFileName;
        private Label label39;
        private ListBox listBoxArchive;
        private PictureBox pictureBoxLoadingArchive;
        private Button btnSearchArchive;
        private Label lblSearchArchive;
        private Label lblTotalRecord;
        private Label label40;
        private Panel panel1;
        private PictureBox pictureBoxAddFolderToArchive;
    }
}
