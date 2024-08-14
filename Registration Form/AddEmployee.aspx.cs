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
    public partial class ADD_Employee1 : System.Web.UI.Page
    {
        public int EmployeeId { get; set; }
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

            if (!IsPostBack)
            {
                //Here I get country list through hard code


                var response = RequestHelper.Get("Country/GetCountryList");
                var listOfCountry = JsonConvert.DeserializeObject<List<CountryModel>>(response.Content.ToString());
                country.DataSource = listOfCountry;
                country.DataTextField = "Country_Name";
                country.DataValueField = "Country_Id";
                country.DataBind();
            }
            
            try
            {
                //var countryReponse = RequestHelper.Get("EmployeeRecord/GetCountryList");
                if (!IsPostBack)
                {
                    if (Request.QueryString["EmployeeId"] != null)
                    {
                        EmployeeId = Convert.ToInt32(Request.QueryString["EmployeeId"].ToString());

                        List<EmployeeRecordModel> userMasterModel = new List<EmployeeRecordModel>();

                        EmployeeRecordModel emp = new EmployeeRecordModel();
                        var userId = Convert.ToInt32(Session["UserId"]);
                        var response = RequestHelper.Get("EmployeeRecord/GetEmployeeRecord?userId=" + userId);
                        if (response.IsSuccessful)
                        {

                            userMasterModel = JsonConvert.DeserializeObject<List<EmployeeRecordModel>>(JArray.Parse(response.Content).ToString());
                            emp = userMasterModel.Where(s => s.employeeId == Convert.ToInt32(EmployeeId)).FirstOrDefault();

                            if (emp != null)
                            {
                                FirstName.Text = emp.firstName;
                                LastName.Text = emp.lastName;
                                RadDatePicker1.SelectedDate = DateTime.Parse(emp.DateOfBirth);
                                address1.Text = emp.Address1;
                                address2.Text = emp.Address2;
                                city.Text = emp.city;
                                State.Text = emp.state;
                                pincode.Text = Convert.ToString(emp.pinCode);
                                country.Text = emp.country;
                                Designation.Text = emp.designation;
                                Technology.Text = emp.Technology;
                            }
                        }
                    }
                }
            }
            catch
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", " alert('Invalid Action'); window.open('EmployeeRecord.aspx');", true);
                
            }


        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString["EmployeeId"] != null)
                {
                    EmployeeRecordModel emp = new EmployeeRecordModel();
                    EmployeeId = Convert.ToInt32(Request.QueryString["EmployeeId"].ToString());

                    emp.userId = Convert.ToInt32(Session["UserId"]);
                    emp.employeeId = EmployeeId;
                    emp.firstName = FirstName.Text;
                    emp.lastName = LastName.Text;
                    emp.DateOfBirth = Convert.ToDateTime(RadDatePicker1.SelectedDate).ToString("dd-MM-yyyy");
                    emp.Address1 = address1.Text;
                    emp.Address2 = address2.Text;
                    emp.city = city.Text;
                    emp.state = State.Text;
                    emp.pinCode = pincode.Text;
                    emp.country = country.Text;
                    emp.designation = Designation.Text;
                    emp.Technology = Technology.Text;
                    var response = RequestHelper.Put("EmployeeRecord/UpdateEmployee", emp);

                    if (response.IsSuccessful)
                        if (response.IsSuccessful)
                        {

                            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", " alert('Record Updated Successfully'); window.open('EmployeeRecord.aspx');", true);
                            Response.Redirect("EmployeeRecord.aspx?");

                        }

                }
                else
                {
                    EmployeeRecordModel emp = new EmployeeRecordModel();
                    emp.userId = Convert.ToInt32(Session["UserId"]);
                    emp.firstName = FirstName.Text;
                    emp.lastName = LastName.Text;
                    emp.DateOfBirth = Convert.ToDateTime(RadDatePicker1.SelectedDate).ToString("dd-MM-yyyy");
                    emp.Address1 = address1.Text;
                    emp.Address2 = address2.Text;
                    emp.city = city.Text;
                    emp.state = State.Text;
                    emp.pinCode = pincode.Text;
                    emp.country = country.Text;
                    emp.designation = Designation.Text;
                    emp.Technology = Technology.Text;
                    var response = RequestHelper.Post("EmployeeRecord/AddEmployee", emp);
                    if (response.IsSuccessful)
                        if (response.IsSuccessful)
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", " alert('Employee Details Saved Sucessfully'); window.open('EmployeeRecord.aspx');", true);
                        }

                    RefreshControl();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void RefreshControl()
        {
            FirstName.Text = "";
            LastName.Text = "";
            RadDatePicker1.SelectedDate = null;
            address1.Text = "";
            address2.Text = "";
            city.Text = "";
            State.Text = "";
            pincode.Text = "";
            country.Text = "";
            Designation.Text = "";
            Technology.Text = "";
        }

        protected void Cancel_Click(object sender, EventArgs e)
        {
            //RefreshControl();
            Response.Redirect("EmployeeRecord.aspx?");
        }

        protected void RadRadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}