using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Model
{
    public class ADD_EmployeeModel
    {
        private HttpStatusCode internalServerError;
        public ADD_EmployeeModel()
        {

        }
        public ADD_EmployeeModel(HttpStatusCode internalServerError)
        {
            this.internalServerError = internalServerError;
        }
        //public int Country_Id { get; set; }
        //public string Country_Name { get; set; }
        public int Country_Id { get; set; }
        public string Country_Name { get; set; }
    }
}
