using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionsDemo;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomersDAL c = new CustomersDAL();
            //   c.InsertCustomer("HELLO", "HELLO LTD", "Chicago");
            try
            {
                c.UpdateCustomer("HELLO", "HELLO AGAIN", "BERLIN");
                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            




            Console.Read();

        }
    }
}
