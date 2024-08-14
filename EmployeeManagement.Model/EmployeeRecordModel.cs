using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Model
{
    public class EmployeeRecordModel
    {

        //this are the properties for employee record
        public int userId { get; set; }
        public int employeeId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string state { get; set; }
        public string DateOfBirth { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }

        public string country { get; set; }
        public string city { get; set; }
        public string pinCode { get; set; }
        public string designation { get; set; }
        public string Technology { get; set; }


        private HttpStatusCode internalServerError;

        public EmployeeRecordModel()
        {
        }

        public EmployeeRecordModel(HttpStatusCode internalServerError)
        {
            this.internalServerError = internalServerError;
        }

        
    }
}
