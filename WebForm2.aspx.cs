using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;// Web app
using System.Web.UI;//Page
using System.Web.UI.WebControls;//web controls
using HRLibrary;
namespace FirstWebApplication
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Response.Write("Welcome " + TextBox1.Text);
            Employee emp = new Employee();
            emp.Empname = txtname.Text;
            emp.Empno = Convert.ToInt32(txtempno.Text);


            txtname.MaxLength = 5;
            txtdisplayname.Text = "Welcome " + emp.Empname + " with employee number= " + emp.Empno;
            txtdata.Text= emp.Show();
            //txtdata.Text = emp.Data;

            
        }
        
        protected void btncancel_Click(object sender, EventArgs e)
        {
            //Image1.Height=100;
            //Image2.Height=200;
            //Image1.Width = 100;
            //Image2.Width = 50;

            Image1.ImageUrl = "~/Images/place-watermark.jpg";
            Image2.ImageUrl= "~/Images/bunny1.jpg";
        }
    }
}