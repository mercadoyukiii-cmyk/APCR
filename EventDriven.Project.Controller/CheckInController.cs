using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventDriven.Project.Model;
using EventDriven.Project.Repository;

namespace EventDriven.Project.Controller
{
    public class CheckInController
    {
        private CheckInRepository CheckInRepository;

        public CheckInController()
        {
            CheckInRepository = new CheckInRepository();
        }

        public void ConfirmCheckIn(int CheckInID)
        {
            try
            {
                CheckInRepository.ConfirmCheckIn(CheckInID);
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public List<CheckIn> GetAll() 
        {
            try
            {
                return CheckInRepository.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AddCheckIn(CheckIn checkIn)
        {
            try
            {
                CheckInRepository.AddCheckIn(checkIn);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<CheckIn> SearchCheckInList(string name)
        {
            return CheckInRepository.SearchCheckInList(name);
        }

        public void RemoveCheckIn(int reservationId)
        {
            try
            {
                CheckInRepository.RemoveCheckIn(reservationId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
