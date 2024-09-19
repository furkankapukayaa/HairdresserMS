using HairdresserManagementSystem.UserInterface.Events;

namespace HairdresserManagementSystem.UserInterface
{
    public partial class Home : Form
    {
        public Home(string loggedInUserId)
        {
            InitializeComponent();
            timerCalendar.Start();
            _loggedInUserId = loggedInUserId;
        }

        private BaseFormObject baseFormObject = new BaseFormObject();
        private string _loggedInUserId;

        private void OpenLoginPage()
        {
            Application.Run(new Login());
        }

        private void OpenSettingsPage()
        {
            Application.Run(new Settings(_loggedInUserId));
        }
        private void OpenChairsPage()
        {
            Application.Run(new Chairs(_loggedInUserId));
        }

        private void OpenCustomersPage()
        {
            Application.Run(new Customer(_loggedInUserId));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            baseFormObject.thread = new Thread(OpenLoginPage);
            baseFormObject.thread.SetApartmentState(ApartmentState.STA);
            baseFormObject.thread.Start();
        }

        private void timerCalendar_Tick(object sender, EventArgs e)
        {
            lblCalendar.Text = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("Turkey Standard Time")).ToString("D") + "\n" + TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("Turkey Standard Time")).ToString("T");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Close();
            baseFormObject.thread = new Thread(OpenSettingsPage);
            baseFormObject.thread.SetApartmentState(ApartmentState.STA);
            baseFormObject.thread.Start();
        }

        private void btnChairs_Click(object sender, EventArgs e)
        {
            this.Close();
            baseFormObject.thread = new Thread(OpenChairsPage);
            baseFormObject.thread.SetApartmentState(ApartmentState.STA);
            baseFormObject.thread.Start();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            this.Close();
            baseFormObject.thread = new Thread(OpenCustomersPage);
            baseFormObject.thread.SetApartmentState(ApartmentState.STA);
            baseFormObject.thread.Start();
        }
    }
}