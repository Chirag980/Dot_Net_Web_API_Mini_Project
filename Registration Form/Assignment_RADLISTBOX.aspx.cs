using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registration_Form
{
    public partial class Assignment_RADLISTBOX : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void country_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        protected void RadButton1_Click(object sender, EventArgs e)
        {
            //RadListBox2.Items.Add(RadListBox1.SelectedItem);
            //int i = 0;
            //i = RadListBox1.SelectedIndex;
            //RadListBox1.Items.Remove(i);
            if (RadListBox1.SelectedItems.Count > 0) 
            {
                while (RadListBox1.SelectedItems.Count != 0)
                {
                    RadListBox2.Items.Add(RadListBox1.SelectedItem);
                    RadListBox1.Items.Remove(RadListBox1.SelectedItem);
                }
            }
        }

        protected void RadButton2_Click(object sender, EventArgs e)
        {
            foreach(var items in RadListBox1.SelectedItems)
            {
                RadListBox2.Items.Add(items);
            }
            for(int i=RadListBox1.SelectedItems.Count - 1; i >= 0; i--)
            {
                RadListBox1.Items.Remove(RadListBox1.SelectedItems[i]);
            }
            
        }

        protected void RadButton4_Click(object sender, EventArgs e)
        {
            foreach (var items in RadListBox2.SelectedItems)
            {
                RadListBox1.Items.Add(items);
            }
            for (int i = RadListBox2.SelectedItems.Count - 1; i >= 0; i--)
            {
                RadListBox2.Items.Remove(RadListBox2.SelectedItems[i]);
            }

        }

        protected void RadButton3_Click(object sender, EventArgs e)
        {
            foreach (var items in RadListBox2.SelectedItems)
            {
                RadListBox1.Items.Add(items);
            }
            for (int i = RadListBox2.SelectedItems.Count - 1; i >= 0; i--)
            {
                RadListBox2.Items.Remove(RadListBox2.SelectedItems[i]);
            }
        }
    }
}

//while (RadListBox1.Items.Count != 0)
//{
//    for (int i = 0; i < RadListBox1.Items.Count; i++)
//    {
//        RadListBox2.Items.Add(RadListBox1.Items[i]);
//        RadListBox1.Items.Remove(RadListBox1.Items[i]);
//    }
//}