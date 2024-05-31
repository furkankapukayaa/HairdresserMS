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
            tabPage1 = new TabPage();
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
            tabPage2 = new TabPage();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnEmployeeDelete = new Button();
            btnEmployeeUpdate = new Button();
            btnEmployeeSave = new Button();
            comboBoxEmployeeType = new ComboBox();
            txtEmployeePhone = new TextBox();
            txtEmployeePassword = new TextBox();
            txtEmployeeEmail = new TextBox();
            txtEmployeeName = new TextBox();
            dataGridViewEmployee = new DataGridView();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            btnBack = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployee).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(0, -2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1097, 576);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Control;
            tabPage1.Controls.Add(btnSave);
            tabPage1.Controls.Add(lblTitle);
            tabPage1.Controls.Add(pictureBoxLogo);
            tabPage1.Controls.Add(txtPhone);
            tabPage1.Controls.Add(txtAuthority);
            tabPage1.Controls.Add(txtAddress);
            tabPage1.Controls.Add(txtName);
            tabPage1.Controls.Add(lblPhone);
            tabPage1.Controls.Add(lblAuthority);
            tabPage1.Controls.Add(lblAddress);
            tabPage1.Controls.Add(lblName);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1089, 548);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Genel Ayarlar";
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
            btnSave.ImageKey = "btnUpdate.png";
            btnSave.ImageList = ımageListButtons;
            btnSave.Location = new Point(492, 442);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 95);
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
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Control;
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(btnEmployeeDelete);
            tabPage2.Controls.Add(btnEmployeeUpdate);
            tabPage2.Controls.Add(btnEmployeeSave);
            tabPage2.Controls.Add(comboBoxEmployeeType);
            tabPage2.Controls.Add(txtEmployeePhone);
            tabPage2.Controls.Add(txtEmployeePassword);
            tabPage2.Controls.Add(txtEmployeeEmail);
            tabPage2.Controls.Add(txtEmployeeName);
            tabPage2.Controls.Add(dataGridViewEmployee);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1089, 548);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Personeller";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(400, 96);
            label5.Name = "label5";
            label5.Size = new Size(71, 23);
            label5.TabIndex = 17;
            label5.Text = "Telefon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(420, 26);
            label4.Name = "label4";
            label4.Size = new Size(51, 23);
            label4.TabIndex = 16;
            label4.Text = "Şifre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(421, 165);
            label3.Name = "label3";
            label3.Size = new Size(50, 23);
            label3.TabIndex = 16;
            label3.Text = "Yetki";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(25, 133);
            label2.Name = "label2";
            label2.Size = new Size(58, 23);
            label2.TabIndex = 15;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(13, 63);
            label1.Name = "label1";
            label1.Size = new Size(88, 23);
            label1.TabIndex = 14;
            label1.Text = "Ad Soyad";
            // 
            // btnEmployeeDelete
            // 
            btnEmployeeDelete.Location = new Point(857, 114);
            btnEmployeeDelete.Name = "btnEmployeeDelete";
            btnEmployeeDelete.Size = new Size(129, 45);
            btnEmployeeDelete.TabIndex = 13;
            btnEmployeeDelete.Text = "Sil";
            btnEmployeeDelete.UseVisualStyleBackColor = true;
            // 
            // btnEmployeeUpdate
            // 
            btnEmployeeUpdate.Location = new Point(920, 63);
            btnEmployeeUpdate.Name = "btnEmployeeUpdate";
            btnEmployeeUpdate.Size = new Size(129, 45);
            btnEmployeeUpdate.TabIndex = 12;
            btnEmployeeUpdate.Text = "Güncelle";
            btnEmployeeUpdate.UseVisualStyleBackColor = true;
            // 
            // btnEmployeeSave
            // 
            btnEmployeeSave.Location = new Point(785, 63);
            btnEmployeeSave.Name = "btnEmployeeSave";
            btnEmployeeSave.Size = new Size(129, 45);
            btnEmployeeSave.TabIndex = 11;
            btnEmployeeSave.Text = "Kaydet";
            btnEmployeeSave.UseVisualStyleBackColor = true;
            // 
            // comboBoxEmployeeType
            // 
            comboBoxEmployeeType.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold);
            comboBoxEmployeeType.FormattingEnabled = true;
            comboBoxEmployeeType.Location = new Point(477, 165);
            comboBoxEmployeeType.Name = "comboBoxEmployeeType";
            comboBoxEmployeeType.Size = new Size(237, 28);
            comboBoxEmployeeType.TabIndex = 9;
            // 
            // txtEmployeePhone
            // 
            txtEmployeePhone.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmployeePhone.Location = new Point(477, 92);
            txtEmployeePhone.Name = "txtEmployeePhone";
            txtEmployeePhone.Size = new Size(237, 27);
            txtEmployeePhone.TabIndex = 8;
            txtEmployeePhone.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEmployeePassword
            // 
            txtEmployeePassword.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmployeePassword.Location = new Point(477, 26);
            txtEmployeePassword.Name = "txtEmployeePassword";
            txtEmployeePassword.Size = new Size(237, 27);
            txtEmployeePassword.TabIndex = 7;
            txtEmployeePassword.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEmployeeEmail
            // 
            txtEmployeeEmail.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmployeeEmail.Location = new Point(107, 129);
            txtEmployeeEmail.Name = "txtEmployeeEmail";
            txtEmployeeEmail.Size = new Size(237, 27);
            txtEmployeeEmail.TabIndex = 6;
            txtEmployeeEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmployeeName.Location = new Point(107, 63);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(237, 27);
            txtEmployeeName.TabIndex = 5;
            txtEmployeeName.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridViewEmployee
            // 
            dataGridViewEmployee.AllowUserToAddRows = false;
            dataGridViewEmployee.AllowUserToDeleteRows = false;
            dataGridViewEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployee.Location = new Point(6, 225);
            dataGridViewEmployee.Name = "dataGridViewEmployee";
            dataGridViewEmployee.ReadOnly = true;
            dataGridViewEmployee.Size = new Size(1073, 317);
            dataGridViewEmployee.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1089, 548);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Koltuklar";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = SystemColors.Control;
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1089, 548);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Kategoriler";
            // 
            // tabPage5
            // 
            tabPage5.BackColor = SystemColors.Control;
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1089, 548);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Ürün/Hizmetler";
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
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployee).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
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
        private DataGridView dataGridViewEmployee;
        private ComboBox comboBoxEmployeeType;
        private TextBox txtEmployeePhone;
        private TextBox txtEmployeePassword;
        private TextBox txtEmployeeEmail;
        private TextBox txtEmployeeName;
        private Button btnEmployeeDelete;
        private Button btnEmployeeUpdate;
        private Button btnEmployeeSave;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ImageList ımageListButtons;
    }
}