using EventDriven.Project.Controller;
using EventDriven.Project.Model;

namespace EventDriven.Project.UI
{
    public partial class GuestInformation : UserControl
    {
        private GuestController guestController;
        private CheckInController checkInController;
        public GuestInformation()
        {
            InitializeComponent();
            guestController = new GuestController();
            checkInController = new CheckInController();
        }

        private void GuestInformation_Load(object sender, EventArgs e)
        {
            LoadGuestInfo();
        }
        private void LoadGuestInfo()
        {
            var guests = guestController.GetAll();
            datagridGuestInfo.DataSource = guests;
            datagridGuestInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridGuestInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridGuestInfo.MultiSelect = false;
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (datagridGuestInfo.SelectedRows.Count > 0)
            {
                int guestId = Convert.ToInt32(datagridGuestInfo.SelectedRows[0].Cells["GuestID"].Value);
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

                if (Application.OpenForms["GuestCheckIn"] is Form checkInForm)
                {
                    var grid = (DataGridView)checkInForm.Controls["datagridGuestCheckInList"];
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

