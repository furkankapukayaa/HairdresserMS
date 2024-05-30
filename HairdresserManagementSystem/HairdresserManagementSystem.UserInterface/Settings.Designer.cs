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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnSave = new Button();
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
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            btnBack = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
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
            btnSave.Location = new Point(498, 484);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(129, 45);
            btnSave.TabIndex = 10;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold);
            lblTitle.Location = new Point(505, 93);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(108, 20);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "HairdresserMS";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(510, 6);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(93, 84);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 8;
            pictureBoxLogo.TabStop = false;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(432, 367);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(276, 23);
            txtPhone.TabIndex = 6;
            // 
            // txtAuthority
            // 
            txtAuthority.Location = new Point(427, 443);
            txtAuthority.Name = "txtAuthority";
            txtAuthority.Size = new Size(281, 23);
            txtAuthority.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(432, 225);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(276, 92);
            txtAddress.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(432, 162);
            txtName.Name = "txtName";
            txtName.Size = new Size(276, 23);
            txtName.TabIndex = 4;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblPhone.Location = new Point(498, 341);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(123, 23);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "İşyeri Telefon";
            // 
            // lblAuthority
            // 
            lblAuthority.AutoSize = true;
            lblAuthority.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblAuthority.Location = new Point(488, 417);
            lblAuthority.Name = "lblAuthority";
            lblAuthority.Size = new Size(128, 23);
            lblAuthority.TabIndex = 2;
            lblAuthority.Text = "İşyeri Yetkilisi";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblAddress.Location = new Point(498, 199);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(117, 23);
            lblAddress.TabIndex = 1;
            lblAddress.Text = "İşyeri Adresi";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblName.Location = new Point(514, 136);
            lblName.Name = "lblName";
            lblName.Size = new Size(89, 23);
            lblName.TabIndex = 0;
            lblName.Text = "İşyeri Adı";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Control;
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1089, 548);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Personeller";
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
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(1035, 576);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(48, 48);
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
    }
}