using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMgtDemo
{
    public partial class ViewStateDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ViewState["cnt"] = 0;
                
            }
            else
            {
                int cnt;
                cnt = Convert.ToInt32(ViewState["cnt"]);
                cnt += 1;
                ViewState["cnt"] = cnt;

            }
            TextBox3.Text = ViewState["cnt"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //ViewState["mydata"] = TextBox1.Text;
            Customer c = new Customer();
            c.custid = 1;
            c.custname = "jack";
            ViewState["custdata"] = c;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //TextBox2.Text = ViewState["mydata"].ToString();
            Customer c1=(Customer)ViewState["custdata"];
            Response.Write(c1.custid);
            Response.Write(c1.custname);

        }
    }
}