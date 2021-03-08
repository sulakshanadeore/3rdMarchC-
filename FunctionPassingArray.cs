using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
    class FunctionPassingArray
    {
        //static int SumElements(int[] a, int size)
        //{
            
        //    int sum=0;
        //    for (int i = 0; i < size; i++)
        //    {
        //        sum = sum + a[i];
        //    }
        //    return sum;
        //}


        static dynamic SumElements(dynamic[] a, int size)
        {

            dynamic sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum = sum + a[i];
            }
            return sum;
        }


        static void Main(string[] args)
        {
            dynamic[] a1 = new dynamic[] { 1.4, 3.6, 4.67,45.1 };
            dynamic ans=FunctionPassingArray.SumElements(a1, 3);
            Console.WriteLine(ans);
            Console.Read();
        }
    }
}
