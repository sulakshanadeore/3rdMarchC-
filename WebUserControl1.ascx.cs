using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPagesDemo
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string time= DateTime.Now.ToShortTimeString();
            if (time.Contains("PM"))
            {
                TextBox1.Text = "Good afternoon";
            }
            else
            {
                TextBox1.Text = "Good morning";
            }
        }
    }
}