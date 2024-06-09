namespace HairdresserManagementSystem.UserInterface
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            tabControl1 = new TabControl();
            tabPageSettings = new TabPage();
            btnSave = new Button();
            ımageListButtons = new ImageList(components);
            lblTitle = new Label();
            pictureBoxLogo = new PictureBox();
            txtPhone = new TextBox();
            txtAuthority = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            lblPhone = new Label();
            lblAuthority = new Label();
            lblAddress = new Label();
            lblName = new Label();
            tabPageEmployee = new TabPage();
            btnEmployeeDelete = new Button();
            btnEmployeeUpdate = new Button();
            pictureBoxEmployee = new PictureBox();
            lblEmployeePhone = new Label();
            lblEmployeePassword = new Label();
            lblEmployeeType = new Label();
            lblEmployeeEmail = new Label();
            lblEmployeeName = new Label();
            btnEmployeeAdd = new Button();
            comboBoxEmployeeType = new ComboBox();
            txtEmployeePhone = new TextBox();
            txtEmployeePassword = new TextBox();
            txtEmployeeEmail = new TextBox();
            txtEmployeeName = new TextBox();
            dataGridViewEmployee = new DataGridView();
            tabPageChairs = new TabPage();
            btnChairDelete = new Button();
            btnChairUpdate = new Button();
            pictureBoxChair = new PictureBox();
            lblChairEmployee = new Label();
            lblChairName = new Label();
            btnChairAdd = new Button();
            comboBoxChairEmployee = new ComboBox();
            txtChairName = new TextBox();
            dataGridViewChair = new DataGridView();
            tabPageCategories = new TabPage();
            btnCategoryAdd = new Button();
            btnCategoryDelete = new Button();
            btnCategoryUpdate = new Button();
            pictureBoxCategory = new PictureBox();
            lblCategoryName = new Label();
            txtCategoryName = new TextBox();
            dataGridViewCategory = new DataGridView();
            tabPageProducts = new TabPage();
            lblProductPrice = new Label();
            lblProductName = new Label();
            lblProductCategory = new Label();
            btnProductDelete = new Button();
            btnProductUpdate = new Button();
            pictureBoxProduct = new PictureBox();
            btnProductAdd = new Button();
            comboBoxProductCategory = new ComboBox();
            txtProductPrice = new TextBox();
            txtProductName = new TextBox();
            dataGridViewProduct = new DataGridView();
            btnBack = new Button();
            tabControl1.SuspendLayout();
            tabPageSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            tabPageEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployee).BeginInit();
            tabPageChairs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChair).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewChair).BeginInit();
            tabPageCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategory).BeginInit();
            tabPageProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageSettings);
            tabControl1.Controls.Add(tabPageEmployee);
            tabControl1.Controls.Add(tabPageChairs);
            tabControl1.Controls.Add(tabPageCategories);
            tabControl1.Controls.Add(tabPageProducts);
            tabControl1.Location = new Point(0, -2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1097, 576);
            tabControl1.TabIndex = 0;
            // 
            // tabPageSettings
            // 
            tabPageSettings.BackColor = SystemColors.Control;
            tabPageSettings.Controls.Add(btnSave);
            tabPageSettings.Controls.Add(lblTitle);
            tabPageSettings.Controls.Add(pictureBoxLogo);
            tabPageSettings.Controls.Add(txtPhone);
            tabPageSettings.Controls.Add(txtAuthority);
            tabPageSettings.Controls.Add(txtAddress);
            tabPageSettings.Controls.Add(txtName);
            tabPageSettings.Controls.Add(lblPhone);
            tabPageSettings.Controls.Add(lblAuthority);
            tabPageSettings.Controls.Add(lblAddress);
            tabPageSettings.Controls.Add(lblName);
            tabPageSettings.Location = new Point(4, 24);
            tabPageSettings.Name = "tabPageSettings";
            tabPageSettings.Padding = new Padding(3);
            tabPageSettings.Size = new Size(1089, 548);
            tabPageSettings.TabIndex = 0;
            tabPageSettings.Text = "Genel Ayarlar";
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSave.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Trebuchet MS", 11F, FontStyle.Bold);
            btnSave.ImageAlign = ContentAlignment.TopCenter;
            btnSave.ImageKey = "save.png";
            btnSave.ImageList = ımageListButtons;
            btnSave.Location = new Point(492, 452);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 74);
            btnSave.TabIndex = 10;
            btnSave.Text = "Kaydet";
            btnSave.TextAlign = ContentAlignment.BottomCenter;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // ımageListButtons
            // 
            ımageListButtons.ColorDepth = ColorDepth.Depth24Bit;
            ımageListButtons.ImageStream = (ImageListStreamer)resources.GetObject("ımageListButtons.ImageStream");
            ımageListButtons.TransparentColor = Color.Transparent;
            ımageListButtons.Images.SetKeyName(0, "btnAdd.png");
            ımageListButtons.Images.SetKeyName(1, "btnDelete.png");
            ımageListButtons.Images.SetKeyName(2, "btnUpdate.png");
            ımageListButtons.Images.SetKeyName(3, "btnHome.png");
            ımageListButtons.Images.SetKeyName(4, "save.png");
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold);
            lblTitle.Location = new Point(474, 116);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(108, 20);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "HairdresserMS";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(479, 29);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(93, 84);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 8;
            pictureBoxLogo.TabStop = false;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold);
            txtPhone.Location = new Point(422, 360);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(237, 27);
            txtPhone.TabIndex = 6;
            txtPhone.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAuthority
            // 
            txtAuthority.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold);
            txtAuthority.Location = new Point(422, 409);
            txtAuthority.Name = "txtAuthority";
            txtAuthority.Size = new Size(237, 27);
            txtAuthority.TabIndex = 6;
            txtAuthority.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold);
            txtAddress.Location = new Point(422, 234);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(237, 102);
            txtAddress.TabIndex = 5;
            txtAddress.TextAlign = HorizontalAlignment.Center;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.Location = new Point(422, 164);
            txtName.Name = "txtName";
            txtName.Size = new Size(237, 27);
            txtName.TabIndex = 4;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblPhone.Location = new Point(293, 360);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(123, 23);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "İşyeri Telefon";
            // 
            // lblAuthority
            // 
            lblAuthority.AutoSize = true;
            lblAuthority.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblAuthority.Location = new Point(288, 409);
            lblAuthority.Name = "lblAuthority";
            lblAuthority.Size = new Size(128, 23);
            lblAuthority.TabIndex = 2;
            lblAuthority.Text = "İşyeri Yetkilisi";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblAddress.Location = new Point(293, 234);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(117, 23);
            lblAddress.TabIndex = 1;
            lblAddress.Text = "İşyeri Adresi";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblName.Location = new Point(321, 164);
            lblName.Name = "lblName";
            lblName.Size = new Size(89, 23);
            lblName.TabIndex = 0;
            lblName.Text = "İşyeri Adı";
            // 
            // tabPageEmployee
            // 
            tabPageEmployee.BackColor = SystemColors.Control;
            tabPageEmployee.Controls.Add(btnEmployeeDelete);
            tabPageEmployee.Controls.Add(btnEmployeeUpdate);
            tabPageEmployee.Controls.Add(pictureBoxEmployee);
            tabPageEmployee.Controls.Add(lblEmployeePhone);
            tabPageEmployee.Controls.Add(lblEmployeePassword);
            tabPageEmployee.Controls.Add(lblEmployeeType);
            tabPageEmployee.Controls.Add(lblEmployeeEmail);
            tabPageEmployee.Controls.Add(lblEmployeeName);
            tabPageEmployee.Controls.Add(btnEmployeeAdd);
            tabPageEmployee.Controls.Add(comboBoxEmployeeType);
            tabPageEmployee.Controls.Add(txtEmployeePhone);
            tabPageEmployee.Controls.Add(txtEmployeePassword);
            tabPageEmployee.Controls.Add(txtEmployeeEmail);
            tabPageEmployee.Controls.Add(txtEmployeeName);
            tabPageEmployee.Controls.Add(dataGridViewEmployee);
            tabPageEmployee.Location = new Point(4, 24);
            tabPageEmployee.Name = "tabPageEmployee";
            tabPageEmployee.Padding = new Padding(3);
            tabPageEmployee.Size = new Size(1089, 548);
            tabPageEmployee.TabIndex = 1;
            tabPageEmployee.Text = "Personeller";
            // 
            // btnEmployeeDelete
            // 
            btnEmployeeDelete.BackColor = SystemColors.Control;
            btnEmployeeDelete.FlatAppearance.BorderSize = 0;
            btnEmployeeDelete.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnEmployeeDelete.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnEmployeeDelete.FlatStyle = FlatStyle.Flat;
            btnEmployeeDelete.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmployeeDelete.ImageAlign = ContentAlignment.TopCenter;
            btnEmployeeDelete.ImageKey = "btnDelete.png";
            btnEmployeeDelete.ImageList = ımageListButtons;
            btnEmployeeDelete.Location = new Point(211, 474);
            btnEmployeeDelete.Name = "btnEmployeeDelete";
            btnEmployeeDelete.Size = new Size(60, 70);
            btnEmployeeDelete.TabIndex = 35;
            btnEmployeeDelete.Text = "Sil";
            btnEmployeeDelete.TextAlign = ContentAlignment.BottomCenter;
            btnEmployeeDelete.UseVisualStyleBackColor = false;
            // 
            // btnEmployeeUpdate
            // 
            btnEmployeeUpdate.BackColor = SystemColors.Control;
            btnEmployeeUpdate.FlatAppearance.BorderSize = 0;
            btnEmployeeUpdate.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnEmployeeUpdate.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnEmployeeUpdate.FlatStyle = FlatStyle.Flat;
            btnEmployeeUpdate.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmployeeUpdate.ImageAlign = ContentAlignment.TopCenter;
            btnEmployeeUpdate.ImageKey = "btnUpdate.png";
            btnEmployeeUpdate.ImageList = ımageListButtons;
            btnEmployeeUpdate.Location = new Point(118, 474);
            btnEmployeeUpdate.Name = "btnEmployeeUpdate";
            btnEmployeeUpdate.Size = new Size(70, 70);
            btnEmployeeUpdate.TabIndex = 34;
            btnEmployeeUpdate.Text = "Güncelle";
            btnEmployeeUpdate.TextAlign = ContentAlignment.BottomCenter;
            btnEmployeeUpdate.UseVisualStyleBackColor = false;
            // 
            // pictureBoxEmployee
            // 
            pictureBoxEmployee.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxEmployee.Image = (Image)resources.GetObject("pictureBoxEmployee.Image");
            pictureBoxEmployee.Location = new Point(92, 23);
            pictureBoxEmployee.Name = "pictureBoxEmployee";
            pictureBoxEmployee.Size = new Size(115, 82);
            pictureBoxEmployee.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxEmployee.TabIndex = 33;
            pictureBoxEmployee.TabStop = false;
            // 
            // lblEmployeePhone
            // 
            lblEmployeePhone.AutoSize = true;
            lblEmployeePhone.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblEmployeePhone.Location = new Point(34, 330);
            lblEmployeePhone.Name = "lblEmployeePhone";
            lblEmployeePhone.Size = new Size(71, 23);
            lblEmployeePhone.TabIndex = 32;
            lblEmployeePhone.Text = "Telefon";
            // 
            // lblEmployeePassword
            // 
            lblEmployeePassword.AutoSize = true;
            lblEmployeePassword.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblEmployeePassword.Location = new Point(34, 258);
            lblEmployeePassword.Name = "lblEmployeePassword";
            lblEmployeePassword.Size = new Size(51, 23);
            lblEmployeePassword.TabIndex = 30;
            lblEmployeePassword.Text = "Şifre";
            // 
            // lblEmployeeType
            // 
            lblEmployeeType.AutoSize = true;
            lblEmployeeType.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblEmployeeType.Location = new Point(34, 407);
            lblEmployeeType.Name = "lblEmployeeType";
            lblEmployeeType.Size = new Size(50, 23);
            lblEmployeeType.TabIndex = 31;
            lblEmployeeType.Text = "Yetki";
            // 
            // lblEmployeeEmail
            // 
            lblEmployeeEmail.AutoSize = true;
            lblEmployeeEmail.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblEmployeeEmail.Location = new Point(34, 186);
            lblEmployeeEmail.Name = "lblEmployeeEmail";
            lblEmployeeEmail.Size = new Size(58, 23);
            lblEmployeeEmail.TabIndex = 29;
            lblEmployeeEmail.Text = "Email";
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblEmployeeName.Location = new Point(34, 121);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(88, 23);
            lblEmployeeName.TabIndex = 28;
            lblEmployeeName.Text = "Ad Soyad";
            // 
            // btnEmployeeAdd
            // 
            btnEmployeeAdd.BackColor = SystemColors.Control;
            btnEmployeeAdd.FlatAppearance.BorderSize = 0;
            btnEmployeeAdd.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnEmployeeAdd.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnEmployeeAdd.FlatStyle = FlatStyle.Flat;
            btnEmployeeAdd.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmployeeAdd.ImageAlign = ContentAlignment.TopCenter;
            btnEmployeeAdd.ImageKey = "btnAdd.png";
            btnEmployeeAdd.ImageList = ımageListButtons;
            btnEmployeeAdd.Location = new Point(34, 474);
            btnEmployeeAdd.Name = "btnEmployeeAdd";
            btnEmployeeAdd.Size = new Size(60, 67);
            btnEmployeeAdd.TabIndex = 27;
            btnEmployeeAdd.Text = "Ekle";
            btnEmployeeAdd.TextAlign = ContentAlignment.BottomCenter;
            btnEmployeeAdd.UseVisualStyleBackColor = false;
            btnEmployeeAdd.Click += btnEmployeeAdd_Click;
            // 
            // comboBoxEmployeeType
            // 
            comboBoxEmployeeType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEmployeeType.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold);
            comboBoxEmployeeType.FormattingEnabled = true;
            comboBoxEmployeeType.Location = new Point(34, 433);
            comboBoxEmployeeType.Name = "comboBoxEmployeeType";
            comboBoxEmployeeType.Size = new Size(237, 28);
            comboBoxEmployeeType.TabIndex = 26;
            // 
            // txtEmployeePhone
            // 
            txtEmployeePhone.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmployeePhone.Location = new Point(34, 356);
            txtEmployeePhone.Name = "txtEmployeePhone";
            txtEmployeePhone.Size = new Size(237, 27);
            txtEmployeePhone.TabIndex = 25;
            txtEmployeePhone.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEmployeePassword
            // 
            txtEmployeePassword.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmployeePassword.Location = new Point(34, 284);
            txtEmployeePassword.Name = "txtEmployeePassword";
            txtEmployeePassword.Size = new Size(237, 27);
            txtEmployeePassword.TabIndex = 24;
            txtEmployeePassword.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEmployeeEmail
            // 
            txtEmployeeEmail.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmployeeEmail.Location = new Point(34, 212);
            txtEmployeeEmail.Name = "txtEmployeeEmail";
            txtEmployeeEmail.Size = new Size(237, 27);
            txtEmployeeEmail.TabIndex = 23;
            txtEmployeeEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmployeeName.Location = new Point(34, 147);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(237, 27);
            txtEmployeeName.TabIndex = 22;
            txtEmployeeName.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridViewEmployee
            // 
            dataGridViewEmployee.AllowUserToAddRows = false;
            dataGridViewEmployee.AllowUserToDeleteRows = false;
            dataGridViewEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployee.Location = new Point(306, 5);
            dataGridViewEmployee.Name = "dataGridViewEmployee";
            dataGridViewEmployee.ReadOnly = true;
            dataGridViewEmployee.Size = new Size(749, 536);
            dataGridViewEmployee.TabIndex = 21;
            // 
            // tabPageChairs
            // 
            tabPageChairs.Controls.Add(btnChairDelete);
            tabPageChairs.Controls.Add(btnChairUpdate);
            tabPageChairs.Controls.Add(pictureBoxChair);
            tabPageChairs.Controls.Add(lblChairEmployee);
            tabPageChairs.Controls.Add(lblChairName);
            tabPageChairs.Controls.Add(btnChairAdd);
            tabPageChairs.Controls.Add(comboBoxChairEmployee);
            tabPageChairs.Controls.Add(txtChairName);
            tabPageChairs.Controls.Add(dataGridViewChair);
            tabPageChairs.Location = new Point(4, 24);
            tabPageChairs.Name = "tabPageChairs";
            tabPageChairs.Padding = new Padding(3);
            tabPageChairs.Size = new Size(1089, 548);
            tabPageChairs.TabIndex = 2;
            tabPageChairs.Text = "Koltuklar";
            // 
            // btnChairDelete
            // 
            btnChairDelete.BackColor = SystemColors.Control;
            btnChairDelete.FlatAppearance.BorderSize = 0;
            btnChairDelete.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnChairDelete.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnChairDelete.FlatStyle = FlatStyle.Flat;
            btnChairDelete.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChairDelete.ImageAlign = ContentAlignment.TopCenter;
            btnChairDelete.ImageKey = "btnDelete.png";
            btnChairDelete.ImageList = ımageListButtons;
            btnChairDelete.Location = new Point(202, 380);
            btnChairDelete.Name = "btnChairDelete";
            btnChairDelete.Size = new Size(60, 70);
            btnChairDelete.TabIndex = 35;
            btnChairDelete.Text = "Sil";
            btnChairDelete.TextAlign = ContentAlignment.BottomCenter;
            btnChairDelete.UseVisualStyleBackColor = false;
            // 
            // btnChairUpdate
            // 
            btnChairUpdate.BackColor = SystemColors.Control;
            btnChairUpdate.FlatAppearance.BorderSize = 0;
            btnChairUpdate.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnChairUpdate.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnChairUpdate.FlatStyle = FlatStyle.Flat;
            btnChairUpdate.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChairUpdate.ImageAlign = ContentAlignment.TopCenter;
            btnChairUpdate.ImageKey = "btnUpdate.png";
            btnChairUpdate.ImageList = ımageListButtons;
            btnChairUpdate.Location = new Point(109, 380);
            btnChairUpdate.Name = "btnChairUpdate";
            btnChairUpdate.Size = new Size(70, 70);
            btnChairUpdate.TabIndex = 34;
            btnChairUpdate.Text = "Güncelle";
            btnChairUpdate.TextAlign = ContentAlignment.BottomCenter;
            btnChairUpdate.UseVisualStyleBackColor = false;
            // 
            // pictureBoxChair
            // 
            pictureBoxChair.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxChair.Image = (Image)resources.GetObject("pictureBoxChair.Image");
            pictureBoxChair.Location = new Point(78, 53);
            pictureBoxChair.Name = "pictureBoxChair";
            pictureBoxChair.Size = new Size(139, 103);
            pictureBoxChair.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxChair.TabIndex = 33;
            pictureBoxChair.TabStop = false;
            // 
            // lblChairEmployee
            // 
            lblChairEmployee.AutoSize = true;
            lblChairEmployee.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblChairEmployee.Location = new Point(34, 280);
            lblChairEmployee.Name = "lblChairEmployee";
            lblChairEmployee.Size = new Size(86, 23);
            lblChairEmployee.TabIndex = 31;
            lblChairEmployee.Text = "Personel";
            // 
            // lblChairName
            // 
            lblChairName.AutoSize = true;
            lblChairName.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblChairName.Location = new Point(34, 204);
            lblChairName.Name = "lblChairName";
            lblChairName.Size = new Size(32, 23);
            lblChairName.TabIndex = 28;
            lblChairName.Text = "Ad";
            // 
            // btnChairAdd
            // 
            btnChairAdd.BackColor = SystemColors.Control;
            btnChairAdd.FlatAppearance.BorderSize = 0;
            btnChairAdd.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnChairAdd.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnChairAdd.FlatStyle = FlatStyle.Flat;
            btnChairAdd.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChairAdd.ImageAlign = ContentAlignment.TopCenter;
            btnChairAdd.ImageKey = "btnAdd.png";
            btnChairAdd.ImageList = ımageListButtons;
            btnChairAdd.Location = new Point(25, 380);
            btnChairAdd.Name = "btnChairAdd";
            btnChairAdd.Size = new Size(60, 67);
            btnChairAdd.TabIndex = 27;
            btnChairAdd.Text = "Ekle";
            btnChairAdd.TextAlign = ContentAlignment.BottomCenter;
            btnChairAdd.UseVisualStyleBackColor = false;
            // 
            // comboBoxChairEmployee
            // 
            comboBoxChairEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxChairEmployee.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold);
            comboBoxChairEmployee.FormattingEnabled = true;
            comboBoxChairEmployee.Location = new Point(34, 306);
            comboBoxChairEmployee.Name = "comboBoxChairEmployee";
            comboBoxChairEmployee.Size = new Size(237, 28);
            comboBoxChairEmployee.TabIndex = 26;
            // 
            // txtChairName
            // 
            txtChairName.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtChairName.Location = new Point(34, 230);
            txtChairName.Name = "txtChairName";
            txtChairName.Size = new Size(237, 27);
            txtChairName.TabIndex = 22;
            txtChairName.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridViewChair
            // 
            dataGridViewChair.AllowUserToAddRows = false;
            dataGridViewChair.AllowUserToDeleteRows = false;
            dataGridViewChair.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewChair.Location = new Point(306, 5);
            dataGridViewChair.Name = "dataGridViewChair";
            dataGridViewChair.ReadOnly = true;
            dataGridViewChair.Size = new Size(749, 536);
            dataGridViewChair.TabIndex = 21;
            // 
            // tabPageCategories
            // 
            tabPageCategories.BackColor = SystemColors.Control;
            tabPageCategories.Controls.Add(btnCategoryAdd);
            tabPageCategories.Controls.Add(btnCategoryDelete);
            tabPageCategories.Controls.Add(btnCategoryUpdate);
            tabPageCategories.Controls.Add(pictureBoxCategory);
            tabPageCategories.Controls.Add(lblCategoryName);
            tabPageCategories.Controls.Add(txtCategoryName);
            tabPageCategories.Controls.Add(dataGridViewCategory);
            tabPageCategories.Location = new Point(4, 24);
            tabPageCategories.Name = "tabPageCategories";
            tabPageCategories.Padding = new Padding(3);
            tabPageCategories.Size = new Size(1089, 548);
            tabPageCategories.TabIndex = 3;
            tabPageCategories.Text = "Kategoriler";
            // 
            // btnCategoryAdd
            // 
            btnCategoryAdd.BackColor = SystemColors.Control;
            btnCategoryAdd.FlatAppearance.BorderSize = 0;
            btnCategoryAdd.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCategoryAdd.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCategoryAdd.FlatStyle = FlatStyle.Flat;
            btnCategoryAdd.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCategoryAdd.ImageAlign = ContentAlignment.TopCenter;
            btnCategoryAdd.ImageKey = "btnAdd.png";
            btnCategoryAdd.ImageList = ımageListButtons;
            btnCategoryAdd.Location = new Point(27, 281);
            btnCategoryAdd.Name = "btnCategoryAdd";
            btnCategoryAdd.Size = new Size(70, 70);
            btnCategoryAdd.TabIndex = 36;
            btnCategoryAdd.Text = "Ekle";
            btnCategoryAdd.TextAlign = ContentAlignment.BottomCenter;
            btnCategoryAdd.UseVisualStyleBackColor = false;
            // 
            // btnCategoryDelete
            // 
            btnCategoryDelete.BackColor = SystemColors.Control;
            btnCategoryDelete.FlatAppearance.BorderSize = 0;
            btnCategoryDelete.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCategoryDelete.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCategoryDelete.FlatStyle = FlatStyle.Flat;
            btnCategoryDelete.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCategoryDelete.ImageAlign = ContentAlignment.TopCenter;
            btnCategoryDelete.ImageKey = "btnDelete.png";
            btnCategoryDelete.ImageList = ımageListButtons;
            btnCategoryDelete.Location = new Point(204, 281);
            btnCategoryDelete.Name = "btnCategoryDelete";
            btnCategoryDelete.Size = new Size(60, 70);
            btnCategoryDelete.TabIndex = 35;
            btnCategoryDelete.Text = "Sil";
            btnCategoryDelete.TextAlign = ContentAlignment.BottomCenter;
            btnCategoryDelete.UseVisualStyleBackColor = false;
            // 
            // btnCategoryUpdate
            // 
            btnCategoryUpdate.BackColor = SystemColors.Control;
            btnCategoryUpdate.FlatAppearance.BorderSize = 0;
            btnCategoryUpdate.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCategoryUpdate.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCategoryUpdate.FlatStyle = FlatStyle.Flat;
            btnCategoryUpdate.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCategoryUpdate.ImageAlign = ContentAlignment.TopCenter;
            btnCategoryUpdate.ImageKey = "btnUpdate.png";
            btnCategoryUpdate.ImageList = ımageListButtons;
            btnCategoryUpdate.Location = new Point(111, 281);
            btnCategoryUpdate.Name = "btnCategoryUpdate";
            btnCategoryUpdate.Size = new Size(70, 70);
            btnCategoryUpdate.TabIndex = 34;
            btnCategoryUpdate.Text = "Güncelle";
            btnCategoryUpdate.TextAlign = ContentAlignment.BottomCenter;
            btnCategoryUpdate.UseVisualStyleBackColor = false;
            // 
            // pictureBoxCategory
            // 
            pictureBoxCategory.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxCategory.Image = (Image)resources.GetObject("pictureBoxCategory.Image");
            pictureBoxCategory.Location = new Point(65, 28);
            pictureBoxCategory.Name = "pictureBoxCategory";
            pictureBoxCategory.Size = new Size(147, 116);
            pictureBoxCategory.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCategory.TabIndex = 33;
            pictureBoxCategory.TabStop = false;
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblCategoryName.Location = new Point(27, 197);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(32, 23);
            lblCategoryName.TabIndex = 28;
            lblCategoryName.Text = "Ad";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCategoryName.Location = new Point(27, 223);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(237, 27);
            txtCategoryName.TabIndex = 22;
            txtCategoryName.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridViewCategory
            // 
            dataGridViewCategory.AllowUserToAddRows = false;
            dataGridViewCategory.AllowUserToDeleteRows = false;
            dataGridViewCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategory.Location = new Point(306, 5);
            dataGridViewCategory.Name = "dataGridViewCategory";
            dataGridViewCategory.ReadOnly = true;
            dataGridViewCategory.Size = new Size(749, 536);
            dataGridViewCategory.TabIndex = 21;
            // 
            // tabPageProducts
            // 
            tabPageProducts.BackColor = SystemColors.Control;
            tabPageProducts.Controls.Add(lblProductPrice);
            tabPageProducts.Controls.Add(lblProductName);
            tabPageProducts.Controls.Add(lblProductCategory);
            tabPageProducts.Controls.Add(btnProductDelete);
            tabPageProducts.Controls.Add(btnProductUpdate);
            tabPageProducts.Controls.Add(pictureBoxProduct);
            tabPageProducts.Controls.Add(btnProductAdd);
            tabPageProducts.Controls.Add(comboBoxProductCategory);
            tabPageProducts.Controls.Add(txtProductPrice);
            tabPageProducts.Controls.Add(txtProductName);
            tabPageProducts.Controls.Add(dataGridViewProduct);
            tabPageProducts.Location = new Point(4, 24);
            tabPageProducts.Name = "tabPageProducts";
            tabPageProducts.Padding = new Padding(3);
            tabPageProducts.Size = new Size(1089, 548);
            tabPageProducts.TabIndex = 4;
            tabPageProducts.Text = "Ürün/Hizmetler";
            // 
            // lblProductPrice
            // 
            lblProductPrice.AutoSize = true;
            lblProductPrice.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblProductPrice.Location = new Point(34, 327);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(51, 23);
            lblProductPrice.TabIndex = 38;
            lblProductPrice.Text = "Fiyat";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblProductName.Location = new Point(34, 262);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(32, 23);
            lblProductName.TabIndex = 37;
            lblProductName.Text = "Ad";
            // 
            // lblProductCategory
            // 
            lblProductCategory.AutoSize = true;
            lblProductCategory.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblProductCategory.Location = new Point(34, 193);
            lblProductCategory.Name = "lblProductCategory";
            lblProductCategory.Size = new Size(81, 23);
            lblProductCategory.TabIndex = 36;
            lblProductCategory.Text = "Kategori";
            // 
            // btnProductDelete
            // 
            btnProductDelete.BackColor = SystemColors.Control;
            btnProductDelete.FlatAppearance.BorderSize = 0;
            btnProductDelete.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnProductDelete.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnProductDelete.FlatStyle = FlatStyle.Flat;
            btnProductDelete.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProductDelete.ImageAlign = ContentAlignment.TopCenter;
            btnProductDelete.ImageKey = "btnDelete.png";
            btnProductDelete.ImageList = ımageListButtons;
            btnProductDelete.Location = new Point(202, 404);
            btnProductDelete.Name = "btnProductDelete";
            btnProductDelete.Size = new Size(60, 70);
            btnProductDelete.TabIndex = 35;
            btnProductDelete.Text = "Sil";
            btnProductDelete.TextAlign = ContentAlignment.BottomCenter;
            btnProductDelete.UseVisualStyleBackColor = false;
            // 
            // btnProductUpdate
            // 
            btnProductUpdate.BackColor = SystemColors.Control;
            btnProductUpdate.FlatAppearance.BorderSize = 0;
            btnProductUpdate.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnProductUpdate.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnProductUpdate.FlatStyle = FlatStyle.Flat;
            btnProductUpdate.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProductUpdate.ImageAlign = ContentAlignment.TopCenter;
            btnProductUpdate.ImageKey = "btnUpdate.png";
            btnProductUpdate.ImageList = ımageListButtons;
            btnProductUpdate.Location = new Point(109, 404);
            btnProductUpdate.Name = "btnProductUpdate";
            btnProductUpdate.Size = new Size(70, 70);
            btnProductUpdate.TabIndex = 34;
            btnProductUpdate.Text = "Güncelle";
            btnProductUpdate.TextAlign = ContentAlignment.BottomCenter;
            btnProductUpdate.UseVisualStyleBackColor = false;
            // 
            // pictureBoxProduct
            // 
            pictureBoxProduct.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxProduct.Image = (Image)resources.GetObject("pictureBoxProduct.Image");
            pictureBoxProduct.Location = new Point(78, 43);
            pictureBoxProduct.Name = "pictureBoxProduct";
            pictureBoxProduct.Size = new Size(140, 105);
            pictureBoxProduct.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxProduct.TabIndex = 33;
            pictureBoxProduct.TabStop = false;
            // 
            // btnProductAdd
            // 
            btnProductAdd.BackColor = SystemColors.Control;
            btnProductAdd.FlatAppearance.BorderSize = 0;
            btnProductAdd.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnProductAdd.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnProductAdd.FlatStyle = FlatStyle.Flat;
            btnProductAdd.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProductAdd.ImageAlign = ContentAlignment.TopCenter;
            btnProductAdd.ImageKey = "btnAdd.png";
            btnProductAdd.ImageList = ımageListButtons;
            btnProductAdd.Location = new Point(25, 404);
            btnProductAdd.Name = "btnProductAdd";
            btnProductAdd.Size = new Size(60, 67);
            btnProductAdd.TabIndex = 27;
            btnProductAdd.Text = "Ekle";
            btnProductAdd.TextAlign = ContentAlignment.BottomCenter;
            btnProductAdd.UseVisualStyleBackColor = false;
            // 
            // comboBoxProductCategory
            // 
            comboBoxProductCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProductCategory.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold);
            comboBoxProductCategory.FormattingEnabled = true;
            comboBoxProductCategory.Location = new Point(34, 219);
            comboBoxProductCategory.Name = "comboBoxProductCategory";
            comboBoxProductCategory.Size = new Size(237, 28);
            comboBoxProductCategory.TabIndex = 26;
            // 
            // txtProductPrice
            // 
            txtProductPrice.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtProductPrice.Location = new Point(34, 353);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(237, 27);
            txtProductPrice.TabIndex = 23;
            txtProductPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtProductName.Location = new Point(34, 288);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(237, 27);
            txtProductName.TabIndex = 22;
            txtProductName.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridViewProduct
            // 
            dataGridViewProduct.AllowUserToAddRows = false;
            dataGridViewProduct.AllowUserToDeleteRows = false;
            dataGridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduct.Location = new Point(306, 5);
            dataGridViewProduct.Name = "dataGridViewProduct";
            dataGridViewProduct.ReadOnly = true;
            dataGridViewProduct.Size = new Size(749, 536);
            dataGridViewProduct.TabIndex = 21;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.BackgroundImage = (Image)resources.GetObject("btnBack.BackgroundImage");
            btnBack.BackgroundImageLayout = ImageLayout.Zoom;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBack.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(1037, 576);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(46, 45);
            btnBack.TabIndex = 6;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 627);
            Controls.Add(btnBack);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HairdresserMS - Yönetim";
            tabControl1.ResumeLayout(false);
            tabPageSettings.ResumeLayout(false);
            tabPageSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            tabPageEmployee.ResumeLayout(false);
            tabPageEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployee).EndInit();
            tabPageChairs.ResumeLayout(false);
            tabPageChairs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChair).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewChair).EndInit();
            tabPageCategories.ResumeLayout(false);
            tabPageCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategory).EndInit();
            tabPageProducts.ResumeLayout(false);
            tabPageProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageSettings;
        private TabPage tabPageEmployee;
        private TabPage tabPageChairs;
        private TabPage tabPageCategories;
        private TabPage tabPageProducts;
        private Button btnBack;
        private Label lblPhone;
        private Label lblAuthority;
        private Label lblAddress;
        private Label lblName;
        private TextBox txtPhone;
        private TextBox txtAuthority;
        private TextBox txtAddress;
        private TextBox txtName;
        private Label lblTitle;
        private PictureBox pictureBoxLogo;
        private Button btnSave;
        private ImageList ımageListButtons;
        private Button btnEmployeeDelete;
        private Button btnEmployeeUpdate;
        private PictureBox pictureBoxEmployee;
        private Label lblEmployeePhone;
        private Label lblEmployeePassword;
        private Label lblEmployeeType;
        private Label lblEmployeeEmail;
        private Label lblEmployeeName;
        private Button btnEmployeeAdd;
        private ComboBox comboBoxEmployeeType;
        private TextBox txtEmployeePhone;
        private TextBox txtEmployeePassword;
        private TextBox txtEmployeeEmail;
        private TextBox txtEmployeeName;
        private DataGridView dataGridViewEmployee;
        private Button btnChairDelete;
        private Button btnChairUpdate;
        private PictureBox pictureBoxChair;
        private Label lblChairEmployee;
        private Label lblChairName;
        private Button btnChairAdd;
        private ComboBox comboBoxChairEmployee;
        private TextBox txtChairName;
        private DataGridView dataGridViewChair;
        private Button btnCategoryDelete;
        private Button btnCategoryUpdate;
        private PictureBox pictureBoxCategory;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label lblCategoryName;
        private Button button6;
        private ComboBox comboBox2;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox txtCategoryName;
        private DataGridView dataGridViewCategory;
        private Button btnProductDelete;
        private Button btnProductUpdate;
        private PictureBox pictureBoxProduct;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Button btnProductAdd;
        private ComboBox comboBoxProductCategory;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox txtProductPrice;
        private TextBox txtProductName;
        private DataGridView dataGridViewProduct;
        private Button btnCategoryAdd;
        private Label lblProductPrice;
        private Label lblProductName;
        private Label lblProductCategory;
    }
}