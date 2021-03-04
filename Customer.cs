using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
   public class Customer
    {
        //custid,custname,city,state,country,cardno, etc
        private bool PrimeCustomer;
        public string ShowCustomerStatus()
        {
            string custType = null;
            if (PrimeCustomer)
            {
                custType = "Welcome Prime Customer";
            }
            else
            {
                custType = "Welcome  Customer";
            }
            return custType;
        }



        private int _custid;
        public int CustId
        {
            get {
                
                
                return _custid; }
            set {

                

                if (value == 0)
                {
                    throw new Exception("custid cannot be zero");
                }
                else
                {
                    _custid = value;
                    if (_custid >= 1 && _custid <= 10)
                    {
                        PrimeCustomer = true;
                    }

                }


            }
        }

        private int _cardno;
        public int Cardno
        {
            get { return _cardno; }
            set { _cardno = value; }
        }





    }
}
