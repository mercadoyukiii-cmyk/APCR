using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventDriven.Project.Model;
using EventDriven.Project.Repository;

namespace EventDriven.Project.Controller
{
    public class RoomController
    {
        private RoomRepository roomrepo;


        public RoomController()
        {
            roomrepo = new RoomRepository();
        }
        public int GetTotalRooms()
        {
            try
            {
                return roomrepo.GetTotalRooms();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int GetOccupiedRooms()
        {
            try
            {
                return roomrepo.GetOccupiedRooms();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Room> GetRooms()
        {
            try
            {
                return roomrepo.GetRooms();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }

}    

