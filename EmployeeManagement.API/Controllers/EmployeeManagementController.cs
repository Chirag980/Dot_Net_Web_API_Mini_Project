using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeManagement.API.Controllers
{
    public class EmployeeManagementController : ApiController
    {
        [HttpGet]
        public List<EmployeeManagementModel> GetEmployeeList()
        {
            List<EmployeeManagementModel> listofEmployee = new List<EmployeeManagementModel>();
            EmployeeManagementModel emp = new EmployeeManagementModel();
            emp.EmployeeId = 1;
            emp.EmployeeName = "Chirag Sahu";
            listofEmployee.Add(emp);
            EmployeeManagementModel emp1 = new EmployeeManagementModel();
            emp1.EmployeeId = 2;
            emp1.EmployeeName = "Abhishek kumar";
            listofEmployee.Add(emp1);
            return listofEmployee;
        }
    }

    
}
