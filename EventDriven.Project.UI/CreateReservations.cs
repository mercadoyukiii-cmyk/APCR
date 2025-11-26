using EventDriven.Project.Controller;
using EventDriven.Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDriven.Project.UI
{
    public partial class CreateReservations : UserControl
    {
        private RoomController roomController;
        private roomDescriptionController roomDescriptionController;

        public CreateReservations()
        {
            InitializeComponent();
            roomController = new RoomController();
            roomDescriptionController = new roomDescriptionController();
        }

        private void CreateReservations_Load(object sender, EventArgs e)
        {
            List<Room> rooms = roomController.GetRooms();
            datagridAvailableRooms.DataSource = rooms;
            datagridAvailableRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridAvailableRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridAvailableRooms.MultiSelect = false;

            try
            {
                List<RoomDescription> roomDescriptions = roomDescriptionController.GetRooms();
                datagridRoomDetails.DataSource = roomDescriptions;
                datagridRoomDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                datagridRoomDetails.Enabled = false;
                datagridRoomDetails.RowHeadersVisible= false;
                datagridRoomDetails.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading room data: " + ex.Message);
            }
        }

    }

}
