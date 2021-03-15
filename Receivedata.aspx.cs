using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMgtDemo
{
    public partial class Receivedata : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        TextBox1.Text=Request.QueryString["cid"].ToString();
            TextBox2.Text = Request.QueryString["custname"].ToString();
            TextBox3.Text= Request.QueryString["custcity"].ToString();

        }
    }
}