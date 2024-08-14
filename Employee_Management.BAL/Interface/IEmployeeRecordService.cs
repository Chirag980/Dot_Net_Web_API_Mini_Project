﻿using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management.BAL.Interface
{
    public interface IEmployeeRecordService
    {
        List<EmployeeRecordModel> GetEmployeeRecordList(UserModel model);
        int AddEmployee(EmployeeRecordModel model);
        int UpdateEmployee(EmployeeRecordModel model);
        int DeleteEmployee(EmployeeRecordModel model);

    }
}
