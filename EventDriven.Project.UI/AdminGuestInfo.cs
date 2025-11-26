using EventDriven.Project.Controller;
using EventDriven.Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDriven.Project.UI
{
    public partial class AdminGuestInfo : UserControl
    {
        private GuestController guestController;
        private CheckInController checkInController;
        public AdminGuestInfo()
        {
            InitializeComponent();
            guestController = new GuestController();
            checkInController = new CheckInController();
        }

        private void AdminGuestInfo_Load(object sender, EventArgs e)
        {
            LoadGuestInfo();
        }

        private void LoadGuestInfo()
        {
            var guests = guestController.GetAll();
            datagridAdminGuestInfo.DataSource = guests;
            datagridAdminGuestInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridAdminGuestInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridAdminGuestInfo.MultiSelect = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchGuest = txtboxSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchGuest))
            {
                MessageBox.Show("Please enter name of Guest.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                GuestController guestController = new GuestController();
                List<Guest> results = guestController.SearchGuest(searchGuest);

                if (results.Count > 0)
                {
                    datagridAdminGuestInfo.DataSource = results;
                }
                else
                {
                    MessageBox.Show("No guests found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGuestInfo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadGuestInfo();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (datagridAdminGuestInfo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Guest to remove.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int selectedGuestId = Convert.ToInt32(datagridAdminGuestInfo.SelectedRows[0].Cells["GuestID"].Value);

            DialogResult confirm = MessageBox.Show("Are you sure you want to remove this guest from the list?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    GuestController guestController = new GuestController();
                    guestController.Delete(selectedGuestId);

                    MessageBox.Show("Guest deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    datagridAdminGuestInfo.DataSource = guestController.GetAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting guest: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (datagridAdminGuestInfo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a guest to edit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow row = datagridAdminGuestInfo.SelectedRows[0];

            Guest selectedGuest = new Guest
            {
                GuestID = Convert.ToInt32(row.Cells["GuestID"].Value),
                FirstName = row.Cells["FirstName"].Value.ToString(),
                LastName = row.Cells["LastName"].Value.ToString(),
                MiddleInitial = row.Cells["MiddleInitial"].Value.ToString()[0],
                DateOfBirth = Convert.ToDateTime(row.Cells["DateOfBirth"].Value),
                Sex = row.Cells["Sex"].Value.ToString()[0],
                ContactNumber = row.Cells["ContactNumber"].Value.ToString(),
                Email = row.Cells["Email"].Value.ToString(),
                Address = row.Cells["Address"].Value.ToString(),
                EmergencyContact = row.Cells["EmergencyContact"].Value.ToString()
            };
            using (GuestInfoEdit editForm = new GuestInfoEdit())
            {
                editForm.LoadGuest(selectedGuest);

                if (editForm.ShowDialog() == DialogResult.OK)
                {

                    GuestController guestController = new GuestController();
                    datagridAdminGuestInfo.DataSource = guestController.GetAll();
                }
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (datagridAdminGuestInfo.SelectedRows.Count > 0)
            {
                int guestId = Convert.ToInt32(datagridAdminGuestInfo.SelectedRows[0].Cells["GuestID"].Value);
                var existingCheckIns = checkInController.GetAll();
                bool alreadyCheckedIn = existingCheckIns.Any(r => r.GuestID == guestId);

                if (alreadyCheckedIn)
                {
                    MessageBox.Show("This guest is already checked in.", "Check-In Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                CheckIn newChecknIn = new CheckIn
                {
                    GuestID = guestId,
                    RoomID = 1,
                    CheckInDate = DateTime.Today,
                    CheckOutDate = DateTime.Today.AddDays(1),
                    Status = "Confirmed"
                };

                checkInController.AddCheckIn(newChecknIn);
                MessageBox.Show("Guest successfully checked in!", "Check-In Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (Application.OpenForms["AdminGuestCheckIn"] is Form checkInForm)
                {
                    var grid = (DataGridView)checkInForm.Controls["datagridAdminGuestInfo"];
                    grid.DataSource = checkInController.GetAll();
                }
            }
            else
            {
                MessageBox.Show("Please Select a Guest to Check-In.");
            }
        }
    }
}


