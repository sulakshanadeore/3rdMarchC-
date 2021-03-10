using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public delegate int d1(int a, int b);
    public delegate void d_multi(int a, int b);

    public delegate[] void d_multi2(int a, int b);
    public class Calculations
    {
        public void m5(int i, int j)
        {

            Console.WriteLine(i * j);
        }
        public void m3(int i, int j)
        {

            Console.WriteLine(i+j);
        }

        public void m4(int i, int j)
        {

            Console.WriteLine(i - j);
        }

        public int m2(int i, int j)
        {
            int k = i - j;
            return k;

        }

        public int m1(int i, int j)
        {
            int k = i + j;
            return k;
        }
    }
}
