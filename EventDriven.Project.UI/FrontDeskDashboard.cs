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
    public partial class FrontDeskDashboard : Form
    {
        public FrontDeskDashboard()
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrontDeskDashboard dashboard = new FrontDeskDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void btnGuestInfo_Click(object sender, EventArgs e)
        {
            LoadScreen(new GuestInformation());
        }

        private void btnCreateReservations_Click(object sender, EventArgs e)
        {
            LoadScreen(new CreateReservations());
        }

        private void btnRoomMaintenance_Click(object sender, EventArgs e)
        {
            LoadScreen(new AdminRoomMaintenance());
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            LoadScreen(new GuestCheckIn());
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            LoadScreen(new GuestCheckOut());
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            LoadScreen(new Payment());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?","Logout",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LogIn loginForm = new LogIn();
                loginForm.Show();
                this.Hide();
            }
        }
    }
}
