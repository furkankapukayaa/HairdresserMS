namespace HairdresserManagementSystem.UserInterface
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            btnBack = new Button();
            btnCustomerDelete = new Button();
            ımageListButtons = new ImageList(components);
            btnCustomerUpdate = new Button();
            pictureBoxEmployee = new PictureBox();
            lblCustomerPhone = new Label();
            lblCustomerEmail = new Label();
            lblCustomerName = new Label();
            btnCustomerAdd = new Button();
            txtCustomerPhone = new TextBox();
            txtCustomerEmail = new TextBox();
            txtCustomerName = new TextBox();
            dataGridViewCustomer = new DataGridView();
            lblCustomerAddress = new Label();
            lblCustomerDescription = new Label();
            txtCustomerDescription = new TextBox();
            txtCustomerAddress = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).BeginInit();
            SuspendLayout();
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
            btnBack.Location = new Point(1037, 570);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(46, 45);
            btnBack.TabIndex = 7;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnCustomerDelete
            // 
            btnCustomerDelete.BackColor = SystemColors.Control;
            btnCustomerDelete.FlatAppearance.BorderSize = 0;
            btnCustomerDelete.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCustomerDelete.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCustomerDelete.FlatStyle = FlatStyle.Flat;
            btnCustomerDelete.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomerDelete.ImageAlign = ContentAlignment.TopCenter;
            btnCustomerDelete.ImageKey = "btnDelete.png";
            btnCustomerDelete.ImageList = ımageListButtons;
            btnCustomerDelete.Location = new Point(188, 539);
            btnCustomerDelete.Name = "btnCustomerDelete";
            btnCustomerDelete.Size = new Size(60, 70);
            btnCustomerDelete.TabIndex = 44;
            btnCustomerDelete.Text = "Sil";
            btnCustomerDelete.TextAlign = ContentAlignment.BottomCenter;
            btnCustomerDelete.UseVisualStyleBackColor = false;
            btnCustomerDelete.Click += btnCustomerDelete_Click;
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
            // btnCustomerUpdate
            // 
            btnCustomerUpdate.BackColor = SystemColors.Control;
            btnCustomerUpdate.FlatAppearance.BorderSize = 0;
            btnCustomerUpdate.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCustomerUpdate.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCustomerUpdate.FlatStyle = FlatStyle.Flat;
            btnCustomerUpdate.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomerUpdate.ImageAlign = ContentAlignment.TopCenter;
            btnCustomerUpdate.ImageKey = "btnUpdate.png";
            btnCustomerUpdate.ImageList = ımageListButtons;
            btnCustomerUpdate.Location = new Point(95, 539);
            btnCustomerUpdate.Name = "btnCustomerUpdate";
            btnCustomerUpdate.Size = new Size(70, 70);
            btnCustomerUpdate.TabIndex = 43;
            btnCustomerUpdate.Text = "Güncelle";
            btnCustomerUpdate.TextAlign = ContentAlignment.BottomCenter;
            btnCustomerUpdate.UseVisualStyleBackColor = false;
            btnCustomerUpdate.Click += btnCustomerUpdate_Click;
            // 
            // pictureBoxEmployee
            // 
            pictureBoxEmployee.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxEmployee.Image = (Image)resources.GetObject("pictureBoxEmployee.Image");
            pictureBoxEmployee.Location = new Point(46, 12);
            pictureBoxEmployee.Name = "pictureBoxEmployee";
            pictureBoxEmployee.Size = new Size(137, 100);
            pictureBoxEmployee.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxEmployee.TabIndex = 48;
            pictureBoxEmployee.TabStop = false;
            // 
            // lblCustomerPhone
            // 
            lblCustomerPhone.AutoSize = true;
            lblCustomerPhone.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblCustomerPhone.Location = new Point(13, 257);
            lblCustomerPhone.Name = "lblCustomerPhone";
            lblCustomerPhone.Size = new Size(71, 23);
            lblCustomerPhone.TabIndex = 47;
            lblCustomerPhone.Text = "Telefon";
            // 
            // lblCustomerEmail
            // 
            lblCustomerEmail.AutoSize = true;
            lblCustomerEmail.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblCustomerEmail.Location = new Point(13, 195);
            lblCustomerEmail.Name = "lblCustomerEmail";
            lblCustomerEmail.Size = new Size(58, 23);
            lblCustomerEmail.TabIndex = 44;
            lblCustomerEmail.Text = "Email";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblCustomerName.Location = new Point(13, 134);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(88, 23);
            lblCustomerName.TabIndex = 43;
            lblCustomerName.Text = "Ad Soyad";
            // 
            // btnCustomerAdd
            // 
            btnCustomerAdd.BackColor = SystemColors.Control;
            btnCustomerAdd.FlatAppearance.BorderSize = 0;
            btnCustomerAdd.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCustomerAdd.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCustomerAdd.FlatStyle = FlatStyle.Flat;
            btnCustomerAdd.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomerAdd.ImageAlign = ContentAlignment.TopCenter;
            btnCustomerAdd.ImageKey = "btnAdd.png";
            btnCustomerAdd.ImageList = ımageListButtons;
            btnCustomerAdd.Location = new Point(11, 539);
            btnCustomerAdd.Name = "btnCustomerAdd";
            btnCustomerAdd.Size = new Size(60, 67);
            btnCustomerAdd.TabIndex = 42;
            btnCustomerAdd.Text = "Ekle";
            btnCustomerAdd.TextAlign = ContentAlignment.BottomCenter;
            btnCustomerAdd.UseVisualStyleBackColor = false;
            btnCustomerAdd.Click += btnCustomerAdd_Click;
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCustomerPhone.Location = new Point(13, 283);
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.Size = new Size(237, 27);
            txtCustomerPhone.TabIndex = 39;
            txtCustomerPhone.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCustomerEmail
            // 
            txtCustomerEmail.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCustomerEmail.Location = new Point(13, 221);
            txtCustomerEmail.Name = "txtCustomerEmail";
            txtCustomerEmail.Size = new Size(237, 27);
            txtCustomerEmail.TabIndex = 38;
            txtCustomerEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCustomerName.Location = new Point(13, 160);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(237, 27);
            txtCustomerName.TabIndex = 37;
            txtCustomerName.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridViewCustomer
            // 
            dataGridViewCustomer.AllowUserToAddRows = false;
            dataGridViewCustomer.AllowUserToDeleteRows = false;
            dataGridViewCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomer.Location = new Point(269, 12);
            dataGridViewCustomer.Name = "dataGridViewCustomer";
            dataGridViewCustomer.ReadOnly = true;
            dataGridViewCustomer.Size = new Size(814, 552);
            dataGridViewCustomer.TabIndex = 36;
            dataGridViewCustomer.CellClick += dataGridViewCustomer_CellClick;
            // 
            // lblCustomerAddress
            // 
            lblCustomerAddress.AutoSize = true;
            lblCustomerAddress.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblCustomerAddress.Location = new Point(13, 317);
            lblCustomerAddress.Name = "lblCustomerAddress";
            lblCustomerAddress.Size = new Size(60, 23);
            lblCustomerAddress.TabIndex = 52;
            lblCustomerAddress.Text = "Adres";
            // 
            // lblCustomerDescription
            // 
            lblCustomerDescription.AutoSize = true;
            lblCustomerDescription.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblCustomerDescription.Location = new Point(13, 429);
            lblCustomerDescription.Name = "lblCustomerDescription";
            lblCustomerDescription.Size = new Size(88, 23);
            lblCustomerDescription.TabIndex = 54;
            lblCustomerDescription.Text = "Açıklama";
            // 
            // txtCustomerDescription
            // 
            txtCustomerDescription.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCustomerDescription.Location = new Point(11, 455);
            txtCustomerDescription.Multiline = true;
            txtCustomerDescription.Name = "txtCustomerDescription";
            txtCustomerDescription.Size = new Size(237, 78);
            txtCustomerDescription.TabIndex = 41;
            txtCustomerDescription.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCustomerAddress
            // 
            txtCustomerAddress.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCustomerAddress.Location = new Point(13, 343);
            txtCustomerAddress.Multiline = true;
            txtCustomerAddress.Name = "txtCustomerAddress";
            txtCustomerAddress.Size = new Size(237, 78);
            txtCustomerAddress.TabIndex = 40;
            txtCustomerAddress.TextAlign = HorizontalAlignment.Center;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 627);
            Controls.Add(txtCustomerAddress);
            Controls.Add(lblCustomerDescription);
            Controls.Add(txtCustomerDescription);
            Controls.Add(lblCustomerAddress);
            Controls.Add(btnCustomerDelete);
            Controls.Add(btnCustomerUpdate);
            Controls.Add(pictureBoxEmployee);
            Controls.Add(lblCustomerPhone);
            Controls.Add(lblCustomerEmail);
            Controls.Add(lblCustomerName);
            Controls.Add(btnCustomerAdd);
            Controls.Add(txtCustomerPhone);
            Controls.Add(txtCustomerEmail);
            Controls.Add(txtCustomerName);
            Controls.Add(dataGridViewCustomer);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HairdresserMS - Müşteriler";
            ((System.ComponentModel.ISupportInitialize)pictureBoxEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnCustomerDelete;
        private ImageList ımageListButtons;
        private Button btnCustomerUpdate;
        private PictureBox pictureBoxEmployee;
        private Label lblCustomerPhone;
        private Label lblCustomerEmail;
        private Label lblCustomerName;
        private Button btnCustomerAdd;
        private TextBox txtCustomerPhone;
        private TextBox txtCustomerEmail;
        private TextBox txtCustomerName;
        private DataGridView dataGridViewCustomer;
        private Label lblCustomerAddress;
        private Label lblCustomerDescription;
        private TextBox txtCustomerDescription;
        private TextBox txtCustomerAddress;
    }
}