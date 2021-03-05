using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLibrary;
namespace OOPs
{
    class OverRidingDemo
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();
            double amt=c.PlaceOrder(1, 100, 2,out int deliveryPeriod);
            Console.WriteLine("Your order value= " + amt);
            Console.WriteLine("Delivery Period= " + deliveryPeriod);

            PrimeCustomer pc = new PrimeCustomer();
            amt=pc.PlaceOrder(1, 100, 2,out  deliveryPeriod);
            Console.WriteLine("Your order value= " + amt);
            Console.WriteLine("Delivery Period= " + deliveryPeriod);

            PlatinumCustomer platinum = new PlatinumCustomer();
            amt = platinum.PlaceOrder(1, 100, 2, out deliveryPeriod);
            Console.WriteLine("Your order value= " + amt);
            Console.WriteLine("Delivery Period= " + deliveryPeriod);

            Console.Read();
        }
    }
}
