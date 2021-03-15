using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMgtDemo
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("regcookie");
            //Customer c = new Customer();
            //c.custid = Convert.ToInt32(txtcustid.Text);
            //c.custname = txtcustname.Text;
            cookie.Expires = DateTime.Now.AddMinutes(5);
            cookie.Value = DateTime.Now.ToLongTimeString();
            //cookie.Values.Add("customerid", c.custid.ToString());
            //cookie.Values.Add("customername", c.custname.ToString());
            Response.Cookies.Add(cookie);
            


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Welcome.aspx");
        }
    }
}