using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.DAL.Interfaces
{
    public interface IEmployeeRecordRepository
    {
        List<EmployeeRecordModel> GetEmployeeRecordList(UserModel model);
        int AddEmployee(EmployeeRecordModel model);
        int UpdateEmployee(EmployeeRecordModel model);
        int DeleteEmployee(EmployeeRecordModel model);



    }
}
