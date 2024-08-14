using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management.BAL.Interface
{
    interface ILoginService
    {
        List<LoginModel> CheckLogin(LoginModel log);
    }
}
