using Employee_Management.BAL.Services;
using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace EmployeeManagement.API.Controllers
{
    public class UserController : BaseController
    {
        UserService _userService;

        public UserController()
        {
            _userService = UnitOfWork.UserService;
        }

        [HttpGet]
        public List<UserModel> GetAllUserList()
        {
            UserModel response = new UserModel();
            List<UserModel> userMasterModel = new List<UserModel>();
            var result = _userService.GetAllUserList();
            return result;
        }

        [HttpGet]
        public List<UserModel> GetUserList_By_Name(string UserName)
        {
            UserModel response = new UserModel();
            List<UserModel> userMasterModel = new List<UserModel>();
            var result = _userService.GetUserList_By_Name(UserName);
            return result;
        }

        [HttpPost]
        public int InsertUser(UserModel usermodel)
        {
            //HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.InternalServerError);

            var result = _userService.InsertUser(usermodel);
            return result;
        }



    }
}