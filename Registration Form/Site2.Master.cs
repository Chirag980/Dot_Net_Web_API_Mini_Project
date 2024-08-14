using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registration_Form
{
    public partial class Site2 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["UserId"] == null)
            //{
            //    Response.Redirect("Login.aspx");
            //}
            //else { }

        }
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void RadButton1_Click(object sender, EventArgs e)
        {
            Session["UserName"] = null;
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Clear();
            Response.Cookies.Clear();
            Response.Redirect("Login.aspx");
        }

        protected void userRecord_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserRecords.aspx");
        }
    }
}