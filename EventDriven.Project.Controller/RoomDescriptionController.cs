using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventDriven.Project.Model;
using EventDriven.Project.Repository;

namespace EventDriven.Project.Controller
{
    public class roomDescriptionController
    {
        private RoomDescriptionRepository roomdescriptionrepo;

        public roomDescriptionController()
        {
            roomdescriptionrepo = new RoomDescriptionRepository();
        }

        public List<RoomDescription> GetRooms()
        {
            return roomdescriptionrepo.GetAllRooms();
        }
    }
}
