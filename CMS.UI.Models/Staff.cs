using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.UI.Models
{
    public class Staff
    {
        public string FirstName { get; set; }
        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        
    }

    class StaffDetails
    {
        
    }

    interface IStaffDetails
    {
        
    }
}