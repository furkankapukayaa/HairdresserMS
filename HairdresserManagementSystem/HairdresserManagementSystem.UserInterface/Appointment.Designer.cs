namespace HairdresserManagementSystem.UserInterface
{
    partial class Appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointment));
            tabControl1 = new TabControl();
            tabPageAdd = new TabPage();
            btnAppointmentAdd = new Button();
            ımageListButtons = new ImageList(components);
            label2 = new Label();
            label1 = new Label();
            pictureBoxEmployee = new PictureBox();
            txtAppointmentAmount = new TextBox();
            lblAppointmentAmount = new Label();
            listBoxAppointmentSelectedProducts = new ListBox();
            listBoxAppointmentProducts = new ListBox();
            lblAppointmentTime = new Label();
            dateTimePickerAppointmentTime = new DateTimePicker();
            dateTimePickerAppointmentDate = new DateTimePicker();
            lblAppointmentCustomer = new Label();
            comboBoxAppointmentCustomer = new ComboBox();
            lblAppointmentEmployee = new Label();
            lblAppointmentDescription = new Label();
            txtAppointmentDescription = new TextBox();
            comboBoxAppointmentEmployee = new ComboBox();
            tabPageList = new TabPage();
            btnAppointmentDelete = new Button();
            btnAppointmentCancel = new Button();
            dataGridViewAppointment = new DataGridView();
            btnBack = new Button();
            tabControl1.SuspendLayout();
            tabPageAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEmployee).BeginInit();
            tabPageList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointment).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageAdd);
            tabControl1.Controls.Add(tabPageList);
            tabControl1.Location = new Point(-1, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1097, 577);
            tabControl1.TabIndex = 0;
            // 
            // tabPageAdd
            // 
            tabPageAdd.BackColor = SystemColors.Control;
            tabPageAdd.Controls.Add(btnAppointmentAdd);
            tabPageAdd.Controls.Add(label2);
            tabPageAdd.Controls.Add(label1);
            tabPageAdd.Controls.Add(pictureBoxEmployee);
            tabPageAdd.Controls.Add(txtAppointmentAmount);
            tabPageAdd.Controls.Add(lblAppointmentAmount);
            tabPageAdd.Controls.Add(listBoxAppointmentSelectedProducts);
            tabPageAdd.Controls.Add(listBoxAppointmentProducts);
            tabPageAdd.Controls.Add(lblAppointmentTime);
            tabPageAdd.Controls.Add(dateTimePickerAppointmentTime);
            tabPageAdd.Controls.Add(dateTimePickerAppointmentDate);
            tabPageAdd.Controls.Add(lblAppointmentCustomer);
            tabPageAdd.Controls.Add(comboBoxAppointmentCustomer);
            tabPageAdd.Controls.Add(lblAppointmentEmployee);
            tabPageAdd.Controls.Add(lblAppointmentDescription);
            tabPageAdd.Controls.Add(txtAppointmentDescription);
            tabPageAdd.Controls.Add(comboBoxAppointmentEmployee);
            tabPageAdd.Location = new Point(4, 24);
            tabPageAdd.Name = "tabPageAdd";
            tabPageAdd.Padding = new Padding(3);
            tabPageAdd.Size = new Size(1089, 549);
            tabPageAdd.TabIndex = 0;
            tabPageAdd.Text = "Randevu Ekle";
            // 
            // btnAppointmentAdd
            // 
            btnAppointmentAdd.BackColor = SystemColors.Control;
            btnAppointmentAdd.FlatAppearance.BorderSize = 0;
            btnAppointmentAdd.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAppointmentAdd.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAppointmentAdd.FlatStyle = FlatStyle.Flat;
            btnAppointmentAdd.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAppointmentAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAppointmentAdd.ImageKey = "btnAdd.png";
            btnAppointmentAdd.ImageList = ımageListButtons;
            btnAppointmentAdd.Location = new Point(80, 474);
            btnAppointmentAdd.Name = "btnAppointmentAdd";
            btnAppointmentAdd.Size = new Size(177, 46);
            btnAppointmentAdd.TabIndex = 52;
            btnAppointmentAdd.Text = "Randevuyu Kaydet";
            btnAppointmentAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAppointmentAdd.UseVisualStyleBackColor = false;
            btnAppointmentAdd.Click += btnAppointmentAdd_Click;
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
            ımageListButtons.Images.SetKeyName(5, "btnCancel.png");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(626, 132);
            label2.Name = "label2";
            label2.Size = new Size(186, 23);
            label2.TabIndex = 51;
            label2.Text = "İstenen Ürün/Hizmet";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(434, 132);
            label1.Name = "label1";
            label1.Size = new Size(118, 23);
            label1.TabIndex = 50;
            label1.Text = "Ürün/Hizmet";
            // 
            // pictureBoxEmployee
            // 
            pictureBoxEmployee.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxEmployee.Image = (Image)resources.GetObject("pictureBoxEmployee.Image");
            pictureBoxEmployee.Location = new Point(472, 17);
            pictureBoxEmployee.Name = "pictureBoxEmployee";
            pictureBoxEmployee.Size = new Size(120, 94);
            pictureBoxEmployee.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxEmployee.TabIndex = 49;
            pictureBoxEmployee.TabStop = false;
            // 
            // txtAppointmentAmount
            // 
            txtAppointmentAmount.Enabled = false;
            txtAppointmentAmount.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold);
            txtAppointmentAmount.Location = new Point(880, 495);
            txtAppointmentAmount.Name = "txtAppointmentAmount";
            txtAppointmentAmount.Size = new Size(100, 27);
            txtAppointmentAmount.TabIndex = 44;
            // 
            // lblAppointmentAmount
            // 
            lblAppointmentAmount.AutoSize = true;
            lblAppointmentAmount.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblAppointmentAmount.Location = new Point(804, 497);
            lblAppointmentAmount.Name = "lblAppointmentAmount";
            lblAppointmentAmount.Size = new Size(70, 23);
            lblAppointmentAmount.TabIndex = 43;
            lblAppointmentAmount.Text = "Toplam";
            // 
            // listBoxAppointmentSelectedProducts
            // 
            listBoxAppointmentSelectedProducts.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold);
            listBoxAppointmentSelectedProducts.FormattingEnabled = true;
            listBoxAppointmentSelectedProducts.ItemHeight = 20;
            listBoxAppointmentSelectedProducts.Location = new Point(626, 158);
            listBoxAppointmentSelectedProducts.Name = "listBoxAppointmentSelectedProducts";
            listBoxAppointmentSelectedProducts.Size = new Size(172, 364);
            listBoxAppointmentSelectedProducts.TabIndex = 42;
            listBoxAppointmentSelectedProducts.DoubleClick += listBoxAppointmentSelectedProducts_DoubleClick;
            // 
            // listBoxAppointmentProducts
            // 
            listBoxAppointmentProducts.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold);
            listBoxAppointmentProducts.FormattingEnabled = true;
            listBoxAppointmentProducts.ItemHeight = 20;
            listBoxAppointmentProducts.Location = new Point(434, 158);
            listBoxAppointmentProducts.Name = "listBoxAppointmentProducts";
            listBoxAppointmentProducts.Size = new Size(172, 364);
            listBoxAppointmentProducts.TabIndex = 41;
            listBoxAppointmentProducts.DoubleClick += listBoxAppointmentProducts_DoubleClick;
            // 
            // lblAppointmentTime
            // 
            lblAppointmentTime.AutoSize = true;
            lblAppointmentTime.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblAppointmentTime.Location = new Point(57, 359);
            lblAppointmentTime.Name = "lblAppointmentTime";
            lblAppointmentTime.Size = new Size(120, 23);
            lblAppointmentTime.TabIndex = 40;
            lblAppointmentTime.Text = "Tarih ve Saat";
            // 
            // dateTimePickerAppointmentTime
            // 
            dateTimePickerAppointmentTime.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold);
            dateTimePickerAppointmentTime.Format = DateTimePickerFormat.Time;
            dateTimePickerAppointmentTime.Location = new Point(121, 418);
            dateTimePickerAppointmentTime.Name = "dateTimePickerAppointmentTime";
            dateTimePickerAppointmentTime.ShowUpDown = true;
            dateTimePickerAppointmentTime.Size = new Size(86, 27);
            dateTimePickerAppointmentTime.TabIndex = 39;
            // 
            // dateTimePickerAppointmentDate
            // 
            dateTimePickerAppointmentDate.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold);
            dateTimePickerAppointmentDate.Location = new Point(57, 385);
            dateTimePickerAppointmentDate.Name = "dateTimePickerAppointmentDate";
            dateTimePickerAppointmentDate.Size = new Size(246, 27);
            dateTimePickerAppointmentDate.TabIndex = 38;
            // 
            // lblAppointmentCustomer
            // 
            lblAppointmentCustomer.AutoSize = true;
            lblAppointmentCustomer.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblAppointmentCustomer.Location = new Point(57, 136);
            lblAppointmentCustomer.Name = "lblAppointmentCustomer";
            lblAppointmentCustomer.Size = new Size(75, 23);
            lblAppointmentCustomer.TabIndex = 37;
            lblAppointmentCustomer.Text = "Müşteri";
            // 
            // comboBoxAppointmentCustomer
            // 
            comboBoxAppointmentCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAppointmentCustomer.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold);
            comboBoxAppointmentCustomer.FormattingEnabled = true;
            comboBoxAppointmentCustomer.Location = new Point(57, 162);
            comboBoxAppointmentCustomer.Name = "comboBoxAppointmentCustomer";
            comboBoxAppointmentCustomer.Size = new Size(237, 28);
            comboBoxAppointmentCustomer.TabIndex = 36;
            // 
            // lblAppointmentEmployee
            // 
            lblAppointmentEmployee.AutoSize = true;
            lblAppointmentEmployee.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblAppointmentEmployee.Location = new Point(57, 67);
            lblAppointmentEmployee.Name = "lblAppointmentEmployee";
            lblAppointmentEmployee.Size = new Size(86, 23);
            lblAppointmentEmployee.TabIndex = 35;
            lblAppointmentEmployee.Text = "Personel";
            // 
            // lblAppointmentDescription
            // 
            lblAppointmentDescription.AutoSize = true;
            lblAppointmentDescription.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblAppointmentDescription.Location = new Point(57, 204);
            lblAppointmentDescription.Name = "lblAppointmentDescription";
            lblAppointmentDescription.Size = new Size(39, 23);
            lblAppointmentDescription.TabIndex = 34;
            lblAppointmentDescription.Text = "Not";
            // 
            // txtAppointmentDescription
            // 
            txtAppointmentDescription.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAppointmentDescription.Location = new Point(57, 232);
            txtAppointmentDescription.Multiline = true;
            txtAppointmentDescription.Name = "txtAppointmentDescription";
            txtAppointmentDescription.Size = new Size(248, 105);
            txtAppointmentDescription.TabIndex = 32;
            txtAppointmentDescription.TextAlign = HorizontalAlignment.Center;
            // 
            // comboBoxAppointmentEmployee
            // 
            comboBoxAppointmentEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAppointmentEmployee.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold);
            comboBoxAppointmentEmployee.FormattingEnabled = true;
            comboBoxAppointmentEmployee.Location = new Point(57, 93);
            comboBoxAppointmentEmployee.Name = "comboBoxAppointmentEmployee";
            comboBoxAppointmentEmployee.Size = new Size(237, 28);
            comboBoxAppointmentEmployee.TabIndex = 33;
            // 
            // tabPageList
            // 
            tabPageList.BackColor = SystemColors.Control;
            tabPageList.Controls.Add(btnAppointmentDelete);
            tabPageList.Controls.Add(btnAppointmentCancel);
            tabPageList.Controls.Add(dataGridViewAppointment);
            tabPageList.Location = new Point(4, 24);
            tabPageList.Name = "tabPageList";
            tabPageList.Padding = new Padding(3);
            tabPageList.Size = new Size(1089, 549);
            tabPageList.TabIndex = 1;
            tabPageList.Text = "Randevular";
            // 
            // btnAppointmentDelete
            // 
            btnAppointmentDelete.BackColor = SystemColors.Control;
            btnAppointmentDelete.FlatAppearance.BorderSize = 0;
            btnAppointmentDelete.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAppointmentDelete.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAppointmentDelete.FlatStyle = FlatStyle.Flat;
            btnAppointmentDelete.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAppointmentDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnAppointmentDelete.ImageKey = "btnDelete.png";
            btnAppointmentDelete.ImageList = ımageListButtons;
            btnAppointmentDelete.Location = new Point(559, 500);
            btnAppointmentDelete.Name = "btnAppointmentDelete";
            btnAppointmentDelete.Size = new Size(152, 46);
            btnAppointmentDelete.TabIndex = 54;
            btnAppointmentDelete.Text = "Randevuyu Sil";
            btnAppointmentDelete.TextAlign = ContentAlignment.MiddleRight;
            btnAppointmentDelete.UseVisualStyleBackColor = false;
            btnAppointmentDelete.Click += btnAppointmentDelete_Click;
            // 
            // btnAppointmentCancel
            // 
            btnAppointmentCancel.BackColor = SystemColors.Control;
            btnAppointmentCancel.FlatAppearance.BorderSize = 0;
            btnAppointmentCancel.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAppointmentCancel.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAppointmentCancel.FlatStyle = FlatStyle.Flat;
            btnAppointmentCancel.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAppointmentCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnAppointmentCancel.ImageKey = "btnCancel.png";
            btnAppointmentCancel.ImageList = ımageListButtons;
            btnAppointmentCancel.Location = new Point(367, 499);
            btnAppointmentCancel.Name = "btnAppointmentCancel";
            btnAppointmentCancel.Size = new Size(186, 46);
            btnAppointmentCancel.TabIndex = 53;
            btnAppointmentCancel.Text = "Randevuyu İptal Et ";
            btnAppointmentCancel.TextAlign = ContentAlignment.MiddleRight;
            btnAppointmentCancel.UseVisualStyleBackColor = false;
            btnAppointmentCancel.Click += btnAppointmentCancel_Click;
            // 
            // dataGridViewAppointment
            // 
            dataGridViewAppointment.AllowUserToAddRows = false;
            dataGridViewAppointment.AllowUserToDeleteRows = false;
            dataGridViewAppointment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAppointment.Location = new Point(9, 6);
            dataGridViewAppointment.Name = "dataGridViewAppointment";
            dataGridViewAppointment.ReadOnly = true;
            dataGridViewAppointment.Size = new Size(1074, 492);
            dataGridViewAppointment.TabIndex = 37;
            dataGridViewAppointment.CellClick += dataGridViewAppointment_CellClick;
            dataGridViewAppointment.CellFormatting += dataGridViewAppointment_CellFormatting;
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
            btnBack.Location = new Point(1037, 578);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(46, 45);
            btnBack.TabIndex = 7;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // Appointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 627);
            Controls.Add(btnBack);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Appointment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HairdresserMS - Randevular";
            tabControl1.ResumeLayout(false);
            tabPageAdd.ResumeLayout(false);
            tabPageAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEmployee).EndInit();
            tabPageList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointment).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageAdd;
        private TabPage tabPageList;
        private Button btnBack;
        private DateTimePicker dateTimePickerAppointmentTime;
        private DateTimePicker dateTimePickerAppointmentDate;
        private Label lblAppointmentCustomer;
        private ComboBox comboBoxAppointmentCustomer;
        private Label lblAppointmentEmployee;
        private Label lblAppointmentDescription;
        private TextBox txtAppointmentDescription;
        private ComboBox comboBoxAppointmentEmployee;
        private Label lblAppointmentTime;
        private TextBox txtAppointmentAmount;
        private Label lblAppointmentAmount;
        private ListBox listBoxAppointmentSelectedProducts;
        private ListBox listBoxAppointmentProducts;
        private PictureBox pictureBoxEmployee;
        private Label label2;
        private Label label1;
        private DataGridView dataGridViewAppointment;
        private Button btnAppointmentAdd;
        private ImageList ımageListButtons;
        private Button btnAppointmentCancel;
        private Button btnAppointmentDelete;
    }
}