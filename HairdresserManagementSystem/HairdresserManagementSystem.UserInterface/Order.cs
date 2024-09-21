using HairdresserManagementSystem.Entity.DomainObject;
using HairdresserManagementSystem.UserInterface.Events;

namespace HairdresserManagementSystem.UserInterface
{
    public partial class Order : Form
    {
        public Order(string loggedInUserId)
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
            dataGridViewOrder.DataSource = baseFormObject.hairdresserMSContext.Orders.Where(x => x.IsDeleted == false).OrderByDescending(x => x.CreatedAtTime).ToList();

            dataGridViewOrder.Columns["Id"].Visible = false;
            dataGridViewOrder.Columns["IsDeleted"].Visible = false;
            dataGridViewOrder.Columns["CreatedAtTime"].Visible = false;
            dataGridViewOrder.Columns["UpdatedAtTime"].Visible = false;
            dataGridViewOrder.Columns["DeletedAtTime"].Visible = false;
            dataGridViewOrder.Columns["Status"].Visible = false;

            dataGridViewOrder.Columns["Employee"].HeaderText = "Personel";
            dataGridViewOrder.Columns["Customer"].HeaderText = "Müşteri";
            dataGridViewOrder.Columns["Description"].HeaderText = "Not";
            dataGridViewOrder.Columns["Products"].HeaderText = "Hizmetler";
            dataGridViewOrder.Columns["Tip"].HeaderText = "Bahşiş";
            dataGridViewOrder.Columns["Discount"].HeaderText = "İndirim";
            dataGridViewOrder.Columns["Amount"].HeaderText = "Toplam";
            dataGridViewOrder.Columns["PaymentType"].HeaderText = "Ödeme Türü";
            dataGridViewOrder.Columns["ChairName"].HeaderText = "Koltuk";

            dataGridViewOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewOrder.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridViewOrder.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewOrder.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold);
            dataGridViewOrder.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewOrder.EnableHeadersVisualStyles = false;
            dataGridViewOrder.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewOrder.AllowUserToResizeRows = false;
        }

        private void dataGridViewOrder_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewOrder.Columns[e.ColumnIndex].Name == "Employee" && e.Value != null)
            {
                var employee = (Employee)e.Value;
                e.Value = employee?.NameSurname ?? "Yok";
            }

            if (dataGridViewOrder.Columns[e.ColumnIndex].Name == "Customer" && e.Value != null)
            {
                var customer = (Entity.DomainObject.Customer)e.Value;
                e.Value = customer?.NameSurname ?? "Yok";
            }
        }
    }
}