using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class PlatinumCustomer:PrimeCustomer
    {

        public override double PlaceOrder(int prodid, int qty, int rate, out int deliveryDays)
        {
            deliveryDays = 1;
            double amt = base.PlaceOrder(prodid, qty, rate,out deliveryDays);
            double a = qty * rate;
            deliveryDays = 1;
            if (a > amt)
            {
                double discount = a * .15;
                amt = a - discount;

            }
            return amt;

        }

    }
}
