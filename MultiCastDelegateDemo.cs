using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelegatesDemo;
namespace EventsDelegatesDemo
{
    class MultiCastDelegateDemo
    {
        static event d_multi g1;
        static event d_multi[] g2;



        static void Main(string[] args)
        {

            Calculations obj = new Calculations();
            //Synchronous invocation
            //d_multi[] delarr = new d_multi[2] {obj.m3,obj.m4 };
            //d_multi mydel=(d_multi)MulticastDelegate.Combine(delarr);

            g1 += new d_multi(obj.m3);
            g1 += new d_multi(obj.m4);
            g1 += new d_multi(obj.m5);
            g1(100, 200);

            

            //mydel(100, 20);
            //mydel.Invoke(100, 20);


            //d1 obj1 = new d1(obj.m1);
            //int a=obj1.Invoke(200, 300);
            //Console.WriteLine(a);
            Console.Read();

        }
    }
}
