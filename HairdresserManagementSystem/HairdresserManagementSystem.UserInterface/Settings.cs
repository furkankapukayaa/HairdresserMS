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
    }
}