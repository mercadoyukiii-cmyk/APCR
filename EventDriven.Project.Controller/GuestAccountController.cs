using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventDriven.Project.Repository;

namespace EventDriven.Project.Controller
{
    public class GuestAccountController
    {
        private GuestAccountRepository guestAccountRepository;
        public void Delete(int id)
        {
            if (id == 0) throw new Exception("missing parameter");

            try
            {
                guestAccountRepository.DeleteClient(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
