using HairdresserManagementSystem.Entity.DomainObject;
using HairdresserManagementSystem.Entity.Enum;
using HairdresserManagementSystem.UserInterface.Events;

namespace HairdresserManagementSystem.UserInterface
{
    public partial class Appointment : Form
    {
        public Appointment(string loggedInUserId)
        {
            InitializeComponent();
            DataList();
            _loggedInUserId = loggedInUserId;
        }

        private BaseFormObject baseFormObject = new BaseFormObject();
        private string _loggedInUserId;

        public void DataList()
        {
            // Employeee ComboBox
            comboBoxAppointmentEmployee.DataSource = baseFormObject.hairdresserMSContext.Employees.Where(x => x.IsDeleted == false).OrderByDescending(x => x.CreatedAtTime).ToList();
            comboBoxAppointmentEmployee.DisplayMember = "NameSurname";
            comboBoxAppointmentEmployee.ValueMember = "Id";

            // Customer ComboBox
            comboBoxAppointmentCustomer.DataSource = baseFormObject.hairdresserMSContext.Customers.Where(x => x.IsDeleted == false).OrderByDescending(x => x.CreatedAtTime).ToList();
            comboBoxAppointmentCustomer.DisplayMember = "NameSurname";
            comboBoxAppointmentCustomer.ValueMember = "Id";

            listBoxAppointmentProducts.Items.Clear();
            var products = baseFormObject.hairdresserMSContext.Products.Where(x => x.IsDeleted == false).ToList();
            listBoxAppointmentProducts.Items.AddRange(products.ToArray());
            listBoxAppointmentProducts.DisplayMember = "Name";
            listBoxAppointmentProducts.ValueMember = "Id";

            dataGridViewAppointment.DataSource = baseFormObject.hairdresserMSContext.Appointments.Where(x => x.IsDeleted == false).OrderByDescending(x => x.CreatedAtTime).ToList();

            dataGridViewAppointment.Columns["Id"].Visible = false;
            dataGridViewAppointment.Columns["IsDeleted"].Visible = false;
            dataGridViewAppointment.Columns["CreatedAtTime"].Visible = false;
            dataGridViewAppointment.Columns["UpdatedAtTime"].Visible = false;
            dataGridViewAppointment.Columns["DeletedAtTime"].Visible = false;
            dataGridViewAppointment.Columns["Status"].Visible = false;
            dataGridViewAppointment.Columns["Date"].DefaultCellStyle.Format = "dd.MM.yyyy";
            dataGridViewAppointment.Columns["Time"].DefaultCellStyle.Format = "HH:mm";

            dataGridViewAppointment.Columns["Employee"].HeaderText = "Personel";
            dataGridViewAppointment.Columns["Customer"].HeaderText = "Müşteri";
            dataGridViewAppointment.Columns["Notes"].HeaderText = "Not";
            dataGridViewAppointment.Columns["Date"].HeaderText = "Tarih";
            dataGridViewAppointment.Columns["Time"].HeaderText = "Saat";
            dataGridViewAppointment.Columns["Products"].HeaderText = "Hizmetler";
            dataGridViewAppointment.Columns["Amount"].HeaderText = "Ücret";
            dataGridViewAppointment.Columns["AppointmentStatusType"].HeaderText = "Durum";

            dataGridViewAppointment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewAppointment.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridViewAppointment.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewAppointment.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold);
            dataGridViewAppointment.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewAppointment.EnableHeadersVisualStyles = false;
            dataGridViewAppointment.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewAppointment.AllowUserToResizeRows = false;

            ClearInput();
        }

