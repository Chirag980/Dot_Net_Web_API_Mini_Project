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
    public partial class UserRecords : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserId"] != null)
                {
                    var userId = Session["UserId"].ToString();
                }

                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        

        protected void Add_User_Click1(object sender, EventArgs e)
        {
            //if (RadTextBox1.Text == string.Empty)
            //{
            //    RadLabel1.Text = "Please enter user name";
            //}
            //else
            //{
            //    ListBox1.Items.Add(RadTextBox1.Text);
            //    RadTextBox1.Text = "";
            //    RadLabel1.Text = "";
            //}
        }

        protected void Remove_Click(object sender, EventArgs e)
        {
            //ListBox1.Items.RemoveAt(ListBox1.Items.IndexOf(ListBox1.SelectedItem));
        }

        protected void RadGrid2_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            List<UserModel> userMasterModel = new List<UserModel>();
            var response = RequestHelper.Get("User/GetAllUserList");
            if (response.IsSuccessful)
            {
                userMasterModel = JsonConvert.DeserializeObject<List<UserModel>>(JArray.Parse(response.Content).ToString());

            }
            RadGrid2.DataSource = userMasterModel;
            RadGrid2.VirtualItemCount = userMasterModel.Count;
            RadGrid2.PagerStyle.AlwaysVisible = true;
        }
    }
}