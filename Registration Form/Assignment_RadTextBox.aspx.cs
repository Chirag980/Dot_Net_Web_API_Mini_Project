using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registration_Form
{
    public partial class Assignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadTextBox1_TextChanged(object sender, EventArgs e)
        {
            RadTextBox2.Text = RadTextBox1.Text;
        }

        protected void RadTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void RadTextBox1_Load(object sender, EventArgs e)
        {

        }
    }
}