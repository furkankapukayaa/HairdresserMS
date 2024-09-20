namespace HairdresserManagementSystem.UserInterface
{
    partial class Chairs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chairs));
            btnBack = new Button();
            dataGridViewChair = new DataGridView();
            lblChairSelectedProduct = new Label();
            lblChairProducts = new Label();
            listBoxChairSelectedProducts = new ListBox();
            listBoxChairProducts = new ListBox();
            lblChairCustomer = new Label();
            comboBoxChairCustomer = new ComboBox();
            lblChairEmployee = new Label();
            lblChairDescription = new Label();
            txtChairDescription = new TextBox();
            comboBoxChairEmployee = new ComboBox();
            comboBoxChairPayType = new ComboBox();
            txtChairTotalAmount = new TextBox();
            txtChairTip = new TextBox();
            txtChairDiscount = new TextBox();
            txtChairTotalAmount2 = new TextBox();
            lblChairTotalAmount = new Label();
            lblChairTip = new Label();
            lblChairDiscount = new Label();
            lblChairTotalAmount2 = new Label();
            lblChairPayType = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewChair).BeginInit();
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
            // dataGridViewChair
            // 
            dataGridViewChair.AllowUserToAddRows = false;
            dataGridViewChair.AllowUserToDeleteRows = false;
            dataGridViewChair.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewChair.Location = new Point(12, 12);
            dataGridViewChair.Name = "dataGridViewChair";
            dataGridViewChair.ReadOnly = true;
            dataGridViewChair.Size = new Size(207, 603);
            dataGridViewChair.TabIndex = 37;
            // 
            // lblChairSelectedProduct
            // 
            lblChairSelectedProduct.AutoSize = true;
            lblChairSelectedProduct.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblChairSelectedProduct.Location = new Point(773, 58);
            lblChairSelectedProduct.Name = "lblChairSelectedProduct";
            lblChairSelectedProduct.Size = new Size(186, 23);
            lblChairSelectedProduct.TabIndex = 61;
            lblChairSelectedProduct.Text = "İstenen Ürün/Hizmet";
            // 
            // lblChairProducts
            // 
            lblChairProducts.AutoSize = true;
            lblChairProducts.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblChairProducts.Location = new Point(581, 58);
            lblChairProducts.Name = "lblChairProducts";
            lblChairProducts.Size = new Size(118, 23);
            lblChairProducts.TabIndex = 60;
            lblChairProducts.Text = "Ürün/Hizmet";
            // 
            // listBoxChairSelectedProducts
            // 
            listBoxChairSelectedProducts.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold);
            listBoxChairSelectedProducts.FormattingEnabled = true;
            listBoxChairSelectedProducts.ItemHeight = 20;
            listBoxChairSelectedProducts.Location = new Point(773, 84);
            listBoxChairSelectedProducts.Name = "listBoxChairSelectedProducts";
            listBoxChairSelectedProducts.Size = new Size(172, 364);
            listBoxChairSelectedProducts.TabIndex = 59;
            // 
            // listBoxChairProducts
            // 
            listBoxChairProducts.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold);
            listBoxChairProducts.FormattingEnabled = true;
            listBoxChairProducts.ItemHeight = 20;
            listBoxChairProducts.Location = new Point(581, 84);
            listBoxChairProducts.Name = "listBoxChairProducts";
            listBoxChairProducts.Size = new Size(172, 364);
            listBoxChairProducts.TabIndex = 58;
            // 
            // lblChairCustomer
            // 
            lblChairCustomer.AutoSize = true;
            lblChairCustomer.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblChairCustomer.Location = new Point(271, 214);
            lblChairCustomer.Name = "lblChairCustomer";
            lblChairCustomer.Size = new Size(75, 23);
            lblChairCustomer.TabIndex = 57;
            lblChairCustomer.Text = "Müşteri";
            // 
            // comboBoxChairCustomer
            // 
            comboBoxChairCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxChairCustomer.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold);
            comboBoxChairCustomer.FormattingEnabled = true;
            comboBoxChairCustomer.Location = new Point(271, 240);
            comboBoxChairCustomer.Name = "comboBoxChairCustomer";
            comboBoxChairCustomer.Size = new Size(237, 28);
            comboBoxChairCustomer.TabIndex = 56;
            // 
            // lblChairEmployee
            // 
            lblChairEmployee.AutoSize = true;
            lblChairEmployee.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblChairEmployee.Location = new Point(271, 145);
            lblChairEmployee.Name = "lblChairEmployee";
            lblChairEmployee.Size = new Size(86, 23);
            lblChairEmployee.TabIndex = 55;
            lblChairEmployee.Text = "Personel";
            // 
            // lblChairDescription
            // 
            lblChairDescription.AutoSize = true;
            lblChairDescription.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblChairDescription.Location = new Point(271, 282);
            lblChairDescription.Name = "lblChairDescription";
            lblChairDescription.Size = new Size(39, 23);
            lblChairDescription.TabIndex = 54;
            lblChairDescription.Text = "Not";
            // 
            // txtChairDescription
            // 
            txtChairDescription.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtChairDescription.Location = new Point(271, 310);
            txtChairDescription.Multiline = true;
            txtChairDescription.Name = "txtChairDescription";
            txtChairDescription.Size = new Size(248, 105);
            txtChairDescription.TabIndex = 52;
            txtChairDescription.TextAlign = HorizontalAlignment.Center;
            // 
            // comboBoxChairEmployee
            // 
            comboBoxChairEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxChairEmployee.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold);
            comboBoxChairEmployee.FormattingEnabled = true;
            comboBoxChairEmployee.Location = new Point(271, 171);
            comboBoxChairEmployee.Name = "comboBoxChairEmployee";
            comboBoxChairEmployee.Size = new Size(237, 28);
            comboBoxChairEmployee.TabIndex = 53;
            // 
            // comboBoxChairPayType
            // 
            comboBoxChairPayType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxChairPayType.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold);
            comboBoxChairPayType.FormattingEnabled = true;
            comboBoxChairPayType.Location = new Point(913, 497);
            comboBoxChairPayType.Name = "comboBoxChairPayType";
            comboBoxChairPayType.Size = new Size(87, 28);
            comboBoxChairPayType.TabIndex = 62;
            // 
            // txtChairTotalAmount
            // 
            txtChairTotalAmount.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtChairTotalAmount.Location = new Point(553, 498);
            txtChairTotalAmount.Name = "txtChairTotalAmount";
            txtChairTotalAmount.Size = new Size(84, 27);
            txtChairTotalAmount.TabIndex = 63;
            txtChairTotalAmount.TextAlign = HorizontalAlignment.Center;
            // 
            // txtChairTip
            // 
            txtChairTip.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtChairTip.Location = new Point(643, 498);
            txtChairTip.Name = "txtChairTip";
            txtChairTip.Size = new Size(84, 27);
            txtChairTip.TabIndex = 64;
            txtChairTip.TextAlign = HorizontalAlignment.Center;
            // 
            // txtChairDiscount
            // 
            txtChairDiscount.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtChairDiscount.Location = new Point(733, 498);
            txtChairDiscount.Name = "txtChairDiscount";
            txtChairDiscount.Size = new Size(84, 27);
            txtChairDiscount.TabIndex = 65;
            txtChairDiscount.TextAlign = HorizontalAlignment.Center;
            // 
            // txtChairTotalAmount2
            // 
            txtChairTotalAmount2.Font = new Font("Segoe UI Variable Text Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtChairTotalAmount2.Location = new Point(823, 498);
            txtChairTotalAmount2.Name = "txtChairTotalAmount2";
            txtChairTotalAmount2.Size = new Size(84, 27);
            txtChairTotalAmount2.TabIndex = 66;
            txtChairTotalAmount2.TextAlign = HorizontalAlignment.Center;
            // 
            // lblChairTotalAmount
            // 
            lblChairTotalAmount.AutoSize = true;
            lblChairTotalAmount.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblChairTotalAmount.Location = new Point(553, 472);
            lblChairTotalAmount.Name = "lblChairTotalAmount";
            lblChairTotalAmount.Size = new Size(70, 23);
            lblChairTotalAmount.TabIndex = 67;
            lblChairTotalAmount.Text = "Toplam";
            // 
            // lblChairTip
            // 
            lblChairTip.AutoSize = true;
            lblChairTip.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblChairTip.Location = new Point(643, 472);
            lblChairTip.Name = "lblChairTip";
            lblChairTip.Size = new Size(68, 23);
            lblChairTip.TabIndex = 68;
            lblChairTip.Text = "Bahşiş";
            // 
            // lblChairDiscount
            // 
            lblChairDiscount.AutoSize = true;
            lblChairDiscount.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblChairDiscount.Location = new Point(733, 472);
            lblChairDiscount.Name = "lblChairDiscount";
            lblChairDiscount.Size = new Size(70, 23);
            lblChairDiscount.TabIndex = 69;
            lblChairDiscount.Text = "İndirim";
            // 
            // lblChairTotalAmount2
            // 
            lblChairTotalAmount2.AutoSize = true;
            lblChairTotalAmount2.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblChairTotalAmount2.Location = new Point(823, 472);
            lblChairTotalAmount2.Name = "lblChairTotalAmount2";
            lblChairTotalAmount2.Size = new Size(53, 23);
            lblChairTotalAmount2.TabIndex = 70;
            lblChairTotalAmount2.Text = "Tutar";
            // 
            // lblChairPayType
            // 
            lblChairPayType.AutoSize = true;
            lblChairPayType.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblChairPayType.Location = new Point(913, 472);
            lblChairPayType.Name = "lblChairPayType";
            lblChairPayType.Size = new Size(68, 23);
            lblChairPayType.TabIndex = 71;
            lblChairPayType.Text = "Ödeme";
            // 
            // Chairs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 627);
            Controls.Add(lblChairPayType);
            Controls.Add(lblChairTotalAmount2);
            Controls.Add(lblChairDiscount);
            Controls.Add(lblChairTip);
            Controls.Add(lblChairTotalAmount);
            Controls.Add(txtChairTotalAmount2);
            Controls.Add(txtChairDiscount);
            Controls.Add(txtChairTip);
            Controls.Add(txtChairTotalAmount);
            Controls.Add(comboBoxChairPayType);
            Controls.Add(lblChairSelectedProduct);
            Controls.Add(lblChairProducts);
            Controls.Add(listBoxChairSelectedProducts);
            Controls.Add(listBoxChairProducts);
            Controls.Add(lblChairCustomer);
            Controls.Add(comboBoxChairCustomer);
            Controls.Add(lblChairEmployee);
            Controls.Add(lblChairDescription);
            Controls.Add(txtChairDescription);
            Controls.Add(comboBoxChairEmployee);
            Controls.Add(dataGridViewChair);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Chairs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HairdresserMS - Koltuklar";
            ((System.ComponentModel.ISupportInitialize)dataGridViewChair).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private DataGridView dataGridViewChair;
        private Label lblChairSelectedProduct;
        private Label lblChairProducts;
        private ListBox listBoxChairSelectedProducts;
        private ListBox listBoxChairProducts;
        private Label lblChairCustomer;
        private ComboBox comboBoxChairCustomer;
        private Label lblChairEmployee;
        private Label lblChairDescription;
        private TextBox txtChairDescription;
        private ComboBox comboBoxChairEmployee;
        private ComboBox comboBoxChairPayType;
        private TextBox txtChairTotalAmount;
        private TextBox txtChairTip;
        private TextBox txtChairDiscount;
        private TextBox txtChairTotalAmount2;
        private Label lblChairTotalAmount;
        private Label lblChairTip;
        private Label lblChairDiscount;
        private Label lblChairTotalAmount2;
        private Label lblChairPayType;
    }
}