using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventDriven.Project.Controller;
using EventDriven.Project.Model;

namespace EventDriven.Project.UI
{
    public partial class AdminGuestCheckIn : UserControl
    {
        private CheckInController checkincontroller;
        public AdminGuestCheckIn()
        {
            InitializeComponent();
            checkincontroller = new CheckInController();
        }
        private void LoadCheckInList()
        {
            datagridAdminCheckInList.DataSource = checkincontroller.GetAll();
            datagridAdminCheckInList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridAdminCheckInList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridAdminCheckInList.MultiSelect = false;
        }

        private void AdminGuestCheckIn_Load(object sender, EventArgs e)
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
                datagridAdminCheckInList.DataSource = null;
                datagridAdminCheckInList.DataSource = results;
                datagridAdminCheckInList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCheckInList();
        }

        private void tbnDelete_Click(object sender, EventArgs e)
        {
            if (datagridAdminCheckInList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a check-in record to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int reservationId = Convert.ToInt32(datagridAdminCheckInList.SelectedRows[0].Cells["ReservationID"].Value);

            var confirm = MessageBox.Show("Are you sure you want to delete this check-in record?",
                                          "Confirm Delete",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    checkincontroller.RemoveCheckIn(reservationId);
                    MessageBox.Show("Check-in record deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    datagridAdminCheckInList.DataSource = checkincontroller.GetAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
