using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryCollectionDemo;
namespace NonGenericsDemo
{
    class CloneDemo
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            Customer c = new Customer();
            c.Custid = 1;
            a.Add(c);
            foreach (var item in a)
            {
                
                Console.WriteLine(item.GetType());
            }
            Console.WriteLine("cloning");
            ArrayList b = new ArrayList();
            b=(ArrayList)a.Clone();
            foreach (var item in b)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.GetType());
            }
            Console.Read();




        }
    }
}
