using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDriven.Project.Model
{
    public class Room
    {
        public int RoomID { get; set; }

        public string RoomNumber { get; set; }

        public int RoomTypeID { get; set; }

        public int RoomCapacity { get; set; }
    }
}
