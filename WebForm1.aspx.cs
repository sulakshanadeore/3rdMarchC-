using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NWLibrary;
namespace DeclarativeDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CustomersDAL dal = new CustomersDAL();
            List<Customers> custlist = new List<Customers>();
                custlist=dal.GetCustomers();
            Repeater1.DataSource = custlist;
            Repeater1.DataBind();

            

        }
    }
}