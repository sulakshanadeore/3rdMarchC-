using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NWLibrary;
using System.Data;
namespace DeclarativeDemo
{
    public partial class CustomersByCity : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CustomersDAL dal = new CustomersDAL();
                List<string> cities = new List<string>();
                cities=dal.ShowAllCities();
                DropDownList1.DataSource = cities;
                DropDownList1.DataBind();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomersDAL dal = new CustomersDAL();
            DataTable dt = new DataTable();
            dt=dal.FilterByCity(DropDownList1.SelectedValue);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}