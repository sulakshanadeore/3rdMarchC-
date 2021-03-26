using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServiceClientTrial.ServiceReference1;
namespace ServiceClientTrial
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client proxy = new Service1Client();
            Employees[] emp = new Employees[] { };
            emp=proxy.GetDataEmployees();
            List<Employees> empdata = new List<Employees>();
            empdata = emp.ToList<Employees>();
            GridView1.DataSource = empdata;
            GridView1.DataBind();

            foreach (var item in empdata)
            {
                ListBox1.Items.Add(item.Empid + "  " + item.Fname);
            }

        }
    }
}