        public void ClearInput()
        {
            comboBoxAppointmentEmployee.SelectedIndex = -1;
            comboBoxAppointmentCustomer.SelectedIndex = -1;
            txtAppointmentDescription.Text = string.Empty;
            dateTimePickerAppointmentDate.Value = DateTime.Now;
            dateTimePickerAppointmentTime.Value = DateTime.Now;
            listBoxAppointmentSelectedProducts.Items.Clear();
            txtAppointmentAmount.Text = "0";
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

        public void UpdateTotalAmount()
        {
            decimal totalAmount = 0;

            foreach (Product product in listBoxAppointmentSelectedProducts.Items)
            {
                totalAmount += product.Price;
            }

            txtAppointmentAmount.Text = totalAmount.ToString("F2");
        }
        private void listBoxAppointmentProducts_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxAppointmentProducts.SelectedItem != null)
            {
                var selectedProduct = listBoxAppointmentProducts.SelectedItem as Product;

                listBoxAppointmentSelectedProducts.Items.Add(selectedProduct);
                listBoxAppointmentSelectedProducts.DisplayMember = "Name";
                listBoxAppointmentSelectedProducts.ValueMember = "Id";
                UpdateTotalAmount();
            }
        }

        private void listBoxAppointmentSelectedProducts_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxAppointmentSelectedProducts.SelectedItem != null)
            {
                listBoxAppointmentSelectedProducts.Items.Remove(listBoxAppointmentSelectedProducts.SelectedItem);
                UpdateTotalAmount();
            }
        }

        private void btnAppointmentAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxAppointmentEmployee.SelectedIndex != -1 && comboBoxAppointmentCustomer.SelectedIndex != -1 && txtAppointmentDescription.Text != string.Empty && listBoxAppointmentSelectedProducts.Items.Count > 0)
            {
                Entity.DomainObject.Appointment newAppointment = new Entity.DomainObject.Appointment();
                newAppointment.Employee = comboBoxAppointmentEmployee.SelectedItem as Employee;
                newAppointment.Customer = comboBoxAppointmentCustomer.SelectedItem as Entity.DomainObject.Customer;
                newAppointment.Notes = txtAppointmentDescription.Text;
                newAppointment.Date = dateTimePickerAppointmentDate.Value;
                newAppointment.Time = dateTimePickerAppointmentTime.Value;
                newAppointment.Products = listBoxAppointmentSelectedProducts.Items.Cast<Product>().ToList();
                newAppointment.Amount = Math.Round(Convert.ToDouble(txtAppointmentAmount.Text), 2);
                newAppointment.AppointmentStatusType = AppointmentStatusType.Aktif;

                baseFormObject.hairdresserMSContext.Appointments.Add(newAppointment);
                baseFormObject.hairdresserMSContext.SaveChanges();
                MessageBox.Show("Yeni Randevu başarıyla eklendi.", "HairdresserManagementSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataList();
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "HairdresserManagementSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewAppointment_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewAppointment.Columns[e.ColumnIndex].Name == "Employee" && e.Value != null)
            {
                var employee = (Employee)e.Value;
                e.Value = employee?.NameSurname ?? "Yok";
            }

            if (dataGridViewAppointment.Columns[e.ColumnIndex].Name == "Customer" && e.Value != null)
            {
                var customer = (Entity.DomainObject.Customer)e.Value;
                e.Value = customer?.NameSurname ?? "Yok";
            }

            if (dataGridViewAppointment.Columns[e.ColumnIndex].Name == "Products" && e.Value is ICollection<Product> products)
            {
                e.Value = products != null ? string.Join(", ", products.Select(p => p.Name)) : "Yok";
            }
        }
        private string selectedAppointmentId;
        private void btnAppointmentCancel_Click(object sender, EventArgs e)
        {
            var selectedAppointment = baseFormObject.hairdresserMSContext.Appointments.FirstOrDefault(x => x.Id == selectedAppointmentId);
            if (selectedAppointment != null)
            {
                selectedAppointment.AppointmentStatusType = AppointmentStatusType.İptal;
                selectedAppointment.UpdatedAtTime = DateTime.Now;
                baseFormObject.hairdresserMSContext.Appointments.Update(selectedAppointment);
                baseFormObject.hairdresserMSContext.SaveChanges();
                MessageBox.Show("Randevu başarıyla iptal edildi.", "HairdresserManagementSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataList();
            }
        }

        private void dataGridViewAppointment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0)
            {
                var appointmentId = dataGridViewAppointment.Rows[rowIndex].Cells["Id"].Value.ToString();
                selectedAppointmentId = appointmentId;
            }
        }

        private void btnAppointmentDelete_Click(object sender, EventArgs e)
        {
            var selectedAppointment = baseFormObject.hairdresserMSContext.Appointments.FirstOrDefault(x => x.Id == selectedAppointmentId);
            if (selectedAppointment != null)
            {
                selectedAppointment.IsDeleted = true;
                selectedAppointment.DeletedAtTime = DateTime.Now;
                baseFormObject.hairdresserMSContext.Appointments.Update(selectedAppointment);
                baseFormObject.hairdresserMSContext.SaveChanges();
                MessageBox.Show("Randevu başarıyla silindi.", "HairdresserManagementSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedAppointment = baseFormObject.hairdresserMSContext.Appointments.FirstOrDefault(x => x.Id == selectedAppointmentId);
            if (selectedAppointment != null)
            {
                selectedAppointment.AppointmentStatusType = AppointmentStatusType.Tamamlandı;
                selectedAppointment.UpdatedAtTime = DateTime.Now;
                baseFormObject.hairdresserMSContext.Appointments.Update(selectedAppointment);
                baseFormObject.hairdresserMSContext.SaveChanges();
                MessageBox.Show("Randevu başarıyla silindi.", "HairdresserManagementSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataList();
            }
        }
    }
}