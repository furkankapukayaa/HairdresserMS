namespace HairdresserManagementSystem.UserInterface
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            btnChairs = new Button();
            imageListButtons = new ImageList(components);
            btnAppointments = new Button();
            btnOrders = new Button();
            btnCustomers = new Button();
            btnSettings = new Button();
            btnLogout = new Button();
            pictureBoxLogo = new PictureBox();
            lblTitle = new Label();
            lblCalendar = new Label();
            timerCalendar = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // btnChairs
            // 
            btnChairs.Cursor = Cursors.Hand;
            btnChairs.FlatAppearance.BorderSize = 0;
            btnChairs.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnChairs.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnChairs.FlatStyle = FlatStyle.Flat;
            btnChairs.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnChairs.ImageAlign = ContentAlignment.TopCenter;
            btnChairs.ImageKey = "chair.png";
            btnChairs.ImageList = imageListButtons;
            btnChairs.Location = new Point(12, 215);
            btnChairs.Name = "btnChairs";
            btnChairs.Size = new Size(154, 154);
            btnChairs.TabIndex = 0;
            btnChairs.Text = "Koltuklar";
            btnChairs.TextAlign = ContentAlignment.BottomCenter;
            btnChairs.UseVisualStyleBackColor = false;
            btnChairs.Click += btnChairs_Click;
            // 
            // imageListButtons
            // 
            imageListButtons.ColorDepth = ColorDepth.Depth32Bit;
            imageListButtons.ImageStream = (ImageListStreamer)resources.GetObject("imageListButtons.ImageStream");
            imageListButtons.TransparentColor = Color.Transparent;
            imageListButtons.Images.SetKeyName(0, "appointment.png");
            imageListButtons.Images.SetKeyName(1, "chair.png");
            imageListButtons.Images.SetKeyName(2, "customers.png");
            imageListButtons.Images.SetKeyName(3, "orders.png");
            imageListButtons.Images.SetKeyName(4, "settings.png");
            // 
            // btnAppointments
            // 
            btnAppointments.Cursor = Cursors.Hand;
            btnAppointments.FlatAppearance.BorderSize = 0;
            btnAppointments.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAppointments.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAppointments.FlatStyle = FlatStyle.Flat;
            btnAppointments.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnAppointments.ImageAlign = ContentAlignment.TopCenter;
            btnAppointments.ImageKey = "appointment.png";
            btnAppointments.ImageList = imageListButtons;
            btnAppointments.Location = new Point(227, 215);
            btnAppointments.Name = "btnAppointments";
            btnAppointments.Size = new Size(154, 154);
            btnAppointments.TabIndex = 1;
            btnAppointments.Text = "Randevular";
            btnAppointments.TextAlign = ContentAlignment.BottomCenter;
            btnAppointments.UseVisualStyleBackColor = false;
            btnAppointments.Click += btnAppointments_Click;
            // 
            // btnOrders
            // 
            btnOrders.Cursor = Cursors.Hand;
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnOrders.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnOrders.ImageAlign = ContentAlignment.TopCenter;
            btnOrders.ImageKey = "orders.png";
            btnOrders.ImageList = imageListButtons;
            btnOrders.Location = new Point(458, 215);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(154, 154);
            btnOrders.TabIndex = 2;
            btnOrders.Text = "Kasa";
            btnOrders.TextAlign = ContentAlignment.BottomCenter;
            btnOrders.UseVisualStyleBackColor = false;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.Cursor = Cursors.Hand;
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCustomers.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnCustomers.ImageAlign = ContentAlignment.TopCenter;
            btnCustomers.ImageKey = "customers.png";
            btnCustomers.ImageList = imageListButtons;
            btnCustomers.Location = new Point(690, 215);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(154, 154);
            btnCustomers.TabIndex = 3;
            btnCustomers.Text = "Müşteriler";
            btnCustomers.TextAlign = ContentAlignment.BottomCenter;
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnSettings
            // 
            btnSettings.Cursor = Cursors.Hand;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSettings.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnSettings.ImageAlign = ContentAlignment.TopCenter;
            btnSettings.ImageKey = "settings.png";
            btnSettings.ImageList = imageListButtons;
            btnSettings.Location = new Point(929, 215);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(154, 154);
            btnSettings.TabIndex = 4;
            btnSettings.Text = "Yönetim";
            btnSettings.TextAlign = ContentAlignment.BottomCenter;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.BackgroundImage = (Image)resources.GetObject("btnLogout.BackgroundImage");
            btnLogout.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(1027, 560);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(56, 55);
            btnLogout.TabIndex = 5;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(987, 12);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(77, 64);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 6;
            pictureBoxLogo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold);
            lblTitle.Location = new Point(972, 79);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(108, 20);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "HairdresserMS";
            // 
            // lblCalendar
            // 
            lblCalendar.AutoSize = true;
            lblCalendar.Font = new Font("Myriad Pro Light", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCalendar.Location = new Point(16, 18);
            lblCalendar.Name = "lblCalendar";
            lblCalendar.Size = new Size(123, 26);
            lblCalendar.TabIndex = 8;
            lblCalendar.Text = "yükleniyor...";
            lblCalendar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timerCalendar
            // 
            timerCalendar.Tick += timerCalendar_Tick;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 627);
            Controls.Add(lblCalendar);
            Controls.Add(lblTitle);
            Controls.Add(pictureBoxLogo);
            Controls.Add(btnLogout);
            Controls.Add(btnSettings);
            Controls.Add(btnCustomers);
            Controls.Add(btnOrders);
            Controls.Add(btnAppointments);
            Controls.Add(btnChairs);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HairdresserMS";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChairs;
        private Button btnAppointments;
        private Button btnOrders;
        private Button btnCustomers;
        private Button btnSettings;
        private ImageList imageListButtons;
        private Button btnLogout;
        private PictureBox pictureBoxLogo;
        private Label lblTitle;
        private Label lblCalendar;
        private System.Windows.Forms.Timer timerCalendar;
    }
}