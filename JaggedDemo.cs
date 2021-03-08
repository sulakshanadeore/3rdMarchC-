using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
    class JaggedDemo
    {
        static void Main(string[] args)
        {
            int[][] a = new int[4][];
            a[0] = new int[3] {1,2,3 };
            a[1] = new int[4] { 10, 11, 12,0 };
            a[2] = new int[2] { 100, 200 };
            a[3] = new int[5] { 1000, 2000, 3000, 4000, 5000 };

            foreach (var item in a)
            {
                Console.WriteLine();
                foreach (var item1 in item)
                {
                    Console.Write(item1 + "\t");
                }
            }
            Console.Read();
        }
    }
}
