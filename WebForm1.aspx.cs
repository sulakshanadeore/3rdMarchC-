using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMgtDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //HiddenField1.Value = 20;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text==HiddenField1.Value)
            {
                
        Response.Write("<body style =  background-color:green > ");

                                                                                 }
            else
            {
                Response.Write("<body style =  background-color:red > ");
            }

        }
    }
}