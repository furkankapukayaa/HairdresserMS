using HairdresserManagementSystem.UserInterface.Events;

namespace HairdresserManagementSystem.UserInterface
{
    public partial class Order : Form
    {
        public Order(string loggedInUserId)
        {
            InitializeComponent();
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
    }
}