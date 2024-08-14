using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.DAL.Interfaces
{
    public interface IADD_EmployeeRepository
    {
        List<ADD_EmployeeModel> GetCountryList();

    }
}
