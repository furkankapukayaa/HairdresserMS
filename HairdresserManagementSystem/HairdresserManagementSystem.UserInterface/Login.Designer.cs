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
            LoginPictureBox = new PictureBox();
            loginGroupBox = new GroupBox();
            LoginButton = new Button();
            MailTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            PasswordLabel = new Label();
            MailLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)LoginPictureBox).BeginInit();
            loginGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // LoginPictureBox
            // 
            LoginPictureBox.Image = (Image)resources.GetObject("LoginPictureBox.Image");
            LoginPictureBox.Location = new Point(12, 116);
            LoginPictureBox.Name = "LoginPictureBox";
            LoginPictureBox.Size = new Size(503, 398);
            LoginPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            LoginPictureBox.TabIndex = 0;
            LoginPictureBox.TabStop = false;
            // 
            // loginGroupBox
            // 
            loginGroupBox.Controls.Add(LoginButton);
            loginGroupBox.Controls.Add(MailTextBox);
            loginGroupBox.Controls.Add(PasswordTextBox);
            loginGroupBox.Controls.Add(PasswordLabel);
            loginGroupBox.Controls.Add(MailLabel);
            loginGroupBox.Font = new Font("Myriad Pro Light", 11.9999981F, FontStyle.Bold);
            loginGroupBox.Location = new Point(560, 222);
            loginGroupBox.Name = "loginGroupBox";
            loginGroupBox.Size = new Size(460, 219);
            loginGroupBox.TabIndex = 1;
            loginGroupBox.TabStop = false;
            loginGroupBox.Text = "Giriş Yap";
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(324, 172);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(130, 41);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Giriş Yap";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // MailTextBox
            // 
            MailTextBox.Location = new Point(91, 72);
            MailTextBox.Name = "MailTextBox";
            MailTextBox.Size = new Size(198, 27);
            MailTextBox.TabIndex = 0;
            MailTextBox.Text = "admin@hairdresserms";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(91, 124);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(198, 27);
            PasswordTextBox.TabIndex = 1;
            PasswordTextBox.Text = "a";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(41, 124);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(44, 20);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Şifre:";
            // 
            // MailLabel
            // 
            MailLabel.AutoSize = true;
            MailLabel.Location = new Point(43, 72);
            MailLabel.Name = "MailLabel";
            MailLabel.Size = new Size(42, 20);
            MailLabel.TabIndex = 2;
            MailLabel.Text = "Mail:";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 627);
            Controls.Add(loginGroupBox);
            Controls.Add(LoginPictureBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)LoginPictureBox).EndInit();
            loginGroupBox.ResumeLayout(false);
            loginGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox LoginPictureBox;
        private GroupBox loginGroupBox;
        private Label PasswordLabel;
        private Label MailLabel;
        private TextBox PasswordTextBox;
        private TextBox MailTextBox;
        private Button LoginButton;
    }
}