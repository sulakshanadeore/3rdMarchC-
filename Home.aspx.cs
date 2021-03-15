using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMgtDemo
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Application["visitors"].ToString();
            bool ans=Session.IsNewSession;
            if (ans)
            {
                Label2.Text = "Its new session";
            }
            else
            {
                Label2.Text = "Its existing session";
            }
            Label3.Text = Session.SessionID;
        }
    }
}