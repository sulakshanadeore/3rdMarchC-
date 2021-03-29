using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        //public int Add(int i, int j)
        //{
        //    return i + j;
        //}

        public string GetData(int value)
        {
            return "You entered = " + value;
        }

        public List<Employees> GetDataEmployees()
        {
            //throw new NotImplementedException();
            List<Employees> emplist = new List<Employees>();
            SqlConnection cn = new SqlConnection("server=spd\\sqlexpress;database=Northwind;Integrated Security=true");
            //SqlCommand cmd = new SqlCommand("select * from employees",cn);
            SqlCommand cmd = new SqlCommand("SELECT * FROM[dbo].[ShowAllEmployees]()", cn);

            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Employees emp = new Employees();
                emp.Empid = Convert.ToInt32(dr["EmployeeID"]);
                emp.Fname = dr["FirstName"].ToString();
                emp.LName = dr["LastName"].ToString();
                emplist.Add(emp);
            }
            cn.Close();
            return emplist;


        }

        public List<Employees> GetEmployees()
        {
            //throw new NotImplementedException();

            List<Employees> emplist = new List<Employees>();
            SqlConnection cn = new SqlConnection("server=spd\\sqlexpress;database=Northwind;Integrated Security=true");
            //SqlCommand cmd = new SqlCommand("select * from employees",cn);
            SqlCommand cmd = new SqlCommand("SELECT * FROM[dbo].[ShowAllEmployees]()", cn);

            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Employees emp = new Employees();
                emp.Empid = Convert.ToInt32(dr["EmployeeID"]);
                emp.Fname = dr["FirstName"].ToString();
                emp.LName = dr["LastName"].ToString();
                emplist.Add(emp);
            }
            cn.Close();
            return emplist;
        }

        public List<Employees> GetEmployeesXML()
        {
            List<Employees> emplist = new List<Employees>();
            SqlConnection cn = new SqlConnection("server=spd\\sqlexpress;database=Northwind;Integrated Security=true");
            //SqlCommand cmd = new SqlCommand("select * from employees",cn);
            SqlCommand cmd = new SqlCommand("SELECT * FROM[dbo].[ShowAllEmployees]()", cn);

            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Employees emp = new Employees();
                emp.Empid = Convert.ToInt32(dr["EmployeeID"]);
                emp.Fname = dr["FirstName"].ToString();
                emp.LName = dr["LastName"].ToString();
                emplist.Add(emp);
            }
            cn.Close();
            return emplist;
        }
    }
}
