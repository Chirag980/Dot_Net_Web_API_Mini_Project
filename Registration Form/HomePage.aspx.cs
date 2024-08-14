using EmployeeManagement.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Registration_Form.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registration_Form
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadGrid1_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            List<UserModel> userMasterModel = new List<UserModel>();
            var response = RequestHelper.Get("User/GetAllUserList");
            if (response.IsSuccessful)
            {
                userMasterModel = JsonConvert.DeserializeObject<List<UserModel>>(JArray.Parse(response.Content).ToString());

            }
            RadGrid1.DataSource = userMasterModel;
            RadGrid1.VirtualItemCount = userMasterModel.Count;
            RadGrid1.PagerStyle.AlwaysVisible = true;
        }

        protected void RadGrid1_ItemDataBound(object sender, Telerik.Web.UI.GridItemEventArgs e)
        {

        }

        protected void RadGrid1_ItemCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
        {

        }
    }
}