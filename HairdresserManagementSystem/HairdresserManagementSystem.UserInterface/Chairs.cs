using HairdresserManagementSystem.Entity.DomainObject;
using HairdresserManagementSystem.Entity.Enum;
using HairdresserManagementSystem.UserInterface.Events;

namespace HairdresserManagementSystem.UserInterface
{
    public partial class Chairs : Form
    {
        public Chairs(string loggedInUserId)
        {
            InitializeComponent();
            DataList();
            _loggedInUserId = loggedInUserId;
        }

        private BaseFormObject baseFormObject = new BaseFormObject();
        private string _loggedInUserId;

        private void OpenHomePage()
        {
            Application.Run(new Home(_loggedInUserId));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            baseFormObject.thread = new Thread(OpenHomePage);
            baseFormObject.thread.SetApartmentState(ApartmentState.STA);
            baseFormObject.thread.Start();
        }

        public void DataList()
        {
            dataGridViewChair.DataSource = baseFormObject.hairdresserMSContext.Chairs.Where(x => x.IsDeleted == false).OrderBy(x => x.Name).ToList();

            // Employeee ComboBox
            comboBoxChairEmployee.DataSource = baseFormObject.hairdresserMSContext.Employees.Where(x => x.IsDeleted == false).OrderByDescending(x => x.CreatedAtTime).ToList();
            comboBoxChairEmployee.DisplayMember = "NameSurname";
            comboBoxChairEmployee.ValueMember = "Id";

            // Customer ComboBox
            comboBoxChairCustomer.DataSource = baseFormObject.hairdresserMSContext.Customers.Where(x => x.IsDeleted == false).OrderByDescending(x => x.CreatedAtTime).ToList();
            comboBoxChairCustomer.DisplayMember = "NameSurname";
            comboBoxChairCustomer.ValueMember = "Id";

            // PayType ComboBox
            comboBoxChairPayType.DataSource = Enum.GetValues(typeof(OrderPaymentType));

            listBoxChairProducts.Items.Clear();
            var products = baseFormObject.hairdresserMSContext.Products.Where(x => x.IsDeleted == false).ToList();
            listBoxChairProducts.Items.AddRange(products.ToArray());
            listBoxChairProducts.DisplayMember = "Name";
            listBoxChairProducts.ValueMember = "Id";

            dataGridViewChair.Columns["Id"].Visible = false;
            dataGridViewChair.Columns["IsDeleted"].Visible = false;
            dataGridViewChair.Columns["CreatedAtTime"].Visible = false;
            dataGridViewChair.Columns["UpdatedAtTime"].Visible = false;
            dataGridViewChair.Columns["DeletedAtTime"].Visible = false;
            dataGridViewChair.Columns["Status"].Visible = false;
            dataGridViewChair.Columns["Employee"].Visible = false;
            dataGridViewChair.Columns["OrderId"].Visible = false;

            dataGridViewChair.Columns["Name"].HeaderText = "#";
            dataGridViewChair.Columns["ChairStatusType"].HeaderText = "Durum";

            dataGridViewChair.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewChair.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridViewChair.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewChair.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold);
            dataGridViewChair.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewChair.EnableHeadersVisualStyles = false;
            dataGridViewChair.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewChair.AllowUserToResizeRows = false;

            ClearInput();
        }

        public void ClearInput()
        {
            txtChairDescription.Text = "";
            comboBoxChairEmployee.SelectedIndex = -1;
            comboBoxChairCustomer.SelectedIndex = -1;
            comboBoxChairPayType.SelectedIndex = -1;
            listBoxChairProducts.SelectedIndex = -1;
            txtChairTip.Text = "0";
            txtChairDiscount.Text = "0";
            txtChairTotalAmount.Text = "0";
            txtChairTotalAmount2.Text = "0";
            listBoxChairSelectedProducts.Items.Clear();
        }

        public void UpdateTotalAmount()
        {
            decimal totalAmount = 0;

            foreach (Product product in listBoxChairSelectedProducts.Items)
            {
                totalAmount += product.Price;
            }

            txtChairTotalAmount.Text = totalAmount.ToString("F2");
        }

