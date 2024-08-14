using Employee_Management.BAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management.BAL.UOW
{
    public class UnitOfWork
    {
        private EmployeeRecordService _employeeRecordService;
        public EmployeeRecordService EmployeeRecordService
        {
            get { return _employeeRecordService ?? (_employeeRecordService = new EmployeeRecordService()); }
        }
        private LoginService loginservice;
        public LoginService LoginService
        {
            get { return loginservice ?? (loginservice = new LoginService()); }
        }
        private UserService _userService;
        public UserService UserService
        {
            get { return _userService ?? (_userService = new UserService()); }
        }
    }
}
