using Employee_Management.BAL.Services;
using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeManagement.API.Controllers
{


    public class EmployeeRecordController : BaseController
    {
        EmployeeRecordService _employeeRecordService;
        public EmployeeRecordController()
        {
            _employeeRecordService = UnitOfWork.EmployeeRecordService;
        }

        [HttpGet]
        public List<EmployeeRecordModel> GetEmployeeRecord(int userId)
        {
            UserModel model = new UserModel();
            model.userId = userId;
            EmployeeRecordModel response = new EmployeeRecordModel();
            List<EmployeeRecordModel> listofEmployee = new List<EmployeeRecordModel>();
            var result = _employeeRecordService.GetEmployeeRecordList(model);
            return result;
        }
        [HttpPost]
        public APIResponse AddEmployee(EmployeeRecordModel model)
        {

            var result = _employeeRecordService.AddEmployee(model);
            var response = new APIResponse(status: result == -1, code: "", message: result == -1 ? "" : "Something went wrong");

            return response;
        }
        [HttpDelete]
        public int DeleteEmployee(EmployeeRecordModel model)
        {
            var result = _employeeRecordService.DeleteEmployee(model);
            return result;
        }

        [HttpPut]
        public int UpdateEmployee(EmployeeRecordModel model)
        {

            var result = _employeeRecordService.UpdateEmployee(model);
            return result;
        }


    }


}
