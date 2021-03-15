using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMgtDemo
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("current time is " + DateTime.Now.ToLongTimeString());
            HttpCookie refcookie=Request.Cookies["regcookie"];
            //Label1.Text = refcookie["customerid"].ToString() + " " + refcookie["customername"].ToString();
            Label1.Text = refcookie.Value;
        }
    }
}