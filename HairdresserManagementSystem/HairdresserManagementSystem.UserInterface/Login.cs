using HairdresserManagementSystem.UserInterface.Events;

namespace HairdresserManagementSystem.UserInterface
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            AppSettings appSettings = new AppSettings();
            appSettings.CreateAdmin();
        }

        private BaseFormObject baseFormObject = new BaseFormObject();
        private string loggedInUserId;
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (MailTextBox.Text != string.Empty && PasswordTextBox.Text != string.Empty)
            {
                var mailControl = baseFormObject.hairdresserMSContext.Employees.FirstOrDefault(x => x.Email == MailTextBox.Text);
                if (mailControl == null)
                {
                    MessageBox.Show("Bu mail hesabına sahip bir kullanıcı bulunmamaktadır.", "HairdresserManagementSystem - Hatalı Mail Adresi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (mailControl.IsDeleted == true)
                    {
                        MessageBox.Show("Bu maile sahip bir kullanıcı bulunmamaktadır.", "HairdresserManagementSystem - Hatalı Mail Adresi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (mailControl.Status == false)
                    {
                        MessageBox.Show("Lütfen aktif bir kullanıcı ile giriniz.", "HairdresserManagementSystem - Hatalı Kullanıcı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var passwordControl = baseFormObject.hairdresserMSContext.Employees.FirstOrDefault(x => x.Email == MailTextBox.Text && x.Password == PasswordTextBox.Text && x.Status == true && x.IsDeleted == false);
                    if (passwordControl == null)
                    {
                        MessageBox.Show("Hatalı şifre girdiniz.", "HairdresserManagementSystem - Hatalı Şifre!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("HairdresserManagementSystem'e Hoş geldiniz! Panele yönlendiriliyorsunuz!", "HairdresserManagementSystem - Hoş Geldiniz!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loggedInUserId = passwordControl.Id;

                        this.Close();
                        baseFormObject.thread = new Thread(OpenHomePage);
                        baseFormObject.thread.SetApartmentState(ApartmentState.STA);
                        baseFormObject.thread.Start();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "HairdresserManagementSystem - Hatalı Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenHomePage(object obj)
        {
            Application.Run(new Home(loggedInUserId));
        }
    }
}