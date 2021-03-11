using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApplication
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!Page.IsPostBack)

            if(!IsPostBack)
            {
                DropDownList1.Items.Add("---Select Name----");
                DropDownList1.Items.Add("Rajesh");
                DropDownList1.Items.Add("Ramesh");
                DropDownList1.Items.Add("Suresh");
                DropDownList1.Items.Add("Mahesh");
                DropDownList1.Items.Add(new ListItem("Reshma","20",false));
                DropDownList1.Items.Add(new ListItem("Sumitra","10",true));
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = DropDownList1.SelectedValue;
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
          string v=DropDownList2.SelectedItem.Text;
            if (v=="True")
            {
                Response.Write(DropDownList2.SelectedValue);
            }
            else
            {
                Response.Write(DropDownList2.SelectedValue);
            }
        }
    }
}