using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Model
{
    public class UserModel
    {
        public int userId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        //public string Email { get; set; }

        //public string Mobile { get; set; }

        //public string Address { get; set; }

        //public string State { get; set; }

        //public string Country { get; set; }

        public string Gender { get; set; }


        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
        public string UserName { get; set; }
    }
}
