using EmployeeManagement.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Registration_Form.Helper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registration_Form
{
    public partial class Login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginBt_Click(object sender, EventArgs e)
        {
            LoginModel log = new LoginModel();


            log.UserName = username.Text;
            log.Password = password.Text;

            if (log.UserName == "" || log.Password == "")
            {
                Response.Write("<script>alert('Username And Password Is Required')</script>");
            }
            else
            {
                var response = RequestHelper.Post("LoginModel/CheckLogin", log);
                if (response.IsSuccessful && response.Content != null)
                {
                    var logingFromDb = JsonConvert.DeserializeObject<LoginModel>((JObject.Parse(response.Content)).ToString());

                    if (logingFromDb.LoginSuccess == true)
                    {

                        Session["UserId"] = logingFromDb.UserId;
                        Response.Redirect("EmployeeRecord.aspx");//session
                    }
                    else
                    {
                        Response.Write("<script>alert('Hello " + username.Text + " Your User Name or Password is Invalid')</script>");
                    }
                }

                // PRACTICE WHILE INTERVIEW


                //public List<CountryModel> GetCountry()
                //{
                //    IList<CountryModel> listOfCountry = new List<CountryModel>();
                //    CountryModel country1 = new CountryModel();
                //    country1.Country_Id = 1;
                //    country1.Country_Name = "India";
                //    listOfCountry.Add(country1);
                //    CountryModel country2 = new CountryModel();
                //    country2.Country_Id = 2;
                //    country2.Country_Name = "China";
                //    listOfCountry.Add(country2);
                //    var listOfCountry = listOfCountry.Where(s => s.Country_Id == 2)
                //        .Select(s=>s)
                //}
                //List<int> listofint = new List<int>();
                //listofint.Add(2);
                //listofint.Add(1);
                //listofint.Add(3);
                //listofint.Add(5);
                //listofint.Add(6);

                //listofint.Remove(3);
                //listofint.RemoveRange(0, Math.Min(3, listofint.Count));

                //List<string> listOfString = new List<string>();
                //listOfString.Add("chirag");
                //listOfString.Add("vaibhav sir");
                //listOfString.Add("laxman sir");
                //listOfString.Add("abhishek");
                //var listOfString = listOfString.Where(s => s.StartsWith("a"));




                List<int> listOfInt = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                IEnumerable<int> even = listOfInt.Where(s => s % 2 == 0);
                foreach(var item in even)
                {
                    Console.WriteLine(item);
                }








            }

        }
    }
}