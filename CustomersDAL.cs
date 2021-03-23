using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace NWLibrary
{
    public class CustomersDAL
    {
        public List<string> ShowAllCities()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NWCnString"].ConnectionString);
            //DataAdapter is fetching the data from the database
            SqlCommand cmd = new SqlCommand("select distinct(city) from customers", cn);
            cn.Open();
            SqlDataReader dr=cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cn.Close();
            List<string> citylist = new List<string>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                citylist.Add(dt.Rows[i][0].ToString());
            }
            
            
            return citylist;

        }


        public Customers GetCustomersByID(string id)
        {
            DataSet ds = PopulateData();
            DataRow drow = ds.Tables["customers"].Rows.Find(id);
            Customers c = new Customers();
            c.CustId = drow[0].ToString();
            c.CompanyName = drow[1].ToString();
            return c;


        }

        

        public void Delete(string id)
        {
            DataSet ds = PopulateData();
            DataRow drow = ds.Tables["customers"].Rows.Find(id);
            drow.Delete();
            SqlDataAdapter da = CnWithDa();
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
            da.Update(ds.Tables["customers"]);

        }

        public void EditCustomer(Customers customers)
        {
            DataSet ds = PopulateData();
            DataRow drow = ds.Tables["customers"].Rows.Find(customers.CustId);
            drow[0] = customers.CustId;
            drow[1] = customers.CompanyName;
            SqlDataAdapter da = CnWithDa();
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
            da.Update(ds.Tables["customers"]);

        }

        public void InsertCustomer(Customers customers)
        {
            DataSet ds = PopulateData();
            DataRow drow=ds.Tables["customers"].NewRow();
            drow[0] = customers.CustId;
            drow[1] = customers.CompanyName;
            ds.Tables["customers"].Rows.Add(drow);
           SqlDataAdapter da=CnWithDa();
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
            da.Update(ds.Tables["customers"]);
            
        }


        public List<Customers> GetCustomers()
        {
            DataSet ds = PopulateData();
            List<Customers> customerList = new List<Customers>();
            for (int i = 0; i < ds.Tables["customers"].Rows.Count - 1; i++)
            {
                Customers c = new Customers();
                c.CustId = ds.Tables["Customers"].Rows[i]["CustomerID"].ToString();

                c.CompanyName = ds.Tables["Customers"].Rows[i]["CompanyName"].ToString();
                customerList.Add(c);
            }
            return customerList;








        }

        private static DataSet PopulateData()
        {
            SqlDataAdapter da = CnWithDa();
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            //Dataset represents Database, but disconnected
            DataSet ds = new DataSet();
            //Each dataset has multiple tables inside it, each is called as DataTable. DataTable can be called with index (0) or name.
            da.Fill(ds, "customers");//disconnects from DB SERVER
            return ds;
        }
        public DataTable FilterByCity(string city)
        {
            DataSet ds = PopulateData();
            DataTable dt=ds.Tables["customers"];
            DataView dv = new DataView(dt, "City='" + city +"'", "City", DataViewRowState.OriginalRows);
            DataTable dt1 = new DataTable();
            dt1=dv.ToTable();
            return dt1;
        }

        private static SqlDataAdapter CnWithDa()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NWCnString"].ConnectionString);
            //DataAdapter is fetching the data from the database
            SqlDataAdapter da = new SqlDataAdapter("select * from customers", cn);
            return da;
        }
    }
}