        private void listBoxChairProducts_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxChairProducts.SelectedItem != null)
            {
                var selectedProduct = listBoxChairProducts.SelectedItem as Product;

                listBoxChairSelectedProducts.Items.Add(selectedProduct);
                listBoxChairSelectedProducts.DisplayMember = "Name";
                listBoxChairSelectedProducts.ValueMember = "Id";
                UpdateTotalAmount();
            }
        }

        private void listBoxChairSelectedProducts_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxChairSelectedProducts.SelectedItem != null)
            {
                listBoxChairSelectedProducts.Items.Remove(listBoxChairSelectedProducts.SelectedItem);
                UpdateTotalAmount();
            }
        }

        private void txtChairTip_TextChanged(object sender, EventArgs e)
        {
            decimal totalAmount = decimal.TryParse(txtChairTotalAmount.Text, out var amount) ? amount : 0;
            decimal tip = decimal.TryParse(txtChairTip.Text, out var tipAmount) ? tipAmount : 0;
            decimal discount = decimal.TryParse(txtChairDiscount.Text, out var discountAmount) ? discountAmount : 0;
            txtChairTotalAmount2.Text = (totalAmount + tip - discount).ToString("F2");
        }

        private void txtChairDiscount_TextChanged(object sender, EventArgs e)
        {
            decimal totalAmount = decimal.TryParse(txtChairTotalAmount.Text, out var amount) ? amount : 0;
            decimal discount = decimal.TryParse(txtChairDiscount.Text, out var discountAmount) ? discountAmount : 0;
            decimal tip = decimal.TryParse(txtChairTip.Text, out var tipAmount) ? tipAmount : 0;
            txtChairTotalAmount2.Text = (totalAmount + tip - discount).ToString("F2");
        }

        private void txtChairTip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',' || e.KeyChar == '.') && (txtChairTip.Text.Contains(",") || txtChairTip.Text.Contains(".")))
            {
                e.Handled = true;
            }
        }

        private void txtChairDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',' || e.KeyChar == '.') && (txtChairDiscount.Text.Contains(",") || txtChairDiscount.Text.Contains(".")))
            {
                e.Handled = true;
            }
        }
        private string selectedChairId;
        private void dataGridViewChair_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0)
            {
                var chairId = dataGridViewChair.Rows[rowIndex].Cells["Id"].Value.ToString();
                selectedChairId = chairId;
                var chair = baseFormObject.hairdresserMSContext.Chairs.Find(chairId);
                lblSelectedChair.Text = "İşlem Yapılan Koltuk:\n" + chair.Name;

                if (chair.OrderId != string.Empty)
                {
                    var order = baseFormObject.hairdresserMSContext.Orders.Find(chair.OrderId);
                    txtChairDescription.Text = order.Description;
                    comboBoxChairEmployee.SelectedValue = order.Employee.Id;
                    comboBoxChairCustomer.SelectedValue = order.Customer.Id;
                    comboBoxChairPayType.SelectedItem = order.PaymentType;
                    txtChairTip.Text = order.Tip.ToString("F2");
                    txtChairDiscount.Text = order.Discount.ToString("F2");
                    txtChairTotalAmount2.Text = order.Amount.ToString("F2");

                    listBoxChairSelectedProducts.Items.Clear();
                    listBoxChairSelectedProducts.Items.AddRange(order.Products.ToArray());
                    listBoxChairSelectedProducts.DisplayMember = "Name";
                    listBoxChairSelectedProducts.ValueMember = "Id";
                }
                else
                {
                    ClearInput();
                }
            }
        }

        private void btnChairOrderAdd_Click(object sender, EventArgs e)
        {
            var selectedChair = baseFormObject.hairdresserMSContext.Chairs.Find(selectedChairId);

            if (selectedChair != null && comboBoxChairEmployee.SelectedIndex != -1 && comboBoxChairCustomer.SelectedIndex != -1 && comboBoxChairPayType.SelectedIndex != -1 && listBoxChairSelectedProducts.Items.Count > 0)
            {
                var chair = baseFormObject.hairdresserMSContext.Chairs.Find(selectedChairId);

                Entity.DomainObject.Order newOrder = new Entity.DomainObject.Order();
                newOrder.ChairName = chair.Name;
                newOrder.Employee = baseFormObject.hairdresserMSContext.Employees.Find(comboBoxChairEmployee.SelectedValue.ToString());
                newOrder.Customer = baseFormObject.hairdresserMSContext.Customers.Find(comboBoxChairCustomer.SelectedValue.ToString());
                newOrder.Description = txtChairDescription.Text;
                newOrder.Products = listBoxChairSelectedProducts.Items.Cast<Product>().ToList();
                newOrder.Tip = decimal.TryParse(txtChairTip.Text, out var tipAmount) ? tipAmount : 0;
                newOrder.Discount = decimal.TryParse(txtChairDiscount.Text, out var discountAmount) ? discountAmount : 0;
                newOrder.Amount = decimal.TryParse(txtChairTotalAmount2.Text, out var totalAmount) ? totalAmount : 0;
                newOrder.PaymentType = (OrderPaymentType)comboBoxChairPayType.SelectedItem;
                baseFormObject.hairdresserMSContext.Orders.Add(newOrder);

                chair.ChairStatusType = ChairStatusType.Dolu;
                chair.OrderId = newOrder.Id;
                baseFormObject.hairdresserMSContext.Chairs.Update(chair);

                baseFormObject.hairdresserMSContext.SaveChanges();
                MessageBox.Show("Koltuk güncellendi.", "HairdresserManagementSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataList();
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "HairdresserManagementSystem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnChairOrderConfirm_Click(object sender, EventArgs e)
        {
            var chair = baseFormObject.hairdresserMSContext.Chairs.Find(selectedChairId);
            if (chair.OrderId != string.Empty)
            {
                chair.ChairStatusType = ChairStatusType.Boş;
                chair.OrderId = string.Empty;
                baseFormObject.hairdresserMSContext.Chairs.Update(chair);
                baseFormObject.hairdresserMSContext.SaveChanges();
                MessageBox.Show("Koltuk hizmeti tamamlandı.", "HairdresserManagementSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataList();
            }
            else
            {
                MessageBox.Show("Lütfen dolu bir koltuk seçiniz.", "HairdresserManagementSystem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnChairOrderUpdate_Click(object sender, EventArgs e)
        {
            var chair = baseFormObject.hairdresserMSContext.Chairs.Find(selectedChairId);
            if (chair.OrderId != string.Empty)
            {
                var order = baseFormObject.hairdresserMSContext.Orders.Find(chair.OrderId);
                order.Employee = baseFormObject.hairdresserMSContext.Employees.Find(comboBoxChairEmployee.SelectedValue.ToString());
                order.Customer = baseFormObject.hairdresserMSContext.Customers.Find(comboBoxChairCustomer.SelectedValue.ToString());
                order.Description = txtChairDescription.Text;
                order.Products = listBoxChairSelectedProducts.Items.Cast<Product>().ToList();
                order.Tip = decimal.TryParse(txtChairTip.Text, out var tipAmount) ? tipAmount : 0;
                order.Discount = decimal.TryParse(txtChairDiscount.Text, out var discountAmount) ? discountAmount : 0;
                order.Amount = decimal.TryParse(txtChairTotalAmount2.Text, out var totalAmount) ? totalAmount : 0;
                order.PaymentType = (OrderPaymentType)comboBoxChairPayType.SelectedItem;
                baseFormObject.hairdresserMSContext.Orders.Update(order);

                baseFormObject.hairdresserMSContext.SaveChanges();
                MessageBox.Show("Koltuk güncellendi.", "HairdresserManagementSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataList();
            }
            else
            {
                MessageBox.Show("Lütfen dolu bir koltuk seçiniz.", "HairdresserManagementSystem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}