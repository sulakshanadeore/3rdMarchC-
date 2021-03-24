using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NWLibrary;
using System.Data.Linq;
namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        NorthwindContextDataContext context = new NorthwindContextDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //int i=context.AddEmployee("Humpty", "Dumpty");
            //context.SubmitChanges();
            Employee emp = new Employee();
            emp.FirstName = "Akanksha";
            emp.LastName = "Singh";

            context.Employees.InsertOnSubmit(emp);
            context.SubmitChanges();


        }



        protected void Button2_Click(object sender, EventArgs e)
        {
            //Employee emp = context.Employees.FirstOrDefault(s => s.EmployeeID == 14);
            string s= "Akanksha";
            //Employee emp = context.Employees.Where(s => s.FirstName == "Akanksha").LastOrDefault()
           int cnt = context.Employees.Where(s1 => s1.FirstName == s).Count();
            Employee e1 = context.Employees.Where(s1 => s1.FirstName == s).LastOrDefault();
            Response.Write(e1.City);

            //emp.FirstName = "Humpty";
            //emp.LastName = "Dumpty";


            context.SubmitChanges();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Employee emp = context.Employees.FirstOrDefault(s => s.EmployeeID == 14);
            context.Employees.DeleteOnSubmit(emp);
            context.SubmitChanges();


        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Employee emp = context.Employees.FirstOrDefault(s => s.EmployeeID == 13);
            Response.Write(emp.EmployeeID + " " + emp.FirstName + " " + emp.LastName);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Table<Employee> emptab=context.Employees;
            GridView1.DataSource = emptab;
            GridView1.DataBind();
        }
    }
}