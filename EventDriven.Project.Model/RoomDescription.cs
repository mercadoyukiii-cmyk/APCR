using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDriven.Project.Model
{
    public class RoomDescription
    {
        public int RoomTypeID { get; set; }
        public string RoomTypeName { get; set; }
        public string Description { get; set; }
        public decimal PricePerNight { get; set; }
        public int MaxOccupancy { get; set; }

    }
}
