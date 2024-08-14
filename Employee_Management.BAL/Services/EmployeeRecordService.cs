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
    public class EmployeeRecordService : ServiceBase,IEmployeeRecordService
    {
        IEmployeeRecordRepository _employeeRecordrepository; 
        public EmployeeRecordService()
        {
            _employeeRecordrepository = UnitOfWorks.EmployeeRecordRepository;
        }

        //private IEmployeeRecordRepository _employeeRecordRepository = UnitOfWork.EmployeeRecordRepository;
        public List<EmployeeRecordModel> GetEmployeeRecordList(UserModel model)
        {
            List<EmployeeRecordModel> listofEmployee = new List<EmployeeRecordModel>();
            listofEmployee = _employeeRecordrepository.GetEmployeeRecordList(model);
            return listofEmployee;

        }
        public int AddEmployee(EmployeeRecordModel model)
        {
            var listofEmployee = _employeeRecordrepository.AddEmployee(model);
            return listofEmployee;
        }
        public int UpdateEmployee(EmployeeRecordModel model)
        {
            var listofEmployee = _employeeRecordrepository.UpdateEmployee(model);
            return listofEmployee;
        }

        public int DeleteEmployee(EmployeeRecordModel model)
        {
            var listofEmployee = _employeeRecordrepository.DeleteEmployee(model);
            return listofEmployee;
        }
    }
}
