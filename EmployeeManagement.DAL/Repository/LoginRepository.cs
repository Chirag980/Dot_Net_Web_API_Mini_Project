using EmployeeManagement.DAL.Interfaces;
using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.DAL.Repository
{
    public class LoginRepository : Respository.RepositoryBase<LoginModel>, ILoginRepository
    {
        public LoginModel CheckLogin(LoginModel log)
        {
            var sqlParameters = new List<SqlParameter>();
            LoginModel response = new LoginModel();
            response.LoginSuccess = false;
            sqlParameters.Add(new SqlParameter("@userName", log.UserName));
            sqlParameters.Add(new SqlParameter("@password", log.Password));

            var loginListFromDb = this.ExecuteReader("[dbo].[sp_getuser]", sqlParameters, MapLoginModel, 10);
            if (loginListFromDb != null && loginListFromDb.Count == 1)
            {
                response = loginListFromDb.FirstOrDefault();
                response.LoginSuccess = true;
            }
            return response;
        }



        protected void MapLoginModel(Model.LoginModel model, SqlDataReader dataReader, string[] columnNameList)
        {
            int UserIdIndex = this.GetColumnOrdinal(columnNameList, "UserId");
            if (UserIdIndex >= 0 && !dataReader.IsDBNull(UserIdIndex))
            {
                model.UserId = dataReader.GetFieldValue<int>(UserIdIndex);
            }

            int UserNameIdIndex = this.GetColumnOrdinal(columnNameList, "email");
            if (UserNameIdIndex >= 0 && !dataReader.IsDBNull(UserNameIdIndex))
            {
                model.UserName = dataReader.GetFieldValue<string>(UserNameIdIndex);
            }

            int PasswordIndex = this.GetColumnOrdinal(columnNameList, "password");
            if (PasswordIndex > 0 && !dataReader.IsDBNull(PasswordIndex))
            {
                model.Password = dataReader.GetFieldValue<string>(PasswordIndex);
            }
            model.LoginSuccess = model.UserId > 0;
        }
    }
}
