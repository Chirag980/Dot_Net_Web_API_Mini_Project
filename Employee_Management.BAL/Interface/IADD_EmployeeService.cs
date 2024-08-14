using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management.BAL.Interface
{
    public interface IADD_EmployeeService
    {
        List<ADD_EmployeeModel> GetCountryList();

    }
}
