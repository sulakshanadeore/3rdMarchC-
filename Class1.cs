using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Transactions;
namespace TransactionsDemo
{
    public class CustomersDAL
    {

        public void InsertCustomer(string custid,string companyname,string city)
        {
            SqlConnection cn = new SqlConnection("server=spd\\sqlexpress;database=northwind;integrated security=true");
            SqlTransaction tran;
            cn.Open();//1
            tran = cn.BeginTransaction();

            try
            {

                SqlCommand cmd = new SqlCommand("insert into customers(customerid,companyname,city) values (@custid,@coname,@city)", cn,tran);//2
                //cmd.Transaction = tran;
                cmd.Parameters.AddWithValue("@custid", custid);
                cmd.Parameters.AddWithValue("@coname", companyname);
                cmd.Parameters.AddWithValue("@city", city);
               cmd.ExecuteNonQuery();
                tran.Commit();//3
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

                tran.Dispose();
                cn.Close();
                cn.Dispose();
            }
            
            

        }


        public void UpdateCustomer(Customer c,Dept d)
        {
            
            SqlConnection cn = new SqlConnection("server=spd\\sqlexpress;database=northwind;integrated security=true");

            SqlConnection cn1 = new SqlConnection("server=spd\\sqlexpress;database=MYOLDHR;integrated security=true");

            cn.Open();
            TransactionScope transcope = new TransactionScope();
            try
            {
                using (transcope)
                {
                    

                    string cmd1 = "update customers  set companyname='" + companyname + "'," + "city='" + city + "' where customerid='" + custid +"'";
                        
                    SqlCommand cmd = new SqlCommand(cmd1, cn);
                    //cmd.Parameters.AddWithValue("@custid", custid);
                    //cmd.Parameters.AddWithValue("@coname", companyname);
                    //cmd.Parameters.AddWithValue("@city", city);
                    int i=cmd.ExecuteNonQuery();
                    SqlCommand cmd2 = new SqlCommand("insert into dept values(50,'ABC','ABC')", cn1);
                    cn1.Open();
                    int j=cmd2.ExecuteNonQuery();
                    transcope.Complete();
                    Console.WriteLine(i+ " Rows updated in Customers from NW");
                    Console.WriteLine(j + " Rows updated in Dept from OLD HR");

                    cn.Close();

                }
            }
            catch (Exception ex)
            {
                transcope.Dispose();
                throw ex;
            }
        }


    }

}
