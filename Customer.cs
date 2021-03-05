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

        private long _cardno;
        public long Cardno
        {
            get { return _cardno; }
            set { _cardno = value; }
        }

        private string _custname;

        public string CustName
        {
            get { return _custname; }
            set { _custname = value; }
        }


        //private DateTime _birthdate; (propfull + tab+tab)

        //public DateTime BirthDate
        //{
        //    get { return _birthdate; }
        //    set { _birthdate = value; }
        //} 
        //_BirthDate

        public DateTime BirthDate { get; set; }

        //Write Only
        private string _password;
        public string Password
        {
            set { _password = value; }
        }

        private int GenerateOTP()
        {
          Math.DivRem(CustId,10,out int res);
            return res;
        }

        //Read only
        private int _otp;
        public int OTP
        {
            get
            {

                _otp = GenerateOTP();
                return _otp;
            }
        }
        //readonly property snippet- propg tab+tab
        //public int OTP { get
        //    {
        //        _otp = GenerateOTP();
        //        return _otp;
        //    } private set { _otp = value; } }





        private int _CheckOTP;
        public int CheckOTP
        {
            set {
                if (value==OTP)
                {
                    _CheckOTP = value;
                }
                else
                {
                    Console.WriteLine("Incorrect OTP");
                }
                
            }
        }

        









    }
}
