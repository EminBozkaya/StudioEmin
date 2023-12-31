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
            pnlReceipt.SuspendLayout();
            pnlReceiptInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQty).BeginInit();
            pnlFindFolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoading).BeginInit();
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
            btnFindFolder.Location = new Point(37, 178);
            btnFindFolder.Name = "btnFindFolder";
            btnFindFolder.Size = new Size(100, 100);
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
            btnCreateReceipt.Location = new Point(37, 22);
            btnCreateReceipt.Name = "btnCreateReceipt";
            btnCreateReceipt.Size = new Size(100, 100);
            btnCreateReceipt.TabIndex = 0;
            btnCreateReceipt.UseVisualStyleBackColor = false;
            btnCreateReceipt.Click += btnCreateReceipt_Click;
            // 
            // pnlReceipt
            // 
            pnlReceipt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            pnlReceipt.Location = new Point(227, 81);
            pnlReceipt.Name = "pnlReceipt";
            pnlReceipt.Size = new Size(1289, 639);
            pnlReceipt.TabIndex = 1;
            // 
            // textBoxFileLocation
            // 
            textBoxFileLocation.BackColor = SystemColors.ScrollBar;
            textBoxFileLocation.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFileLocation.Location = new Point(493, 196);
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
            label12.Location = new Point(596, 595);
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
            lblFileLocation.ForeColor = SystemColors.ButtonHighlight;
            lblFileLocation.Location = new Point(803, 241);
            lblFileLocation.Name = "lblFileLocation";
            lblFileLocation.Size = new Size(0, 18);
            lblFileLocation.TabIndex = 2;
            // 
            // lblReceiptName
            // 
            lblReceiptName.AutoSize = true;
            lblReceiptName.FlatStyle = FlatStyle.Flat;
            lblReceiptName.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReceiptName.ForeColor = SystemColors.ButtonHighlight;
            lblReceiptName.Location = new Point(803, 299);
            lblReceiptName.Name = "lblReceiptName";
            lblReceiptName.Size = new Size(0, 18);
            lblReceiptName.TabIndex = 2;
            // 
            // lblSave
            // 
            lblSave.AutoSize = true;
            lblSave.FlatStyle = FlatStyle.Flat;
            lblSave.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSave.Location = new Point(595, 500);
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
            lblSaveAndPrint.Location = new Point(551, 384);
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
            label15.Location = new Point(793, 593);
            label15.Name = "label15";
            label15.Size = new Size(123, 22);
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
            pnlReceiptInputs.Location = new Point(13, 21);
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
            label26.ForeColor = SystemColors.ButtonFace;
            label26.Location = new Point(911, 438);
            label26.Name = "label26";
            label26.Size = new Size(108, 22);
            label26.TabIndex = 2;
            label26.Text = "Makbuza Git";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            label14.ForeColor = SystemColors.ButtonFace;
            label14.Location = new Point(793, 438);
            label14.Name = "label14";
            label14.Size = new Size(94, 22);
            label14.TabIndex = 2;
            label14.Text = "Klasöre Git";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label25.Location = new Point(803, 267);
            label25.Name = "label25";
            label25.Size = new Size(140, 28);
            label25.TabIndex = 2;
            label25.Text = "Makbuz Adı:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label24.Location = new Point(803, 206);
            label24.Name = "label24";
            label24.Size = new Size(135, 28);
            label24.TabIndex = 2;
            label24.Text = "Klasör           :";
            // 
            // lblReceiptCaption
            // 
            lblReceiptCaption.AutoSize = true;
            lblReceiptCaption.Font = new Font("Palatino Linotype", 17.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblReceiptCaption.Location = new Point(803, 175);
            lblReceiptCaption.Name = "lblReceiptCaption";
            lblReceiptCaption.Size = new Size(243, 31);
            lblReceiptCaption.TabIndex = 2;
            lblReceiptCaption.Text = "Oluşturulan Makbuz:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(543, 166);
            label13.Name = "label13";
            label13.Size = new Size(154, 26);
            label13.TabIndex = 2;
            label13.Text = "Seçilen Konum:";
            // 
            // btnTrash
            // 
            btnTrash.BackgroundImage = Properties.Resources.btnTrash;
            btnTrash.BackgroundImageLayout = ImageLayout.Stretch;
            btnTrash.FlatAppearance.BorderSize = 0;
            btnTrash.FlatStyle = FlatStyle.Flat;
            btnTrash.Location = new Point(805, 511);
            btnTrash.Name = "btnTrash";
            btnTrash.Size = new Size(80, 80);
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
            btnPrint.Location = new Point(586, 531);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(80, 73);
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
            btnChooseFileLocation.Location = new Point(566, 89);
            btnChooseFileLocation.Name = "btnChooseFileLocation";
            btnChooseFileLocation.Size = new Size(108, 81);
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
            btnSaveAndPrint.Location = new Point(526, 253);
            btnSaveAndPrint.Name = "btnSaveAndPrint";
            btnSaveAndPrint.Size = new Size(195, 147);
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
            btnSave.Location = new Point(586, 438);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 64);
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
            btnGoReceipt.Location = new Point(921, 355);
            btnGoReceipt.Name = "btnGoReceipt";
            btnGoReceipt.Size = new Size(80, 80);
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
            btnGoTheFolder.Location = new Point(803, 355);
            btnGoTheFolder.Name = "btnGoTheFolder";
            btnGoTheFolder.Size = new Size(80, 80);
            btnGoTheFolder.TabIndex = 14;
            btnGoTheFolder.UseVisualStyleBackColor = true;
            btnGoTheFolder.Click += btnGoTheFolder_Click;
            // 
            // pnlFindFolder
            // 
            pnlFindFolder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            pnlFindFolder.Location = new Point(274, 44);
            pnlFindFolder.Margin = new Padding(2, 1, 2, 1);
            pnlFindFolder.Name = "pnlFindFolder";
            pnlFindFolder.Size = new Size(1060, 589);
            pnlFindFolder.TabIndex = 16;
            // 
            // pictureBoxLoading
            // 
            pictureBoxLoading.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxLoading.Image = Properties.Resources.loading;
            pictureBoxLoading.InitialImage = Properties.Resources.loading;
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
            listBoxFiles.Size = new Size(507, 130);
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
            btnSearchFile.BackgroundImage = Properties.Resources.btnSearchFolder;
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
            label17.Font = new Font("Palatino Linotype", 13.875F, FontStyle.Bold);
            label17.ForeColor = SystemColors.ActiveCaptionText;
            label17.Location = new Point(193, 105);
            label17.Name = "label17";
            label17.Size = new Size(116, 26);
            label17.TabIndex = 2;
            label17.Text = "Sürücü Seç:";
            // 
            // lblSearchFile
            // 
            lblSearchFile.AutoSize = true;
            lblSearchFile.BackColor = Color.Transparent;
            lblSearchFile.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchFile.ForeColor = SystemColors.ActiveCaptionText;
            lblSearchFile.Location = new Point(386, 320);
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
            label19.Size = new Size(217, 32);
            label19.TabIndex = 2;
            label19.Text = "Bulunan Dosyalar:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Palatino Linotype", 13.875F, FontStyle.Bold);
            label16.ForeColor = SystemColors.ActiveCaptionText;
            label16.Location = new Point(556, 105);
            label16.Name = "label16";
            label16.Size = new Size(144, 26);
            label16.TabIndex = 2;
            label16.Text = "Dosya Adı Gir:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(37, 122);
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
            label21.Location = new Point(37, 283);
            label21.Name = "label21";
            label21.Size = new Size(86, 22);
            label21.TabIndex = 2;
            label21.Text = "Dosya Ara";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = SystemColors.ButtonFace;
            label22.Location = new Point(37, 437);
            label22.Name = "label22";
            label22.Size = new Size(104, 22);
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
            btnMyComputer.Location = new Point(37, 332);
            btnMyComputer.Name = "btnMyComputer";
            btnMyComputer.Size = new Size(100, 100);
            btnMyComputer.TabIndex = 0;
            btnMyComputer.UseVisualStyleBackColor = false;
            btnMyComputer.Click += btnMyComputer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ArkaFon;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1663, 761);
            Controls.Add(pnlReceipt);
            Controls.Add(pnlFindFolder);
            Controls.Add(btnMyComputer);
            Controls.Add(btnFindFolder);
            Controls.Add(label22);
            Controls.Add(btnCreateReceipt);
            Controls.Add(label21);
            Controls.Add(label9);
            DoubleBuffered = true;
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
    }
}
