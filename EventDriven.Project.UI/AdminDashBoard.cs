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

namespace EventDriven.Project.UI
{
    public partial class AdminDashBoard : Form
    {
        public AdminDashBoard()
        {
            InitializeComponent();
        }

        private void LoadScreen(UserControl screen)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(screen);
            screen.Dock = DockStyle.Fill;
            screen.BringToFront();
        }

        private void btnGuestInfo_Click(object sender, EventArgs e)
        {
            LoadScreen(new AdminGuestInfo());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LogIn loginForm = new LogIn();
                loginForm.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadScreen(new CreateReservations());
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            LoadScreen(new AdminGuestCheckIn());
        }

        private void btnRoomMaintenance_Click(object sender, EventArgs e)
        {
            LoadScreen(new AdminRoomMaintenance());
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            LoadScreen(new GuestCheckOut());
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            LoadScreen(new Payment());
        }
    }
}
