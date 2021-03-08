using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {10,23,213,3,5,32,256,2146,266 };
            int[] a1 = new int[10];
            a1[0] = 100;
            a1[1] = 45;

            //Array index starts from 0

            int[] a2 = new int[10];
            a2[0] = a1[0];

            Console.WriteLine("Using for loop");
            for (int i = 0; i < a2.Length; i++)
            {
                Console.WriteLine(a2[i]);
            }

            var j = 67.32455f;
            char[] c1 = new char[4] { 'a', 'b', 't', 'z' };

            Console.WriteLine("Using for each loop");
            foreach (var item in c1)
            {
                Console.WriteLine(item);

            }



            Array.Clear(a2, 0, a2.Length);
            Array.Copy(arr, a2, arr.Length);
            Console.WriteLine("Now the a2 arr contains");
            foreach (var item in a2)
            {
                Console.WriteLine(item);
            }
            Array.Clear(a2, 0, a2.Length);

            Console.WriteLine("Copying some elements");
            Array.Copy(arr, 3, a2, 3, 5);

            foreach (var item in a2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------");

            Console.WriteLine("-------------");
            Array.Sort(arr);
            Console.WriteLine("Array sorting");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Array sorting descending");
            Array.Reverse(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }


            Console.Read();
           


        }
    }
}
