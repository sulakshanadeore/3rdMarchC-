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
            c.Cardno = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine(c.ShowCustomerStatus());

                Console.WriteLine("Enter Customer Name");
                c.CustName = Console.ReadLine();
                Console.WriteLine("Enter Birthday Date");
                c.BirthDate = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Enter password");
                c.Password = Console.ReadLine();

                Console.WriteLine("Your OTP= " + c.OTP);
                Console.WriteLine("Please enter ur OTP here");
                c.CheckOTP = Convert.ToInt32(Console.ReadLine());
                c.OTP = 1234;             

                Console.WriteLine("U have entered Customer ID=  " + c.CustId);
                Console.WriteLine("Customer Name " + c.CustName);
                Console.WriteLine("BirthDate " + c.BirthDate);
                Console.WriteLine("Card No" + c.Cardno);



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
