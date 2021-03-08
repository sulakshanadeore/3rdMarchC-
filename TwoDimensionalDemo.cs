using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
    class TwoDimensionalDemo
    {
        static void Main(string[] args)
        {
            //Rows & Col
            int[,] arr=new int[4,3]{{1,2,4},{6,7,8},{10,11,12},{45,56,67 } };
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i,j] + "\t");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Copied array");
            int[,] arr1 = new int[4, 3];
            Array.Copy(arr, arr1,arr.Length);

            foreach (var item in arr1)
            {
                
                    Console.Write(item + "\n");
                
            }

            Console.ReadLine();
            
          



        }
    }
}
