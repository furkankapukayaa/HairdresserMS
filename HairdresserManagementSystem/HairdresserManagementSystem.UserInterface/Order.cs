using HairdresserManagementSystem.UserInterface.Events;

namespace HairdresserManagementSystem.UserInterface
{
    public partial class Order : Form
    {
        public Order(string loggedInUserId)
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
            dataGridViewOrder.DataSource = baseFormObject.hairdresserMSContext.Orders.Where(x => x.IsDeleted == false).OrderByDescending(x => x.CreatedAtTime).ToList();

            dataGridViewOrder.Columns["Id"].Visible = false;
            dataGridViewOrder.Columns["IsDeleted"].Visible = false;
            dataGridViewOrder.Columns["CreatedAtTime"].Visible = false;
            dataGridViewOrder.Columns["UpdatedAtTime"].Visible = false;
            dataGridViewOrder.Columns["DeletedAtTime"].Visible = false;
            dataGridViewOrder.Columns["Status"].Visible = false;

            dataGridViewOrder.Columns["EmployeeId"].HeaderText = "Personel";
            dataGridViewOrder.Columns["CustomerId"].HeaderText = "Müşteri";
            dataGridViewOrder.Columns["Description"].HeaderText = "Not";
            dataGridViewOrder.Columns.Add("Products", "Ürünler");
            dataGridViewOrder.Columns["Products"].DisplayIndex = 5;
            dataGridViewOrder.Columns["Tip"].HeaderText = "Bahşiş";
            dataGridViewOrder.Columns["Discount"].HeaderText = "İndirim";
            dataGridViewOrder.Columns["Amount"].HeaderText = "Toplam";
            dataGridViewOrder.Columns["PaymentType"].HeaderText = "Ödeme Türü";
            dataGridViewOrder.Columns["ChairName"].HeaderText = "Koltuk";

            dataGridViewOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewOrder.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridViewOrder.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewOrder.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold);
            dataGridViewOrder.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewOrder.EnableHeadersVisualStyles = false;
            dataGridViewOrder.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewOrder.AllowUserToResizeRows = false;

            lblOrderTotalAmount.Text = "Toplam: " + baseFormObject.hairdresserMSContext.Orders.Where(x => x.IsDeleted == false).Sum(x => x.Amount).ToString() + " ₺";
        }

        private void dataGridViewOrder_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewOrder.Columns[e.ColumnIndex].Name == "EmployeeId" && e.Value != null)
            {
                string employeeId = e.Value.ToString();
                var employee = baseFormObject.hairdresserMSContext.Employees.Find(employeeId);
                e.Value = employee?.NameSurname ?? "Yok";
            }

            if (dataGridViewOrder.Columns[e.ColumnIndex].Name == "CustomerId" && e.Value != null)
            {
                string customerId = e.Value.ToString();
                var customer = baseFormObject.hairdresserMSContext.Customers.Find(customerId);
                e.Value = customer?.NameSurname ?? "Yok";
            }

            var products = baseFormObject.hairdresserMSContext.Products.Where(p => !p.IsDeleted).ToList();
            var productDictionary = products.ToDictionary(p => p.Id.ToString(), p => p.Name);

            if (dataGridViewOrder.Columns[e.ColumnIndex].Name == "Products" && e.RowIndex >= 0)
            {
                var order = dataGridViewOrder.Rows[e.RowIndex].DataBoundItem as Entity.DomainObject.Order;

                if (order != null && order.Products != null)
                {
                    var productNames = order.Products.Select(id => productDictionary.ContainsKey(id) ? productDictionary[id] : id).ToList();

                    e.Value = string.Join(", ", productNames);
                }
            }
        }

        private string selectedOrderId;
        private void dataGridViewOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0)
            {
                var orderId = dataGridViewOrder.Rows[rowIndex].Cells["Id"].Value.ToString();
                selectedOrderId = orderId;
            }
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            var selectedOrder = baseFormObject.hairdresserMSContext.Orders.FirstOrDefault(x => x.Id == selectedOrderId);
            if (selectedOrder != null)
            {
                selectedOrder.IsDeleted = true;
                selectedOrder.DeletedAtTime = DateTime.Now;
                baseFormObject.hairdresserMSContext.Orders.Update(selectedOrder);
                baseFormObject.hairdresserMSContext.SaveChanges();
                MessageBox.Show("Sipariş başarıyla silindi.", "HairdresserManagementSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataList();
            }
        }
    }
}