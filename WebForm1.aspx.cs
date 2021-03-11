using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //fresh request/first time
                Response.Write("welcome to my page for the first time");

                DropDownList1.Items.Add("Floppies");
                DropDownList1.Items.Add("CDs");
            }
            else
            {
                Response.Write("U had clicked the button... welcome again");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Hello " + TextBox1.Text);
        }
    }
}