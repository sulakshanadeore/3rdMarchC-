using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
public  class PrimeCustomer:Customer
    {
        //public new double PlaceOrder(int prodid, int qty, int rate)
        //{
        //    double orderamt = qty * rate;
        //    return orderamt;
        //}

        public override double PlaceOrder(int prodid, int qty, int rate, out int deliveryDays)
        {
            double amt=base.PlaceOrder(prodid, qty, rate,out deliveryDays);
            double a=qty* rate;
             deliveryDays = 3;
            if (a<amt)
            {
                double discount=a * .10;
                amt = a -discount;
                
            }
            return amt;
        }
    }
}
