using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelegatesDemo;
namespace EventsDelegatesDemo
{
    class Program
    {
        //To declare event---- event delegatename eventname
        public delegate string d2(string s1, string s2);
        static event d2 myclickEvent;
        static event d1 myclickEvent2;
        //event points to delegate and delegate points to method
        static void Main(string[] args)
        {

            //Calculations calculations = new Calculations();

            //   d1 obj = new d1(calculations.m1);
            //   int ans=obj(10, 100);
            //   Console.WriteLine(ans);
            //Calculations calculations = new Calculations();
            // myclickEvent += new d1(calculations.m1);
            // int ans=myclickEvent(10, 20);
            // Console.WriteLine(ans);

            // //Console.WriteLine("Removed m1 reference");
            // //myclickEvent -= new d1(calculations.m1);

            // Console.WriteLine("added m2 reference");
            // myclickEvent+=new d1(calculations.m2);
            // //myclickEvent2 += new d1(calculations.m2);
            // // ans=myclickEvent2(100, 20);
            // ans = myclickEvent(100, 20);
            //Console.WriteLine(ans);


            //myclickEvent += Program_myclickEvent;
            //Console.WriteLine( myclickEvent(10, 20));


            myclickEvent += Program_myclickEvent1;
            string a=myclickEvent("Hello", "World");
            Console.WriteLine(a);

            Console.Read();


        }

        private static string Program_myclickEvent1(string s1, string s2)
        {
            //throw new NotImplementedException();
            string s3=string.Concat(s1, s2);
            return s3;
        }

        private static int Program_myclickEvent(int a, int b)
        {
            // throw new NotImplementedException();
            return a * b;
        }
    }
}
