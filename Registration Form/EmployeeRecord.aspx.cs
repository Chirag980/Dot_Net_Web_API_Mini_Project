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
using Telerik.Web.UI;

namespace Registration_Form
{
    public partial class EmployeeRecord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                if (Session["UserId"] != null)
                {
                    var userId = Convert.ToInt32(Session["UserId"]);
                }

                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }

        protected void RadGrid1_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {

            List<EmployeeRecordModel> listofEmployee = new List<EmployeeRecordModel>();
            var user = new UserModel();
            user.userId = Convert.ToInt32(Session["UserId"]);
            var response = RequestHelper.Get("EmployeeRecord/GetEmployeeRecord?userId=" + user.userId);

            if (response.IsSuccessful)
            {
                listofEmployee = JsonConvert.DeserializeObject<List<EmployeeRecordModel>>(JArray.Parse(response.Content).ToString());
            }
            RadGrid1.DataSource = listofEmployee;

            RadGrid1.VirtualItemCount = listofEmployee.Count;
            RadGrid1.PagerStyle.AlwaysVisible = true;
        }

        protected void RadGrid1_ItemCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                RadGrid1.MasterTableView.ClearEditItems();
                var item = (GridEditableItem)e.Item;
                var ID = item["EmployeeId"].Text;

                Response.Redirect("ADDEmployee.aspx?EmployeeId=" + ID);
            }
            if (e.CommandName == "Delete")
            {
                RadGrid1.MasterTableView.ClearEditItems();
                var item = (GridEditableItem)e.Item;
                var ID = item["EmployeeId"].Text;


                EmployeeRecordModel emp = new EmployeeRecordModel();
                emp.employeeId = Convert.ToInt32(ID);
                var response = RequestHelper.Delete("EmployeeRecord/DeleteEmployee", emp);

                if (response.IsSuccessful)
                    if (response.IsSuccessful)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", " alert('Record Deleted Successfully'); window.open('EmployeeRecord.aspx');", true);
                    }

            }
        }


        protected void RadGrid1_ItemDataBound(object sender, Telerik.Web.UI.GridItemEventArgs e)
        {

        }

        protected void RadGrid1_NeedDataSource1(object sender, GridNeedDataSourceEventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
        }

        protected void RadLinkButton1_Load(object sender, EventArgs e)
        {

        }
    }
}