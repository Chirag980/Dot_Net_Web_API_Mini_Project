using Employee_Management.BAL.Services;
using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeManagement.API.Controllers
{
    public class LoginModelController : BaseController
    {
        LoginService loginservice;
        public LoginModelController()
        {
            loginservice = UnitOfWork.LoginService;
        }
        

        [HttpPost]
        public LoginModel CheckLogin(LoginModel log)
        {
            LoginModel response = new LoginModel();
            response = loginservice.CheckLogin(log);
            return response;
        }
    }
}
