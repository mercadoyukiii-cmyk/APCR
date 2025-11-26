using EventDriven.Project.Model;
using EventDriven.Project.Controller;
using System.Diagnostics.Eventing.Reader;
using System.CodeDom.Compiler;

namespace EventDriven.Project.UI
{
    public partial class GuestCheckIn : UserControl
    {
        private CheckInController checkincontroller;
        public GuestCheckIn()
        {
            InitializeComponent();
            checkincontroller = new CheckInController();
        }

        private void LoadCheckInList()
        {
            datagridCheckInList.DataSource = checkincontroller.GetAll();
            datagridCheckInList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridCheckInList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridCheckInList.MultiSelect = false;
        }

        private void GuestCheckIn_Load(object sender, EventArgs e)
        {
            LoadCheckInList();
        }

        private void btnSearchGuest_Click(object sender, EventArgs e)
        {
            string searchValue = txtboxSearch.Text.Trim();
            List<CheckIn> results;

            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Please enter the name of the guest.", "Empty Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!string.IsNullOrEmpty(searchValue))
            {
                results = checkincontroller.SearchCheckInList(searchValue);
                if (results.Count == 0)
                {
                    MessageBox.Show("Guest not found in the Check-In list.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    results = checkincontroller.GetAll();
                }
                datagridCheckInList.DataSource = null;
                datagridCheckInList.DataSource = results;
                datagridCheckInList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCheckInList();
        }
    }
}
