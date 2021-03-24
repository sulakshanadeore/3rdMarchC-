using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 13, 23, 456, 7, 221, 1135, 3456 };
            //Syntax
            var output = from a in arr
                         where a > 100
                         select a;

            //SQL--- select & then filter

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------");
            List<Products> list = new List<Products>();
            list.Add(new Products { Prodid = 1,Pname="Tea" ,Catid = 1 });
            list.Add(new Products { Prodid = 2, Pname = "Iced Tea", Catid = 2 });
            list.Add(new Products { Prodid = 3, Pname = "Coffee", Catid = 3 });
            list.Add(new Products { Prodid = 4, Pname = "Snacks", Catid = 3 });
            list.Add(new Products { Prodid = 5, Pname = "Cold Drinks", Catid = 2 });


            var pdata = from p in list
                        where p.Catid == 2
                        select p;
            foreach (var item in pdata)
            {
                Console.WriteLine(item.Prodid +  " " + item.Catid);
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------");


            //Group by category---- categorywise list of products
            //catedogry -1
            //list of product in that category

            var result = from p in list
                         group p by p.Catid into egroup
                         select egroup;
            foreach (var item in result)
            {
                Console.WriteLine("Category id=" + item.Key);
                foreach (var item1 in item)
                {
                    Console.WriteLine(item1.Prodid + " " + item1.Pname);
                }
                Console.WriteLine("------------");
            }
            Console.WriteLine("------------------------");

            List<Students> students = new List<Students>();
            students.Add(new Students {Rollno=1,Name="Akanksha",Standard=1 });
            students.Add(new Students { Rollno = 7, Name = "Megha", Standard = 2 });
            students.Add(new Students { Rollno = 2, Name = "Raksha", Standard = 3 });
            students.Add(new Students { Rollno = 3, Name = "shalini", Standard = 2 });
            students.Add(new Students { Rollno = 4, Name = "harish", Standard = 2 });
            students.Add(new Students { Rollno = 5, Name = "Ankita", Standard = 3 });
            students.Add(new Students { Rollno = 6, Name = "Anita", Standard = 1 });

            var studdata = from s in students
                           group s by s.Standard into stdGroup
                           orderby stdGroup.Key descending
                           select stdGroup;

            foreach (var item in studdata)
            {
                Console.WriteLine("Standard= " + item.Key);
                foreach (var studitem in item)
                {

                    Console.WriteLine( studitem.Rollno+ " " + studitem.Name + "  " + studitem.Standard);

                }
                Console.WriteLine();
            }

            Console.Read();

        }
    }
}
