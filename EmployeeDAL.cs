using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace NWLibrary
{
    public class EmployeeDAL
    {
        public Employees GetEmployeeById(int empid)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NWCnString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("ShowDetails", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empid", empid);
            cmd.Parameters.Add("@fname", SqlDbType.NVarChar, 10);
            cmd.Parameters["@fname"].Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@lname", SqlDbType.NVarChar, 20);
            cmd.Parameters["@lname"].Direction = ParameterDirection.Output;
            cn.Open();
            cmd.ExecuteNonQuery();
            Employees emp = new Employees();
            emp.Empid = empid;
            emp.Fname=cmd.Parameters["@fname"].Value.ToString();
            emp.Lname = cmd.Parameters["@lname"].Value.ToString();
            cn.Close();
            return emp;

        }

        public DataView FilterByCity()
        {
            
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NWCnString"].ConnectionString);
            
            SqlCommand cmd = new SqlCommand("SELECT * FROM[dbo].[ShowAllEmployees]()", cn);

            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
                cn.Close();
            
            
            DataView dv = new DataView(dt, "EmployeeID>5", "FirstName", DataViewRowState.OriginalRows);
            


            return dv;
        }



        public void UpdateEmployee(Employees empdata)
        {

            //UpdateEmployee

            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NWCnString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("UpdateEmployee", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empid", empdata.Empid);
            cmd.Parameters.AddWithValue("@fname", empdata.Fname);
            cmd.Parameters.AddWithValue("@lname", empdata.Lname);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();


        }

        public void InsertEmployee(Employees empdata)
        {
            //AddEmployee
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NWCnString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("AddEmployee", cn);
            cmd.CommandType =CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fname", empdata.Fname);
            cmd.Parameters.AddWithValue("@lname", empdata.Lname);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }



        public List<Employees> GetEmployees()
        {
            List<Employees> emplist = new List<Employees>();
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NWCnString"].ConnectionString);
            //SqlCommand cmd = new SqlCommand("select * from employees",cn);
            SqlCommand cmd = new SqlCommand("SELECT * FROM[dbo].[ShowAllEmployees]()", cn);
        
          cn.Open();
            SqlDataReader dr=cmd.ExecuteReader();
            while (dr.Read())
            {
                Employees emp = new Employees();
                emp.Empid = Convert.ToInt32(dr["EmployeeID"]);
                emp.Fname = dr["FirstName"].ToString();
                emp.Lname = dr["LastName"].ToString();
                emplist.Add(emp);
            }
            cn.Close();
            return emplist;

        }

    }
}
