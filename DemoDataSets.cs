using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NWLibrary;
using System.Data;
namespace ObjectLINQDemo
{
   public class DemoDataSets
    {
        static void Main(string[] args)
        {
            CustomersDAL dal = new CustomersDAL();
            DataSet ds = new DataSet();
            ds=dal.ReturnDataSet();
            DataTable dt = new DataTable();
            dt=ds.Tables["customers"];
            var query = from cust in dt.AsEnumerable()
                        where cust.Field<string>("City")=="Paris"
                        select new
                        {
                            custid = cust.Field<string>("CustomerID"),
                            custname = cust.Field<string>("CompanyName")
                        };
            foreach (var item in query)
            {
                Console.WriteLine(item.custid);
                Console.WriteLine(item.custname);
            }
            

            Console.Read();
        }
    }
}
