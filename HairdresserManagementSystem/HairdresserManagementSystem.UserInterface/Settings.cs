using HairdresserManagementSystem.Entity.DomainObject;
using HairdresserManagementSystem.Entity.Enum;
using HairdresserManagementSystem.UserInterface.Events;

namespace HairdresserManagementSystem.UserInterface
{
    public partial class Settings : Form
    {
        public Settings(string loggedInUserId)
        {
            InitializeComponent();
            GetWorkplace();
            DataList();
            _loggedInUserId = loggedInUserId;
        }

        private BaseFormObject baseFormObject = new BaseFormObject();
        private string _loggedInUserId;

        public void DataList()
        {
            dataGridViewEmployee.DataSource = baseFormObject.hairdresserMSContext.Employees.ToList();
            dataGridViewChair.DataSource = baseFormObject.hairdresserMSContext.Chairs.ToList();
            dataGridViewCategory.DataSource = baseFormObject.hairdresserMSContext.Categories.ToList();
            dataGridViewProduct.DataSource = baseFormObject.hairdresserMSContext.Products.ToList();

            // Employee

            dataGridViewEmployee.Columns["Id"].Visible = false;
            dataGridViewEmployee.Columns["IsDeleted"].Visible = false;
            dataGridViewEmployee.Columns["CreatedAtTime"].Visible = false;
            dataGridViewEmployee.Columns["UpdatedAtTime"].Visible = false;
            dataGridViewEmployee.Columns["DeletedAtTime"].Visible = false;
            dataGridViewEmployee.Columns["Status"].Visible = false;

            foreach (DataGridViewRow row in dataGridViewEmployee.Rows)
            {
                if (!row.IsNewRow && row.Cells["Password"].Value != null)
                {
                    row.Cells["Password"].Value = "*****";
                }
            }

            dataGridViewEmployee.Columns["NameSurname"].HeaderText = "Ad Soyad";
            dataGridViewEmployee.Columns["Email"].HeaderText = "Mail";
            dataGridViewEmployee.Columns["Password"].HeaderText = "Şifre";
            dataGridViewEmployee.Columns["Phone"].HeaderText = "Telefon";
            dataGridViewEmployee.Columns["Type"].HeaderText = "Kullanıcı Türü";

            dataGridViewEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewEmployee.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridViewEmployee.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewEmployee.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold);
            dataGridViewEmployee.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewEmployee.EnableHeadersVisualStyles = false;
            dataGridViewEmployee.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewEmployee.AllowUserToResizeRows = false;

            comboBoxEmployeeType.DataSource = Enum.GetValues(typeof(EmployeeType));

            // Chair

            dataGridViewChair.Columns["Id"].Visible = false;
            dataGridViewChair.Columns["IsDeleted"].Visible = false;
            dataGridViewChair.Columns["CreatedAtTime"].Visible = false;
            dataGridViewChair.Columns["UpdatedAtTime"].Visible = false;
            dataGridViewChair.Columns["DeletedAtTime"].Visible = false;
            dataGridViewChair.Columns["Status"].Visible = false;

            dataGridViewChair.Columns["Name"].HeaderText = "Ad";
            dataGridViewChair.Columns["Employee"].HeaderText = "Personel";

            dataGridViewChair.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewChair.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridViewChair.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewChair.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold);
            dataGridViewChair.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewChair.EnableHeadersVisualStyles = false;
            dataGridViewChair.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewChair.AllowUserToResizeRows = false;

            // Category

            dataGridViewCategory.Columns["Id"].Visible = false;
            dataGridViewCategory.Columns["IsDeleted"].Visible = false;
            dataGridViewCategory.Columns["CreatedAtTime"].Visible = false;
            dataGridViewCategory.Columns["UpdatedAtTime"].Visible = false;
            dataGridViewCategory.Columns["DeletedAtTime"].Visible = false;
            dataGridViewCategory.Columns["Status"].Visible = false;

            dataGridViewCategory.Columns["Name"].HeaderText = "Ad";

            dataGridViewCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCategory.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridViewCategory.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewCategory.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold);
            dataGridViewCategory.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCategory.EnableHeadersVisualStyles = false;
            dataGridViewCategory.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCategory.AllowUserToResizeRows = false;

            // Product

            dataGridViewProduct.Columns["Id"].Visible = false;
            dataGridViewProduct.Columns["IsDeleted"].Visible = false;
            dataGridViewProduct.Columns["CreatedAtTime"].Visible = false;
            dataGridViewProduct.Columns["UpdatedAtTime"].Visible = false;
            dataGridViewProduct.Columns["DeletedAtTime"].Visible = false;
            dataGridViewProduct.Columns["Status"].Visible = false;

            dataGridViewProduct.Columns["Category"].HeaderText = "Kategori";
            dataGridViewProduct.Columns["Name"].HeaderText = "Ad";
            dataGridViewProduct.Columns["Price"].HeaderText = "Fiyat";

            dataGridViewProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProduct.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridViewProduct.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewProduct.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold);
            dataGridViewProduct.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewProduct.EnableHeadersVisualStyles = false;
            dataGridViewProduct.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewProduct.AllowUserToResizeRows = false;
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

        public void GetWorkplace()
        {
            var workplace = baseFormObject.hairdresserMSContext.Settings.FirstOrDefault(x => x.Id == "77c8da8c22aa4743a2435e9479fd60f4");
            txtName.Text = workplace.WorkplaceName;
            txtAddress.Text = workplace.WorkplaceAddress;
            txtPhone.Text = workplace.WorkplacePhone;
            txtAuthority.Text = workplace.WorkplaceAuthority;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var workplace = baseFormObject.hairdresserMSContext.Settings.FirstOrDefault(x => x.Id == "77c8da8c22aa4743a2435e9479fd60f4");
            workplace.WorkplaceName = txtName.Text;
            workplace.WorkplaceAddress = txtAddress.Text;
            workplace.WorkplacePhone = txtPhone.Text;
            workplace.WorkplaceAuthority = txtAuthority.Text;
            baseFormObject.hairdresserMSContext.Settings.Update(workplace);
            baseFormObject.hairdresserMSContext.SaveChanges();
            MessageBox.Show("İşyeri bilgileri başarıyla güncellendi.", "HairdresserManagementSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {
            if (txtEmployeeName.Text != string.Empty && txtEmployeeEmail.Text != string.Empty && txtEmployeePhone.Text != string.Empty && txtEmployeePassword.Text != string.Empty || comboBoxEmployeeType.SelectedIndex != -1)
            {
                Employee newEmployee = new Employee();
                newEmployee.NameSurname = txtEmployeeName.Text;
                newEmployee.Email = txtEmployeeEmail.Text;
                newEmployee.Password = txtEmployeePassword.Text;
                newEmployee.Phone = txtEmployeePhone.Text;
                newEmployee.Type = (EmployeeType)comboBoxEmployeeType.SelectedItem;

                baseFormObject.hairdresserMSContext.Employees.Add(newEmployee);
                baseFormObject.hairdresserMSContext.SaveChanges();
            }
        }
    }
}