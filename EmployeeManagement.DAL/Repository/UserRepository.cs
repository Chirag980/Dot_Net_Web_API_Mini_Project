using EmployeeManagement.DAL.Interfaces;
using EmployeeManagement.DAL.Respository;
using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.DAL.Repository
{
    public class UserRepository : RepositoryBase<UserModel>, IUserRepository
    {
        public UserRepository()
        {
            base.ConnectionString = base.GetConnectionString();
        }

        public int InsertUser(UserModel usermodel)
        {
            var sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("@UserName", usermodel.UserName));
            sqlParameters.Add(new SqlParameter("@firstName", usermodel.FirstName));
            sqlParameters.Add(new SqlParameter("@lastName", usermodel.LastName));
            sqlParameters.Add(new SqlParameter("gender", usermodel.Gender));
            sqlParameters.Add(new SqlParameter("password", usermodel.Password));
            var result = this.ExecuteNonQuery("[dbo].[SP_InsertU]", sqlParameters, 10);
            return result;

        }

        public List<UserModel> GetAllUserList()
        {
            var sqlParameters = new List<SqlParameter>();

            var result = this.ExecuteReader("[dbo].[sp_getAllUser]", sqlParameters, MapUserMasterModel, 10);
            return result;
        }

        public List<UserModel> GetUserList_By_Name(string UserName)
        {
            var sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("@UserName", UserName));

            var result = this.ExecuteReader("[dbo].[sp_GET_USERS]", sqlParameters, MapUserMasterModel, 10);
            return result;
        }


        protected void MapUserMasterModel(UserModel userMasterModel, SqlDataReader dataReader, string[] columnNameList)
        {
            int employeeidindex = this.GetColumnOrdinal(columnNameList, "UserID");
            if (employeeidindex >= 0 && !dataReader.IsDBNull(employeeidindex))
            {
                userMasterModel.userId = dataReader.GetFieldValue<int>(employeeidindex);
            }

            int employeeNameindex = this.GetColumnOrdinal(columnNameList, "UserName");
            if (employeeNameindex >= 0 && !dataReader.IsDBNull(employeeNameindex))
            {
                userMasterModel.UserName = dataReader.GetFieldValue<string>(employeeNameindex);
            }

            int userfirstnameindex = this.GetColumnOrdinal(columnNameList, "firstname");
            if (userfirstnameindex > 0 && !dataReader.IsDBNull(userfirstnameindex))
            {
                userMasterModel.FirstName = dataReader.GetFieldValue<string>(userfirstnameindex);
            }

            int userlastnameindex = this.GetColumnOrdinal(columnNameList, "lastname");
            if (userlastnameindex > 0 && !dataReader.IsDBNull(userlastnameindex))
            {
                userMasterModel.LastName = dataReader.GetFieldValue<string>(userlastnameindex);
            }

            int usercityinder = this.GetColumnOrdinal(columnNameList, "gender");
            if (usercityinder > 0 && !dataReader.IsDBNull(usercityinder))
            {
                userMasterModel.Gender = dataReader.GetFieldValue<string>(usercityinder);
            }


        }






    }
}
