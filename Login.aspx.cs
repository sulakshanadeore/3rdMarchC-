using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPagesDemo
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            string uname=txtusername.Text.Trim();
            string pwd = txtpwd.Text.Trim();
            if (uname=="admin"&&pwd=="admin")
            {
                Session["username"] = uname;
                Response.Redirect("~/HardwareServices.aspx");
            }
            
        }
    }
}