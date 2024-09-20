using HairdresserManagementSystem.UserInterface.Events;

namespace HairdresserManagementSystem.UserInterface
{
    public partial class Chairs : Form
    {
        public Chairs(string loggedInUserId)
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
            dataGridViewChair.DataSource = baseFormObject.hairdresserMSContext.Chairs.Where(x => x.IsDeleted == false).OrderByDescending(x => x.CreatedAtTime).ToList();

            dataGridViewChair.Columns["Id"].Visible = false;
            dataGridViewChair.Columns["IsDeleted"].Visible = false;
            dataGridViewChair.Columns["CreatedAtTime"].Visible = false;
            dataGridViewChair.Columns["UpdatedAtTime"].Visible = false;
            dataGridViewChair.Columns["DeletedAtTime"].Visible = false;
            dataGridViewChair.Columns["Status"].Visible = false;
            dataGridViewChair.Columns["Employee"].Visible = false;

            dataGridViewChair.Columns["Name"].HeaderText = "#";
            dataGridViewChair.Columns["ChairStatusType"].HeaderText = "Durum";

            dataGridViewChair.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewChair.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridViewChair.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewChair.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold);
            dataGridViewChair.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewChair.EnableHeadersVisualStyles = false;
            dataGridViewChair.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewChair.AllowUserToResizeRows = false;
        }
    }
}