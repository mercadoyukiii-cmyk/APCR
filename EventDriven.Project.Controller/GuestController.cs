using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventDriven.Project.Model;
using EventDriven.Project.Repository;

namespace EventDriven.Project.Controller
{
    public class GuestController
    {
        private GuestRepository guestrepo;

        public GuestController()
        {
            guestrepo = new GuestRepository();
        }

        public void AddGuest(Guest guest)
        {
            try
            {
                guestrepo.AddGuest(guest);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Guest> GetAll()
        {
            try
            {
                return guestrepo.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Delete(int GuestId)
        {
            guestrepo.Delete(GuestId);
        }
        public List<Guest> SearchGuest(string name)
        {
            try
            {
                return guestrepo.SearchGuest(name);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateGuest(Guest guest)
        {
            try
            {
                guestrepo.UpdateGuest(guest);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }


}

