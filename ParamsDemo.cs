using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
    class ParamsDemo
    {
        static int SumElements(params int[] a)
        {

            int sum = 0;
            foreach (int item in a)
            {
                sum += item;
            }
            return sum;
        }
        static void Main(string[] args)
        {
           int ans= ParamsDemo.SumElements(2, 3, 4, 6, 6);
            Console.WriteLine(ans);
            Console.Read();
        }
    }
}
