namespace HairdresserManagementSystem.UserInterface
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBoxLogin = new PictureBox();
            groupBoxLogin = new GroupBox();
            btnLogin = new Button();
            txtMail = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            lblMail = new Label();
            lblTitle = new Label();
            pictureBoxLogin2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).BeginInit();
            groupBoxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin2).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogin
            // 
            pictureBoxLogin.Image = (Image)resources.GetObject("pictureBoxLogin.Image");
            pictureBoxLogin.Location = new Point(220, 12);
            pictureBoxLogin.Name = "pictureBoxLogin";
            pictureBoxLogin.Size = new Size(224, 443);
            pictureBoxLogin.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogin.TabIndex = 0;
            pictureBoxLogin.TabStop = false;
            // 
            // groupBoxLogin
            // 
            groupBoxLogin.Controls.Add(btnLogin);
            groupBoxLogin.Controls.Add(txtMail);
            groupBoxLogin.Controls.Add(txtPassword);
            groupBoxLogin.Controls.Add(lblPassword);
            groupBoxLogin.Controls.Add(lblMail);
            groupBoxLogin.Font = new Font("Myriad Pro Light", 11.9999981F, FontStyle.Bold);
            groupBoxLogin.Location = new Point(474, 164);
            groupBoxLogin.Name = "groupBoxLogin";
            groupBoxLogin.Size = new Size(460, 219);
            groupBoxLogin.TabIndex = 1;
            groupBoxLogin.TabStop = false;
            groupBoxLogin.Text = "Giriş Yap";
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Location = new Point(324, 172);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(130, 41);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMail.Location = new Point(91, 68);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(198, 29);
            txtMail.TabIndex = 0;
            txtMail.Text = "admin@hairdresserms";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold);
            txtPassword.Location = new Point(91, 120);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(198, 29);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "a";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(41, 124);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(44, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Şifre:";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(43, 72);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(42, 20);
            lblMail.TabIndex = 2;
            lblMail.Text = "Mail:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Minion Pro", 23.9999962F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(551, 128);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(383, 44);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "HairdresserMS Hoş Geldiniz!";
            // 
            // pictureBoxLogin2
            // 
            pictureBoxLogin2.BackColor = Color.Transparent;
            pictureBoxLogin2.Image = (Image)resources.GetObject("pictureBoxLogin2.Image");
            pictureBoxLogin2.Location = new Point(2, 12);
            pictureBoxLogin2.Name = "pictureBoxLogin2";
            pictureBoxLogin2.Size = new Size(224, 443);
            pictureBoxLogin2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogin2.TabIndex = 3;
            pictureBoxLogin2.TabStop = false;
            // 
            // Login
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 485);
            Controls.Add(pictureBoxLogin2);
            Controls.Add(lblTitle);
            Controls.Add(groupBoxLogin);
            Controls.Add(pictureBoxLogin);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HairdresserMS - Giriş Yap";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).EndInit();
            groupBoxLogin.ResumeLayout(false);
            groupBoxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogin;
        private GroupBox groupBoxLogin;
        private Label lblPassword;
        private Label lblMail;
        private TextBox txtPassword;
        private TextBox txtMail;
        private Button btnLogin;
        private Label lblTitle;
        private PictureBox pictureBoxLogin2;
    }
}