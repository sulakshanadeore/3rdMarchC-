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


                //Console.WriteLine("Enter ur customer id");
                //c.CustId=Convert.ToInt32(Console.ReadLine());
                ////Console.WriteLine("Enter ur card no");
                ////c.Cardno = Convert.ToInt64(Console.ReadLine());
                //    //Console.WriteLine(c.ShowCustomerStatus());

                //    Console.WriteLine("Enter Customer Name");
                //    c.CustName = Console.ReadLine();
                //    Console.WriteLine("Enter Birthday Date");
                //    c.BirthDate = Convert.ToDateTime(Console.ReadLine());
                //    Console.WriteLine("Enter password");
                //    c.Password = Console.ReadLine();

                //    Console.WriteLine("Your OTP= " + c.OTP);
                //    Console.WriteLine("Please enter ur OTP here");
                //    c.CheckOTP = Convert.ToInt32(Console.ReadLine());


                //    Console.WriteLine("U have entered Customer ID=  " + c.CustId);
                //    Console.WriteLine("Customer Name " + c.CustName);
                //    Console.WriteLine("BirthDate " + c.BirthDate);
                //    Console.WriteLine("Card No" + c.Cardno);

                InvoicePayment payment = new InvoicePayment();
                Console.WriteLine("Enter invoice number");
                payment.InvNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter amt");
                payment.Amt = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter ur payment mode \n1. Cash \n2. Cheque \n3. RTGS \n4. NEFT \n5. UPIID ");
                int ch = Convert.ToInt32(Console.ReadLine());
                
                //int invno, double amt, double chqno, string bankname, string branch
                
                switch (ch)
                {
                    case 1:
                    payment.Pay(payment.InvNo, payment.Amt);
                        break;
                    case 2:
                        Console.WriteLine("Enter chq no");
                        double chqno = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter bankname");
                        string bankname = Console.ReadLine();
                        Console.WriteLine("Enter branch");
                        string branch = Console.ReadLine();
                        payment.Pay(payment.InvNo, payment.Amt, chqno, bankname, branch);
                        break;
                    case 3:
                        Console.WriteLine("Enter bankname");
                        bankname = Console.ReadLine();
                        Console.WriteLine("Enter branch");
                         branch = Console.ReadLine();
                        Console.WriteLine("enter Rtgs tranid");
                        int rtgstranid = Convert.ToInt32(Console.ReadLine());
                        payment.Pay(payment.InvNo, payment.Amt, bankname, branch, rtgstranid);

                        break;
                    case 4:
                        Console.WriteLine("Enter bankname");
                        bankname = Console.ReadLine();
                        Console.WriteLine("enter Rtgs tranid");
                        int nefttranid = Convert.ToInt32(Console.ReadLine());
                        payment.Pay(payment.InvNo, payment.Amt, bankname, nefttranid);
                        break;
                    case 5:
                        Console.WriteLine("Enter UPIId");
                        string upiid = Console.ReadLine();
                        payment.Pay(payment.InvNo, payment.Amt, upiid);
                        break;
                            
                    default:
                        Console.WriteLine("No such payment option exists... Please select from available options...");
                        break;
                    
                }
                if (payment.PaymentStatus==true)
                {
                    Console.WriteLine("Thanks received payment... keep shopping");
                }
                else
                {
                    Console.WriteLine("not recieved .. pls try in some time");
                }
                

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
