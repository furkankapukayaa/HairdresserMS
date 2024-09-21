namespace HairdresserManagementSystem.UserInterface
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            btnBack = new Button();
            dataGridViewOrder = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).BeginInit();
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
            btnBack.TabIndex = 8;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // dataGridViewOrder
            // 
            dataGridViewOrder.AllowUserToAddRows = false;
            dataGridViewOrder.AllowUserToDeleteRows = false;
            dataGridViewOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrder.Location = new Point(12, 12);
            dataGridViewOrder.Name = "dataGridViewOrder";
            dataGridViewOrder.ReadOnly = true;
            dataGridViewOrder.Size = new Size(1071, 552);
            dataGridViewOrder.TabIndex = 38;
            dataGridViewOrder.CellFormatting += dataGridViewOrder_CellFormatting;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 627);
            Controls.Add(dataGridViewOrder);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Order";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HairdresserMS - Kasa";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private DataGridView dataGridViewOrder;
    }
}