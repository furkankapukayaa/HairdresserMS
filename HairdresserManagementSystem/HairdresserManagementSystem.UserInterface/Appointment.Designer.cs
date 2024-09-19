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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointment));
            tabControl1 = new TabControl();
            tabPageAdd = new TabPage();
            tabPageList = new TabPage();
            btnBack = new Button();
            tabControl1.SuspendLayout();
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
            tabPageAdd.Location = new Point(4, 24);
            tabPageAdd.Name = "tabPageAdd";
            tabPageAdd.Padding = new Padding(3);
            tabPageAdd.Size = new Size(1089, 549);
            tabPageAdd.TabIndex = 0;
            tabPageAdd.Text = "Randevu Ekle";
            // 
            // tabPageList
            // 
            tabPageList.BackColor = SystemColors.Control;
            tabPageList.Location = new Point(4, 24);
            tabPageList.Name = "tabPageList";
            tabPageList.Padding = new Padding(3);
            tabPageList.Size = new Size(1086, 549);
            tabPageList.TabIndex = 1;
            tabPageList.Text = "Randevular";
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
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageAdd;
        private TabPage tabPageList;
        private Button btnBack;
    }
}