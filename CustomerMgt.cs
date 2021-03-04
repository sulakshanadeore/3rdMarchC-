using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLibrary;
namespace OOPs
{
    class CustomerMgt
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();
            try
            {

            
            Console.WriteLine("Enter ur customer id");
            c.CustId=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ur card no");
            c.Cardno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(c.ShowCustomerStatus());




                Console.WriteLine("U have entered Customer ID=  " + c.CustId);


            //Customer c1 = new Customer();
            //Console.WriteLine("Enter ur customer id");
            //c1.CustId = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("U have entered Customer ID=  " + c1.CustId);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.Read();

        }
    }
}
