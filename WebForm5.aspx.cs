using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApplication
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtdate.Text = Calendar1.SelectedDate.ToLongDateString();
        }

        static int amt = 0;
        protected void Products_list_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            txtcart.Text += Products_list.SelectedItem.Text + ",";
            amt = amt + Convert.ToInt32(Products_list.SelectedValue);
            Label1.Text = "You pay Rs." + amt.ToString();
        }
    }
}