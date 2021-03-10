using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    class Test
    {
        private int n;
        public Test()
        {

        }
        public Test(int a)
        {
            n = a;
        }
        public  void Foo(int a,int b)
        {
            Console.WriteLine("Hello");
            Console.WriteLine(a+b);

        }


    }
}
