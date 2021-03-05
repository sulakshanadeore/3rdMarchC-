using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class InvoicePayment
    {
        //Cash/Cheque/RTGS/NEFT/UPIID
        //InvoiceNo/Amt

        public int InvNo { get; set; }
        public double Amt { get; set; }

        private bool paystatus=false;
        public bool PaymentStatus { get { return paystatus; } }

        public void Pay(int invno, double amt)
        {
            paystatus = true;
        }
        public void Pay(int invno, double amt, double chqno, string bankname, string branch)
        {
            paystatus = true;
        }
        public void Pay(int invno, double amt, string bankname, int nefttranid)
        {
            paystatus = true;
        }
        public void Pay(int invno, double amt, string bankname, string branch, int rtgstranid)
        {
            paystatus = true;
        }

        public void Pay(int invno, double amt, string upiid)
        {
        }



    }
}
