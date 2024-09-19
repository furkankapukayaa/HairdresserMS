using HairdresserManagementSystem.UserInterface.Events;
using System.Data;

namespace HairdresserManagementSystem.UserInterface
{
    public partial class Customer : Form
    {
        public Customer(string loggedInUserId)
        {
            InitializeComponent();
            DataList();
            _loggedInUserId = loggedInUserId;
        }

        private BaseFormObject baseFormObject = new BaseFormObject();
        private string _loggedInUserId;

        public void DataList()
        {
            dataGridViewCustomer.DataSource = baseFormObject.hairdresserMSContext.Customers.Where(x => x.IsDeleted == false).OrderByDescending(x => x.CreatedAtTime).ToList();

            dataGridViewCustomer.Columns["Id"].Visible = false;
            dataGridViewCustomer.Columns["IsDeleted"].Visible = false;
            dataGridViewCustomer.Columns["CreatedAtTime"].Visible = false;
            dataGridViewCustomer.Columns["UpdatedAtTime"].Visible = false;
            dataGridViewCustomer.Columns["DeletedAtTime"].Visible = false;
            dataGridViewCustomer.Columns["Status"].Visible = false;

            dataGridViewCustomer.Columns["NameSurname"].HeaderText = "Ad Soyad";
            dataGridViewCustomer.Columns["Email"].HeaderText = "Mail";
            dataGridViewCustomer.Columns["Phone"].HeaderText = "Telefon";
            dataGridViewCustomer.Columns["Address"].HeaderText = "Adres";
            dataGridViewCustomer.Columns["Description"].HeaderText = "Açıklama";

            dataGridViewCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCustomer.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridViewCustomer.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewCustomer.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold);
            dataGridViewCustomer.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCustomer.EnableHeadersVisualStyles = false;
            dataGridViewCustomer.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCustomer.AllowUserToResizeRows = false;

            ClearInput();
        }

        public void ClearInput()
        {
            txtCustomerName.Clear();
            txtCustomerEmail.Clear();
            txtCustomerPhone.Clear();
            txtCustomerAddress.Clear();
            txtCustomerDescription.Clear();
        }

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

        private string selectedCustomerId;
        private void dataGridViewCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0)
            {
                var customerId = dataGridViewCustomer.Rows[rowIndex].Cells["Id"].Value.ToString();
                selectedCustomerId = customerId;
                var customer = baseFormObject.hairdresserMSContext.Customers.FirstOrDefault(x => x.Id == customerId);

                if (customer != null)
                {
                    txtCustomerName.Text = customer.NameSurname;
                    txtCustomerEmail.Text = customer.Email;
                    txtCustomerPhone.Text = customer.Phone;
                    txtCustomerAddress.Text = customer.Address;
                    txtCustomerDescription.Text = customer.Description;
                }
            }
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text != string.Empty && txtCustomerEmail.Text != string.Empty && txtCustomerPhone.Text != string.Empty && txtCustomerAddress.Text != string.Empty && txtCustomerDescription.Text != string.Empty)
            {
                Entity.DomainObject.Customer newCustomer = new Entity.DomainObject.Customer();
                newCustomer.NameSurname = txtCustomerName.Text;
                newCustomer.Email = txtCustomerEmail.Text;
                newCustomer.Phone = txtCustomerPhone.Text;
                newCustomer.Address = txtCustomerAddress.Text;
                newCustomer.Description = txtCustomerDescription.Text;

                baseFormObject.hairdresserMSContext.Customers.Add(newCustomer);
                baseFormObject.hairdresserMSContext.SaveChanges();
                MessageBox.Show("Yeni müşteri başarıyla eklendi.", "HairdresserManagementSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataList();
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "HairdresserManagementSystem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            var selectedCustomer = baseFormObject.hairdresserMSContext.Customers.FirstOrDefault(x => x.Id == selectedCustomerId);
            if (selectedCustomer != null)
            {
                selectedCustomer.NameSurname = txtCustomerName.Text;
                selectedCustomer.Email = txtCustomerEmail.Text;
                selectedCustomer.Phone = txtCustomerPhone.Text;
                selectedCustomer.Address = txtCustomerAddress.Text;
                selectedCustomer.Description = txtCustomerDescription.Text;
                selectedCustomer.UpdatedAtTime = DateTime.Now;

                baseFormObject.hairdresserMSContext.Customers.Update(selectedCustomer);
                baseFormObject.hairdresserMSContext.SaveChanges();
                MessageBox.Show("Müşteri başarıyla güncellendi.", "HairdresserManagementSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataList();
            }
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            var selectedCustomer = baseFormObject.hairdresserMSContext.Customers.FirstOrDefault(x => x.Id == selectedCustomerId);
            if (selectedCustomer != null)
            {
                selectedCustomer.IsDeleted = true;
                selectedCustomer.DeletedAtTime = DateTime.Now;
                baseFormObject.hairdresserMSContext.Customers.Update(selectedCustomer);
                baseFormObject.hairdresserMSContext.SaveChanges();
                MessageBox.Show("Müşteri başarıyla silindi.", "HairdresserManagementSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataList();
            }
        }
    }
}