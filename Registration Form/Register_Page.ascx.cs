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
    public partial class Register_Page : System.Web.UI.UserControl
    {
        public int userId { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var responseGender = RequestHelper.Get("Register_Form/GetGenderList");
                if (responseGender.IsSuccessful)
                {
                    var listOfGender = JsonConvert.DeserializeObject<List<Register_FormModel>>(responseGender.Content.ToString());
                    ddlGender.DataSource = listOfGender;
                    ddlGender.DataTextField = "Gender";
                    ddlGender.DataValueField = "GenderID";
                    ddlGender.DataBind();
                }
            }
        }

        protected void firstName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void firstName_Load(object sender, EventArgs e)
        {

        }

        protected void lastName_Load(object sender, EventArgs e)
        {

        }

        protected void email_TextChanged(object sender, EventArgs e)
        {

        }

        protected void mobno_TextChanged(object sender, EventArgs e)
        {

        }

        protected void State_DataBinding(object sender, EventArgs e)
        {

        }

        protected void ddlGender_DataBinding(object sender, EventArgs e)
        {

        }

        protected void Password_Load(object sender, EventArgs e)
        {

        }

        protected void ConfirmPassword_Load(object sender, EventArgs e)
        {

        }

        public bool UserExist(string UserName)
        {
            bool isExist = false;
            List<UserModel> userMasterModel = new List<UserModel>();
            var response = RequestHelper.Get("User/GetUserList_By_Name?UserName=" + UserName);
            if (response.IsSuccessful)
            {
                userMasterModel = JsonConvert.DeserializeObject<List<UserModel>>(JArray.Parse(response.Content).ToString());
            }
            if (userMasterModel != null && userMasterModel.Count > 0)
                isExist = true;
            return isExist;
        }
        public bool ContainNumeric(string str)
        {
            bool HasNumber = false;
            //HasNumber = str.Any(c => char.IsDigit(c));
            HasNumber = str.Any(ch => !char.IsLetter(ch));
            return HasNumber;
        }
        protected void Register_Click(object sender, EventArgs e)
        {
            //try
            //{
            if (!string.IsNullOrEmpty(UserName.Text) && !string.IsNullOrEmpty(FirstName.Text) &&
                !string.IsNullOrEmpty(LastName.Text) && !string.IsNullOrEmpty(ddlGender.Text) &&
                !string.IsNullOrEmpty(Password.Text) && !string.IsNullOrEmpty(ConfirmPassword.Text)
                && UserName.Text.Contains("@") && UserName.Text.Contains("."))
            {
                if (ContainNumeric(FirstName.Text) == true || ContainNumeric(LastName.Text) == true)
                {
                    //Response.Write("<script>alert('First Name or Last Name only contains alphabets')</script>");
                }
                else if (Password.Text != ConfirmPassword.Text)
                {
                    //Response.Write("<script>alert('Password and Confirm Password Not Matched')</script>");
                }
                else if (!UserExist(UserName.Text))
                {
                    UserModel user = new UserModel();
                    //userId = Convert.ToInt32(Request.QueryString["userId"].ToString());

                    user.UserName = UserName.Text;
                    user.FirstName = FirstName.Text;
                    user.LastName = LastName.Text;
                    user.Gender = ddlGender.Text;
                    user.Password = Password.Text;
                    user.ConfirmPassword = ConfirmPassword.Text;

                    var response = RequestHelper.Post("User/InsertUser", user);

                    if (response.IsSuccessful)
                    {
                        if (response.IsSuccessful)
                        {
                            Response.Write("<script>alert('Hello " + FirstName.Text + " Your Registration is Successful')</script>");
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", " alert('User Details Saved Sucessfully'); window.open('Login.aspx');", true);
                        }
                    }
                    //Response.Redirect("~/Login.aspx");
                }
                else
                {
                    Response.Write("<script>alert('User With the same name already Exist :" + UserName.Text + "')</script>");
                    //ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", " alert('User Details Already Exist');", true);
                }
            }
            else
            {


            }
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            //Response.Redirect("~/Login.aspx");
        }

        protected void Cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void UserName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void UserName_Load(object sender, EventArgs e)
        {

        }

        protected void Register_Click1(object sender, EventArgs e)
        {

        }

        protected void Register_Click2(object sender, EventArgs e)
        {

        }
    }
}