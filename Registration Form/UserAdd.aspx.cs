using EmployeeManagement.Model;
using Newtonsoft.Json;
using Registration_Form.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registration_Form
{
    public partial class UserAdd1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserName"] != null)
                {
                    var username = Session["UserName"].ToString();
                }

                else
                {
                    //Response.Redirect("Login.aspx");
                }
            }
            if (!IsPostBack)
            {
                var reQUrl = "State/GetStateList";
                var response = RequestHelper.Get(reQUrl);
                if (response.IsSuccessful)
                {
                    var listOfUser = JsonConvert.DeserializeObject<List<EmployeeManagement.Model.StateModel>>(response.Content.ToString());
                    ddlState.DataSource = listOfUser;
                    ddlState.DataTextField = "State";
                    ddlState.DataValueField = "StateID";

                    ddlState.DataBind();
                }
            }

            }

        protected void Email_Load(object sender, EventArgs e)
        {

        }

        protected void Email_TextChanged(object sender, EventArgs e)
        {

        }

        protected void FirstName_Load(object sender, EventArgs e)
        {

        }

        protected void FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void LastName_Load(object sender, EventArgs e)
        {

        }

        protected void Add_Click(object sender, EventArgs e)
        {

        }

        protected void RequiredFieldValidator1_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}