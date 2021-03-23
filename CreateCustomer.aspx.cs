using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NWLibrary;
namespace DeclarativeDemo
{
    public partial class CreateCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            CustomersDAL dal = new CustomersDAL();
            Customers c = new Customers();
            c.CustId = TextBox1.Text;
            c.CompanyName = TextBox2.Text;
            c.City = TextBox3.Text;
            dal.InsertCustomer(c);
            Response.Redirect("~/CustomersByCity.aspx");

        }
    }
}