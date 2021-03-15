using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMgtDemo
{
    public partial class SendData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           TextBox2.Text= Session["fname"].ToString();
            TextBox1.Text = Session.SessionID;
        }

 
        protected void Button1_Click(object sender, EventArgs e)
        {
            Customer  c = new Customer();
            
            c.custid = Convert.ToInt32(txtcustid.Text);
            c.custname = txtcustname.Text;
            c.city = txtcustcity.Text;
            Response.Redirect("~/Receivedata.aspx?cid=" + c.custid + "&custname=" + c.custname  + "&custcity=" + c.city);

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}