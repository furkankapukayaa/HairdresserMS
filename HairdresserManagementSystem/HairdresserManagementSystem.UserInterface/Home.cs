﻿using HairdresserManagementSystem.UserInterface.Events;

namespace HairdresserManagementSystem.UserInterface
{
    public partial class Home : Form
    {
        public Home(string onlineUserId)
        {
            InitializeComponent();
            FormDesign();
        }

        private BaseFormObject baseFormObject = new BaseFormObject();

        public void FormDesign()
        {
            timerCalendar.Start();

            btnChairs.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnChairs.FlatAppearance.MouseDownBackColor = Color.Transparent;

            btnAppointments.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAppointments.FlatAppearance.MouseDownBackColor = Color.Transparent;

            btnOrders.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnOrders.FlatAppearance.MouseDownBackColor = Color.Transparent;

            btnCustomers.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCustomers.FlatAppearance.MouseDownBackColor = Color.Transparent;

            btnSettings.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSettings.FlatAppearance.MouseDownBackColor = Color.Transparent;

            btnLogout.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }

        private void OpenLoginPage()
        {
            Application.Run(new Login());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HairdresserMS İyi günler diler! Girişe yönlendiriliyorsunuz!", "HairdresserManagementSystem - Güle Güle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            baseFormObject.thread = new Thread(OpenLoginPage);
            baseFormObject.thread.SetApartmentState(ApartmentState.STA);
            baseFormObject.thread.Start();
        }

        private void timerCalendar_Tick(object sender, EventArgs e)
        {
            lblCalendar.Text = DateTime.Now.ToLongDateString() + "\n" + DateTime.Now.ToLongTimeString();
        }
    }
}