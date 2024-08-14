using EmployeeManagement.DAL.Interfaces;
using EmployeeManagement.DAL.Respository;
using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.DAL.Repository
{
    public class EmployeeRecordRepository: RepositoryBase<EmployeeRecordModel>,IEmployeeRecordRepository
    {
        public EmployeeRecordRepository()
        {
            base.ConnectionString = base.GetConnectionString();
        }


        // Method name as GetEmployeeRecordList and here we create a list of employeeRecordModel
        public List<EmployeeRecordModel> GetEmployeeRecordList(UserModel model)
        {
            var sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("@userId", model.userId));
            var result = this.ExecuteReader("[dbo].[sp_getEmployee]", sqlParameters, MapEmployeeRecordModel, 10);
            return result;

        }

        protected void MapEmployeeRecordModel(EmployeeRecordModel employeeRecordModel, SqlDataReader dataReader, string[] columnNameList)
        {

            
            int employeeidindex = this.GetColumnOrdinal(columnNameList, "EmployeeID");
            if (employeeidindex >= 0 && !dataReader.IsDBNull(employeeidindex))
            {
                employeeRecordModel.employeeId = dataReader.GetFieldValue<int>(employeeidindex);
            }

            int employeefirstnamendex = this.GetColumnOrdinal(columnNameList, "FirstName");
            if (employeefirstnamendex > 0 && !dataReader.IsDBNull(employeefirstnamendex))
            {
                employeeRecordModel.firstName = dataReader.GetFieldValue<string>(employeefirstnamendex);
            }

            int employeelastnameindex = this.GetColumnOrdinal(columnNameList, "LastName");
            if (employeelastnameindex > 0 && !dataReader.IsDBNull(employeelastnameindex))
            {
                employeeRecordModel.lastName = dataReader.GetFieldValue<string>(employeelastnameindex);
            }
            int employeedateofbirth = this.GetColumnOrdinal(columnNameList, "dob");
            if (employeedateofbirth > 0 && !dataReader.IsDBNull(employeedateofbirth))
            {
                employeeRecordModel.DateOfBirth = dataReader.GetDateTime(employeedateofbirth).ToShortDateString();
            }

            int employeeaddress1index = this.GetColumnOrdinal(columnNameList, "Address1");
            if (employeeaddress1index > 0 && !dataReader.IsDBNull(employeeaddress1index))
            {
                employeeRecordModel.Address1 = dataReader.GetFieldValue<string>(employeeaddress1index);
            }

            int employeeaddress2index = this.GetColumnOrdinal(columnNameList, "Address2");
            if (employeeaddress2index > 0 && !dataReader.IsDBNull(employeeaddress2index))
            {
                employeeRecordModel.Address2 = dataReader.GetFieldValue<string>(employeeaddress2index);
            }

            int employecityeindex = this.GetColumnOrdinal(columnNameList, "City");
            if (employecityeindex > 0 && !dataReader.IsDBNull(employecityeindex))
            {
                employeeRecordModel.city = dataReader.GetFieldValue<string>(employecityeindex);
            }

            int employeeStateindex = this.GetColumnOrdinal(columnNameList, "State");
            if (employeeStateindex > 0 && !dataReader.IsDBNull(employeeStateindex))
            {
                employeeRecordModel.state = dataReader.GetFieldValue<string>(employeeStateindex);
            }

            int employepincodeindex = this.GetColumnOrdinal(columnNameList, "pincode");
            if (employepincodeindex > 0 && !dataReader.IsDBNull(employepincodeindex))
            {
                employeeRecordModel.pinCode = dataReader.GetFieldValue<string>(employepincodeindex);
            }

            int employeecountryindex = this.GetColumnOrdinal(columnNameList, "Country");
            if (employeecountryindex > 0 && !dataReader.IsDBNull(employeecountryindex))
            {
                employeeRecordModel.country = dataReader.GetFieldValue<string>(employeecountryindex);
            }

            int employeedesignationindex = this.GetColumnOrdinal(columnNameList, "Designation");
            if (employeedesignationindex > 0 && !dataReader.IsDBNull(employeedesignationindex))
            {
                employeeRecordModel.designation = dataReader.GetFieldValue<string>(employeedesignationindex);
            }

            int employeetechnologyindex = this.GetColumnOrdinal(columnNameList, "Technology");
            if (employeetechnologyindex > 0 && !dataReader.IsDBNull(employeetechnologyindex))
            {
                employeeRecordModel.Technology = dataReader.GetFieldValue<string>(employeetechnologyindex);
            }


        }
        public int AddEmployee(EmployeeRecordModel model)
        {
            var sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("@userId", model.userId));
            sqlParameters.Add(new SqlParameter("@firstname", model.firstName));
            sqlParameters.Add(new SqlParameter("@lastname", model.lastName));
            sqlParameters.Add(new SqlParameter("@city", model.city));
            sqlParameters.Add(new SqlParameter("@state", model.state));
            sqlParameters.Add(new SqlParameter("@pincode", model.pinCode));
            sqlParameters.Add(new SqlParameter("@dob", DateTime.ParseExact(model.DateOfBirth,"dd/MM/yyyy",null)));
            sqlParameters.Add(new SqlParameter("@designation", model.designation));
            sqlParameters.Add(new SqlParameter("@address1", model.Address1));
            sqlParameters.Add(new SqlParameter("@address2", model.Address2));
            sqlParameters.Add(new SqlParameter("@country", model.country));
            sqlParameters.Add(new SqlParameter("@technology", model.Technology));
            var result = this.ExecuteNonQuery("[dbo].[sp_addEmployee]", sqlParameters, 10);
            return result;
        }


        public int DeleteEmployee(EmployeeRecordModel model)
        {
            var sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("@EmployeeId", model.employeeId));
            return this.ExecuteNonQuery("[dbo].[sp_deleteEmployee]", sqlParameters, 10);
            //return result;
        }
        public int UpdateEmployee(EmployeeRecordModel model)
        {
            var sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("@userId", model.userId));
            sqlParameters.Add(new SqlParameter("@EmployeeId", model.employeeId));
            sqlParameters.Add(new SqlParameter("@firstName", model.firstName));
            sqlParameters.Add(new SqlParameter("@lastName", model.lastName));
            sqlParameters.Add(new SqlParameter("@city", model.city));
            sqlParameters.Add(new SqlParameter("@state", model.state));
            sqlParameters.Add(new SqlParameter("@pincode", model.pinCode));
            sqlParameters.Add(new SqlParameter("@dob", DateTime.ParseExact(model.DateOfBirth,"dd-MM-yyyy",null)));
            sqlParameters.Add(new SqlParameter("@designation", model.designation));
            sqlParameters.Add(new SqlParameter("@address1", model.Address1));
            sqlParameters.Add(new SqlParameter("@address2", model.Address2));
            sqlParameters.Add(new SqlParameter("@country", model.country));
            sqlParameters.Add(new SqlParameter("@technology", model.Technology));
            var result = this.ExecuteNonQuery("[dbo].[sp_updateEmployee]", sqlParameters, 10);
            return result;
        }
    }
}
