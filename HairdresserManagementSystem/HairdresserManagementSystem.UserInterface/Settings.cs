using HairdresserManagementSystem.Entity.DomainObject;
using HairdresserManagementSystem.Entity.Enum;
using HairdresserManagementSystem.UserInterface.Events;
using System.Data;

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
            dataGridViewEmployee.DataSource = baseFormObject.hairdresserMSContext.Employees.Where(x => x.IsDeleted == false).OrderByDescending(x => x.CreatedAtTime).ToList();
            dataGridViewChair.DataSource = baseFormObject.hairdresserMSContext.Chairs.Where(x => x.IsDeleted == false).OrderByDescending(x => x.CreatedAtTime).ToList();
            dataGridViewCategory.DataSource = baseFormObject.hairdresserMSContext.Categories.Where(x => x.IsDeleted == false).OrderByDescending(x => x.CreatedAtTime).ToList();
            dataGridViewProduct.DataSource = baseFormObject.hairdresserMSContext.Products.Where(x => x.IsDeleted == false).OrderByDescending(x => x.CreatedAtTime).ToList();

            // Employee

            dataGridViewEmployee.Columns["Id"].Visible = false;
            dataGridViewEmployee.Columns["IsDeleted"].Visible = false;
            dataGridViewEmployee.Columns["CreatedAtTime"].Visible = false;
            dataGridViewEmployee.Columns["UpdatedAtTime"].Visible = false;
            dataGridViewEmployee.Columns["DeletedAtTime"].Visible = false;
            dataGridViewEmployee.Columns["Status"].Visible = false;

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
            dataGridViewChair.Columns["OrderId"].Visible = false;

            dataGridViewChair.Columns["Name"].HeaderText = "Ad";
            dataGridViewChair.Columns["Employee"].HeaderText = "Personel";
            dataGridViewChair.Columns["ChairStatusType"].HeaderText = "Durum";

            dataGridViewChair.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewChair.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridViewChair.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewChair.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold);
            dataGridViewChair.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewChair.EnableHeadersVisualStyles = false;
            dataGridViewChair.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewChair.AllowUserToResizeRows = false;

            comboBoxChairEmployee.DataSource = baseFormObject.hairdresserMSContext.Employees.Where(x => x.IsDeleted == false).OrderByDescending(x => x.CreatedAtTime).ToList();
            comboBoxChairEmployee.DisplayMember = "NameSurname";
            comboBoxChairEmployee.ValueMember = "Id";

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

            comboBoxProductCategory.DataSource = baseFormObject.hairdresserMSContext.Categories.Where(x => x.IsDeleted == false).OrderByDescending(x => x.CreatedAtTime).ToList(); ;
            comboBoxProductCategory.DisplayMember = "Name";
            comboBoxProductCategory.ValueMember = "Id";

            ClearInput();
        }
        public void ClearInput()
        {
            // Employee
            txtEmployeeName.Clear();
            txtEmployeeEmail.Clear();
            txtEmployeePassword.Clear();
            txtEmployeePhone.Clear();
            comboBoxEmployeeType.SelectedIndex = -1;

            // Chair
            txtChairName.Clear();
            comboBoxChairEmployee.SelectedIndex = -1;

            // Category
            txtCategoryName.Clear();

            // Product
            comboBoxProductCategory.SelectedIndex = -1;
            txtProductName.Clear();
            txtProductPrice.Clear();
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
            if (workplace != null)
            {
                txtName.Text = workplace.WorkplaceName;
                txtAddress.Text = workplace.WorkplaceAddress;
                txtPhone.Text = workplace.WorkplacePhone;
                txtAuthority.Text = workplace.WorkplaceAuthority;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var workplace = baseFormObject.hairdresserMSContext.Settings.FirstOrDefault(x => x.Id == "77c8da8c22aa4743a2435e9479fd60f4");
            if (workplace != null)
            {
                workplace.WorkplaceName = txtName.Text;
                workplace.WorkplaceAddress = txtAddress.Text;
                workplace.WorkplacePhone = txtPhone.Text;
                workplace.WorkplaceAuthority = txtAuthority.Text;
                workplace.UpdatedAtTime = DateTime.Now;
                baseFormObject.hairdresserMSContext.Settings.Update(workplace);
                baseFormObject.hairdresserMSContext.SaveChanges();
                MessageBox.Show("İşyeri bilgileri başarıyla güncellendi.", "HairdresserManagementSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {
            if (txtEmployeeName.Text != string.Empty && txtEmployeeEmail.Text != string.Empty && txtEmployeePhone.Text != string.Empty && txtEmployeePassword.Text != string.Empty && comboBoxEmployeeType.SelectedIndex != -1)
            {
                Employee newEmployee = new Employee();
                newEmployee.NameSurname = txtEmployeeName.Text;
                newEmployee.Email = txtEmployeeEmail.Text;
                newEmployee.Password = txtEmployeePassword.Text;
                newEmployee.Phone = txtEmployeePhone.Text;
                newEmployee.Type = (EmployeeType)comboBoxEmployeeType.SelectedItem;

                baseFormObject.hairdresserMSContext.Employees.Add(newEmployee);
                baseFormObject.hairdresserMSContext.SaveChanges();
                MessageBox.Show("Yeni personel başarıyla eklendi.", "HairdresserManagementSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataList();
            }
        }

        private string selectedEmployeeId;
        private void dataGridViewEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0)
            {
                var employeeId = dataGridViewEmployee.Rows[rowIndex].Cells["Id"].Value.ToString();
                selectedEmployeeId = employeeId;
                var employee = baseFormObject.hairdresserMSContext.Employees.FirstOrDefault(x => x.Id == employeeId);

                if (employee != null)
                {
                    txtEmployeeName.Text = employee.NameSurname;
                    txtEmployeeEmail.Text = employee.Email;
                    txtEmployeePassword.Text = employee.Password;
                    txtEmployeePhone.Text = employee.Phone;
                    comboBoxEmployeeType.SelectedItem = employee.Type;
                }
            }
        }

        private void dataGridViewEmployee_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewEmployee.Columns[e.ColumnIndex].Name == "Password" && e.Value != null)
            {
                e.Value = new string('*', 5);
            }
        }

        private void btnEmployeeUpdate_Click(object sender, EventArgs e)
        {
            var selectedEmployee = baseFormObject.hairdresserMSContext.Employees.FirstOrDefault(x => x.Id == selectedEmployeeId);
            if (selectedEmployee != null)
            {
                selectedEmployee.NameSurname = txtEmployeeName.Text;
                selectedEmployee.Email = txtEmployeeEmail.Text;
                selectedEmployee.Password = txtEmployeePassword.Text;
                selectedEmployee.Phone = txtEmployeePhone.Text;
                selectedEmployee.Type = (EmployeeType)comboBoxEmployeeType.SelectedItem;
                selectedEmployee.UpdatedAtTime = DateTime.Now;
                baseFormObject.hairdresserMSContext.Employees.Update(selectedEmployee);
                baseFormObject.hairdresserMSContext.SaveChanges();
                MessageBox.Show("Personel başarıyla güncellendi.", "HairdresserManagementSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataList();
            }
        }

        private void btnEmployeeDelete_Click(object sender, EventArgs e)
        {
            var selectedEmployee = baseFormObject.hairdresserMSContext.Employees.FirstOrDefault(x => x.Id == selectedEmployeeId);
            if (selectedEmployee != null)
            {
                selectedEmployee.IsDeleted = true;
                selectedEmployee.DeletedAtTime = DateTime.Now;
                baseFormObject.hairdresserMSContext.Employees.Update(selectedEmployee);
                baseFormObject.hairdresserMSContext.SaveChanges();
                MessageBox.Show("Personel başarıyla silindi.", "HairdresserManagementSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataList();
            }
        }

        private void btnChairAdd_Click(object sender, EventArgs e)
        {
            if (txtChairName.Text != string.Empty && comboBoxChairEmployee.SelectedIndex != -1)
            {
                var selectedEmployeeId = comboBoxChairEmployee.SelectedValue.ToString();
                var selectedEmployee = baseFormObject.hairdresserMSContext.Employees.FirstOrDefault(x => x.Id == selectedEmployeeId);

                Chair newChair = new Chair();
                newChair.Name = txtChairName.Text;
                newChair.Employee = selectedEmployee;
                newChair.OrderId = string.Empty;

                baseFormObject.hairdresserMSContext.Chairs.Add(newChair);
                baseFormObject.hairdresserMSContext.SaveChanges();
                MessageBox.Show("Yeni Koltuk başarıyla eklendi.", "HairdresserManagementSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataList();
            }
        }

        private void dataGridViewChair_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewChair.Columns[e.ColumnIndex].Name == "Employee" && e.Value != null)
            {
                var employee = (Employee)e.Value;
                e.Value = employee?.NameSurname ?? "Yok";
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
                var chair = baseFormObject.hairdresserMSContext.Chairs.FirstOrDefault(x => x.Id == chairId);

                if (chair != null)
                {
                    txtChairName.Text = chair.Name;
                    comboBoxChairEmployee.SelectedItem = chair.Employee;
                }
            }
        }

        private void btnChairUpdate_Click(object sender, EventArgs e)
        {
            var selectedChair = baseFormObject.hairdresserMSContext.Chairs.FirstOrDefault(x => x.Id == selectedChairId);
            var selectedEmployee = baseFormObject.hairdresserMSContext.Employees.FirstOrDefault(x => x.Id == comboBoxChairEmployee.SelectedValue);

            if (selectedChair != null)
            {
                selectedChair.Name = txtChairName.Text;
                selectedChair.Employee = selectedEmployee;
                selectedChair.UpdatedAtTime = DateTime.Now;
                baseFormObject.hairdresserMSContext.Chairs.Update(selectedChair);
                baseFormObject.hairdresserMSContext.SaveChanges();
                MessageBox.Show("Koltuk başarıyla güncellendi.", "HairdresserManagementSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataList();
            }
        }

        private void btnChairDelete_Click(object sender, EventArgs e)
        {
            var selectedChair = baseFormObject.hairdresserMSContext.Chairs.FirstOrDefault(x => x.Id == selectedChairId);
            if (selectedChair != null)
            {
                selectedChair.IsDeleted = true;
                selectedChair.DeletedAtTime = DateTime.Now;
                baseFormObject.hairdresserMSContext.Chairs.Update(selectedChair);
                baseFormObject.hairdresserMSContext.SaveChanges();
                MessageBox.Show("Koltuk başarıyla silindi.", "HairdresserManagementSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataList();
            }
        }

        private string selectedCategoryId;
        private void dataGridViewCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0)
            {
                var categoryId = dataGridViewCategory.Rows[rowIndex].Cells["Id"].Value.ToString();
                selectedCategoryId = categoryId;
                var category = baseFormObject.hairdresserMSContext.Categories.FirstOrDefault(x => x.Id == categoryId);

                if (category != null)
                {
                    txtCategoryName.Text = category.Name;
                }
            }
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text != string.Empty)
            {
                Category newCategory = new Category();
                newCategory.Name = txtCategoryName.Text;

                baseFormObject.hairdresserMSContext.Categories.Add(newCategory);
                baseFormObject.hairdresserMSContext.SaveChanges();
                MessageBox.Show("Yeni Kategori başarıyla eklendi.", "HairdresserManagementSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataList();
            }
        }

        private void btnCategoryUpdate_Click(object sender, EventArgs e)
        {
            var selectedCategory = baseFormObject.hairdresserMSContext.Categories.FirstOrDefault(x => x.Id == selectedCategoryId);

            if (selectedCategory != null)
            {
                selectedCategory.Name = txtCategoryName.Text;
                selectedCategory.UpdatedAtTime = DateTime.Now;
                baseFormObject.hairdresserMSContext.Categories.Update(selectedCategory);
                baseFormObject.hairdresserMSContext.SaveChanges();
                MessageBox.Show("Kategori başarıyla güncellendi.", "HairdresserManagementSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataList();
            }
        }

        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            var selectedCategory = baseFormObject.hairdresserMSContext.Categories.FirstOrDefault(x => x.Id == selectedCategoryId);
            if (selectedCategory != null)
            {
                selectedCategory.IsDeleted = true;
                selectedCategory.DeletedAtTime = DateTime.Now;
                baseFormObject.hairdresserMSContext.Categories.Update(selectedCategory);
                baseFormObject.hairdresserMSContext.SaveChanges();
                MessageBox.Show("Kategori başarıyla silindi.", "HairdresserManagementSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataList();
            }
        }

        private string selectedProductId;

        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0)
            {
                var productId = dataGridViewProduct.Rows[rowIndex].Cells["Id"].Value.ToString();
                selectedProductId = productId;
                var product = baseFormObject.hairdresserMSContext.Products.FirstOrDefault(x => x.Id == productId);

                if (product != null)
                {
                    comboBoxProductCategory.SelectedItem = product.Category;
                    txtProductName.Text = product.Name;
                    txtProductPrice.Text = product.Price.ToString();
                }
            }
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text != string.Empty && txtProductPrice.Text != string.Empty && comboBoxProductCategory.SelectedIndex != -1)
            {
                var selectedCategory = baseFormObject.hairdresserMSContext.Categories.FirstOrDefault(x => x.Id == comboBoxProductCategory.SelectedValue);

                Product newProduct = new Product();
                newProduct.Category = selectedCategory;
                newProduct.Name = txtProductName.Text;
                newProduct.Price = decimal.TryParse(txtProductPrice.Text, out var price) ? price : 0;

                baseFormObject.hairdresserMSContext.Products.Add(newProduct);
                baseFormObject.hairdresserMSContext.SaveChanges();
                MessageBox.Show("Yeni Ürün başarıyla eklendi.", "HairdresserManagementSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataList();
            }
        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            var selectedProduct = baseFormObject.hairdresserMSContext.Products.FirstOrDefault(x => x.Id == selectedProductId);
            var selectedCategory = baseFormObject.hairdresserMSContext.Categories.FirstOrDefault(x => x.Id == comboBoxProductCategory.SelectedValue);

            if (selectedProduct != null)
            {
                selectedProduct.Category = selectedCategory;
                selectedProduct.Name = txtProductName.Text;
                selectedProduct.Price = decimal.TryParse(txtProductPrice.Text, out var price) ? price : 0; ;
                selectedProduct.UpdatedAtTime = DateTime.Now;

                baseFormObject.hairdresserMSContext.Products.Update(selectedProduct);
                baseFormObject.hairdresserMSContext.SaveChanges();
                MessageBox.Show("Ürün başarıyla güncellendi.", "HairdresserManagementSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataList();
            }
        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            var selectedProduct = baseFormObject.hairdresserMSContext.Products.FirstOrDefault(x => x.Id == selectedProductId);
            if (selectedProduct != null)
            {
                selectedProduct.IsDeleted = true;
                selectedProduct.DeletedAtTime = DateTime.Now;
                baseFormObject.hairdresserMSContext.Products.Update(selectedProduct);
                baseFormObject.hairdresserMSContext.SaveChanges();
                MessageBox.Show("Ürün başarıyla silindi.", "HairdresserManagementSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataList();
            }
        }

        private void dataGridViewProduct_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewProduct.Columns[e.ColumnIndex].Name == "Category" && e.Value != null)
            {
                var category = (Category)e.Value;
                e.Value = category?.Name ?? "Yok";
            }
        }

        private void txtProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',' || e.KeyChar == '.') && (txtProductPrice.Text.Contains(",") || txtProductPrice.Text.Contains(".")))
            {
                e.Handled = true;
            }
        }
    }
}