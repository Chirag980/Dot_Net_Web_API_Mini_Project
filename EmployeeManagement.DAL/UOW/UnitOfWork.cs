using EmployeeManagement.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.DAL.UOW
{
    public class UnitOfWork
    {
        //Approach for encapsulation: Encapsulation is to make sure that "sensitive" data is hidden from users.
         
        private EmployeeRecordRepository _employeeRecordRepository;  //this is a field

        public EmployeeRecordRepository EmployeeRecordRepository    //This is property
        {
            get { return _employeeRecordRepository ?? (_employeeRecordRepository = new EmployeeRecordRepository()); }
        }
        private ADD_EmployeeRepository _aDD_EmployeeRepository;
        public ADD_EmployeeRepository ADD_EmployeeRepository
        {
            get { return _aDD_EmployeeRepository ?? (_aDD_EmployeeRepository = new ADD_EmployeeRepository()); }
        }

        private LoginRepository loginrepository;
        public LoginRepository LoginRepository
        {
            get { return loginrepository ?? (loginrepository = new LoginRepository()); }
        }

        private UserRepository _userRepository;

        public UserRepository UserRepository
        {
            get { return _userRepository ?? (_userRepository = new UserRepository()); }
        }

    }
}
