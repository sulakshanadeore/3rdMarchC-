using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomeAppLibrary;
namespace ExceptionHandlingAppDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion


            //try
            //{
            //    Customer c = new Customer();
            //    c.AcceptData(666);
            //    try
            //    {
            //        Customer obj = new Customer();
            //        int? cid = null;
            //        obj.AcceptData(cid);
            //        throw new NullReferenceException("This is my message of NullReference Exception");

            //    }
            //    catch (OverflowException ex)
            //    {

            //        Console.WriteLine("Inner General");
            //    }
            //    finally
            //    {
            //        Console.WriteLine("Inner Finally");
            //    }



            //    //Console.WriteLine("enter p");
            //    //int p = Convert.ToInt32(Console.ReadLine());
            //    //int p1=c.Print(p);
            //    //Console.WriteLine(p1);
            //    //int ans = c.Divide(10, 2);
            //    //Console.WriteLine(ans);
            //    //Console.WriteLine("enter i");
            //    //int i = Convert.ToInt32(Console.ReadLine());
            //    //ans = c.Divide(i, 2);
            //    //Console.WriteLine(ans);
            //    //Console.WriteLine("enter data");
            //    //string c1 = Console.ReadLine();
            //    ////char c1 = Convert.ToChar(Console.ReadLine());
            //    //string chardata=c1.Substring(0, 1);
            //    //char c1data = Convert.ToChar(chardata);
            //    //char inputChar=c.takeInput(c1data);
            //    //Console.WriteLine(inputChar);

            //}
            //catch (StackOverflowException ex)
            //{
            //    Console.WriteLine("Stack overflow for int");
            //    Console.WriteLine(ex.Message);

            //}

            //catch (DivideByZeroException ex)
            //{
            //    //   ex.Message = "You have entered 0 as denominator";
            //    Console.WriteLine("You have entered 0 as denominator");
            //    Console.WriteLine(ex.Message);

            //}

            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Pls check yr input");
            //    Console.WriteLine(ex.Message);
            //}
            //catch (OverflowException ex)
            //{

            //    Console.WriteLine("general exception fired..");
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine("Source of Exception= " + ex.Source);
            //    Console.WriteLine("Stack Trace= " + ex.StackTrace);

            //}
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine("type of ex =" + ex.GetType());
            //    Console.WriteLine(ex.Message);

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("General ....");
            //    Console.WriteLine(ex.Message);

            //}
            //finally {
            //    Console.WriteLine("Outer Finally fired");

            //}
            #endregion

            string s;

            #region OuterTryCatch
            try
            {

                #region InnerTrycatchRegion
                try
                {
                    int? i = null;
                    if (i == null)
                    {
                        throw new NullReferenceException();
                    }
                }
                catch (NullReferenceException ex)
                {

                    throw new NullReferenceException("The i is null");
                    //Console.WriteLine(ex.Message);
                }
                #endregion
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } 
            #endregion
            Console.Read();
        }
    }
}
