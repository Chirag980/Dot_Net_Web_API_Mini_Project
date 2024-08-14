using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management.BAL.Interface
{
    public interface IUserService
    {
        List<UserModel> GetAllUserList();

        int InsertUser(UserModel usermodel);


    }
}
