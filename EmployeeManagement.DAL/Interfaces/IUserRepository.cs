using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.DAL.Interfaces
{
    public interface IUserRepository
    {
        int InsertUser(UserModel usermodel);
        List<UserModel> GetAllUserList();
        List<UserModel> GetUserList_By_Name(string UserName);
    }
}
