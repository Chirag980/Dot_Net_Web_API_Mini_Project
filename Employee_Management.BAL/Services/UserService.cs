using Employee_Management.BAL.Interface;
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
    public class UserService : ServiceBase, IUserService
    {
        IUserRepository _userRepository;

        public UserService()
        {
            _userRepository = UnitOfWorks.UserRepository;
        }
        public List<UserModel> GetAllUserList()
        {
            List<UserModel> listofusers = new List<UserModel>();
            listofusers = _userRepository.GetAllUserList();
            return listofusers;
        }
        public List<UserModel> GetUserList_By_Name(string UserName)
        {
            List<UserModel> listofusers = new List<UserModel>();
            listofusers = _userRepository.GetUserList_By_Name(UserName);
            return listofusers;
        }
        public int InsertUser(UserModel usermodel)
        {
            var listOfUser = _userRepository.InsertUser(usermodel);
            return listOfUser;
        }
    }
}
