using EmployeeManagement.BAL.Services;
using EmployeeManagement.DAL.Interfaces;
using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management.BAL.Services
{
    public class LoginService:ServiceBase
    {
        ILoginRepository loginrepository;
        public LoginService()
        {
            loginrepository = UnitOfWorks.LoginRepository;
        }
        public LoginModel CheckLogin(LoginModel log)
        {
            LoginModel response = new LoginModel();
            response = loginrepository.CheckLogin(log);
            return response;
        }
    }
}
