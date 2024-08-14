using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registration_Form
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadButton1_Click(object sender, EventArgs e)
        {
            double res = double.Parse(RadTextBox1.Text) + double.Parse(RadTextBox2.Text);
            RadTextBox3.Text = res.ToString();

        }

        protected void RadButton2_Click(object sender, EventArgs e)
        {
            double res = double.Parse(RadTextBox2.Text) - double.Parse(RadTextBox1.Text);
            RadTextBox3.Text = res.ToString();

        }

        protected void RadButton3_Click(object sender, EventArgs e)
        {

            double res = double.Parse(RadTextBox1.Text) * double.Parse(RadTextBox2.Text);
            RadTextBox3.Text = res.ToString();
        }

        protected void RadButton4_Click(object sender, EventArgs e)
        {

            double res = double.Parse(RadTextBox2.Text) / double.Parse(RadTextBox1.Text);
            RadTextBox3.Text = res.ToString();
        }
    }
}