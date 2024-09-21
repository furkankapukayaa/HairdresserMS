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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            btnBack = new Button();
            dataGridViewOrder = new DataGridView();
            ımageListButtons = new ImageList(components);
            lblOrderTotalAmount = new Label();
            btnCustomerDelete = new Button();
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
            dataGridViewOrder.CellClick += dataGridViewOrder_CellClick;
            dataGridViewOrder.CellFormatting += dataGridViewOrder_CellFormatting;
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
            // lblOrderTotalAmount
            // 
            lblOrderTotalAmount.AutoSize = true;
            lblOrderTotalAmount.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblOrderTotalAmount.Location = new Point(12, 570);
            lblOrderTotalAmount.Name = "lblOrderTotalAmount";
            lblOrderTotalAmount.Size = new Size(110, 23);
            lblOrderTotalAmount.TabIndex = 56;
            lblOrderTotalAmount.Text = "yükleniyor...";
            // 
            // btnCustomerDelete
            // 
            btnCustomerDelete.BackColor = SystemColors.Control;
            btnCustomerDelete.FlatAppearance.BorderSize = 0;
            btnCustomerDelete.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCustomerDelete.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCustomerDelete.FlatStyle = FlatStyle.Flat;
            btnCustomerDelete.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomerDelete.ImageAlign = ContentAlignment.MiddleRight;
            btnCustomerDelete.ImageKey = "btnDelete.png";
            btnCustomerDelete.ImageList = ımageListButtons;
            btnCustomerDelete.Location = new Point(903, 567);
            btnCustomerDelete.Name = "btnCustomerDelete";
            btnCustomerDelete.Size = new Size(125, 54);
            btnCustomerDelete.TabIndex = 55;
            btnCustomerDelete.Text = "Siparişi Sil";
            btnCustomerDelete.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomerDelete.UseVisualStyleBackColor = false;
            btnCustomerDelete.Click += btnCustomerDelete_Click;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 627);
            Controls.Add(lblOrderTotalAmount);
            Controls.Add(btnCustomerDelete);
            Controls.Add(dataGridViewOrder);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Order";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HairdresserMS - Kasa";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private DataGridView dataGridViewOrder;
        private ImageList ımageListButtons;
        private Label lblOrderTotalAmount;
        private Button btnCustomerDelete;
    }
}