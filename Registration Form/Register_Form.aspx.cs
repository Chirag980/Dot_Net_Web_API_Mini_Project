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
    public partial class Register_Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                var reQUrl = "State/GetStateList";
                var responseState = RequestHelper.Get(reQUrl);
                if (responseState.IsSuccessful)
                {
                    var listOfUser = JsonConvert.DeserializeObject<List<EmployeeManagement.Model.StateModel>>(responseState.Content.ToString());
                    State.DataSource = listOfUser;
                    State.DataTextField = "State";
                    State.DataValueField = "StateID";
                    State.DataBind();
                }
                var responseGender = RequestHelper.Get("Register_Form/GetGenderList");
                if (responseGender.IsSuccessful)
                {
                    var listOfGender = JsonConvert.DeserializeObject<List<Register_FormModel>>(responseGender.Content.ToString());
                    ddlGender.DataSource = listOfGender;
                    ddlGender.DataTextField = "Gender";
                    ddlGender.DataValueField = "GenderID";
                    ddlGender.DataBind();
                }
                

                //donot backspace this important file

                //var reQUrl = "Register_Form/GetGenderList";
                //var response = RequestHelper.Get(reQUrl);
                //if (response.IsSuccessful)
                //{
                //    var listOfGender = JsonConvert.DeserializeObject<List<Register_FormModel>>(response.Content.ToString());
                //    ddlGender.DataSource = listOfGender;
                //    ddlGender.DataTextField = "Gender";
                //    ddlGender.DataValueField = "GenderID";

                //    ddlGender.DataBind();

                //}
            }
        }

        protected void UserName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void FirstName_TextChanged(object sender, EventArgs e)
        {
            //LastName.Text = FirstName.Text;

        }

        protected void FirstName_Load(object sender, EventArgs e)
        {

        }

        protected void LastName_Load(object sender, EventArgs e)
        {

        }

        protected void Password_Load(object sender, EventArgs e)
        {

        }

        protected void ConfirmPassword_Load(object sender, EventArgs e)
        {

        }

        protected void Register_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel();

            user.FirstName = FirstName.Text;
            user.LastName = LastName.Text;
            user.Gender = ddlGender.Text;
            user.Password = Password.Text;
            user.ConfirmPassword = ConfirmPassword.Text;



            var response = RequestHelper.Post("User/InsertUser", user);


            if (response.IsSuccessful)
                if (response.IsSuccessful)
                {
                    //Response.Write("<script>alert('Hello " + Firstname.Text + " Your Registration is Successful')</script>");
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", " alert('User Details Saved Sucessfully'); window.open('Login.aspx');", true);

                }
        }

        protected void Cancel_Click(object sender, EventArgs e)
        {
            Response.Write("Canceled.....");

        }

        protected void ddlGender_DataBinding(object sender, EventArgs e)
        {
           
        }

        protected void email_TextChanged(object sender, EventArgs e)
        {

        }

        protected void mobno_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Male_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Female_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void State_DataBinding(object sender, EventArgs e)
        {
            
        }

    }
}