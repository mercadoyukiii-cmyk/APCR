using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDriven.Project.Model
{
    public class Account
    {
        public int Id { get; set; }
        public decimal Balance { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guest guest { get; set; }
    }
}

