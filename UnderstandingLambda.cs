using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLINQDemo
{
    delegate void add(int i,int j);
    class UnderstandingLambda
    {
        static void Main(string[] args)
        {//goesto or becomes
            add del = (p,q) => 
            {
                int ans;
                ans =p + q;
                Console.WriteLine(ans);
            };

            del(10,20);
            Console.WriteLine("-----------------");
            List<Students> students = new List<Students>();
            students.Add(new Students { Rollno = 1, Name = "Akanksha", Standard = 1 });
            students.Add(new Students { Rollno = 7, Name = "Megha", Standard = 2 });
            students.Add(new Students { Rollno = 2, Name = "Raksha", Standard = 3 });
            students.Add(new Students { Rollno = 3, Name = "Shalini", Standard = 2 });
            students.Add(new Students { Rollno = 4, Name = "Harish", Standard = 2 });
            students.Add(new Students { Rollno = 5, Name = "Ankita", Standard = 3 });
            students.Add(new Students { Rollno = 6, Name = "Anita", Standard = 1 });
            
            var data = students.Select(s => s.Name);
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }

            var data1 = students.Select(s => new {rno=s.Rollno,sname=s.Name });

            foreach (var item in data1)
            {
                Console.WriteLine(item.rno + " " + item.sname);
            }

            Console.WriteLine("Single Student data");
            var rollNoOneData=students.Where(s => s.Rollno == 1);
            foreach (var item in rollNoOneData)
            {
                Console.WriteLine(item.Rollno);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Standard);
            }

            Console.WriteLine("--------");
            var result = students.OrderBy(s => s.Name);
            foreach (var item in result)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("-------------------------");
            var studdata = students.GroupBy(s => s.Standard).OrderBy(s => s.Key);
            foreach (var item in studdata)
            {
                Console.WriteLine("Standard= " + item.Key);
                foreach (var studitem in item)
                {

                    Console.WriteLine(studitem.Rollno + " " + studitem.Name + "  " + studitem.Standard);

                }
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------------------");
            var studdataOrderbyName = students.GroupBy(s => s.Standard).OrderBy(s=>s.Key).Select(g => new { key = g.Key, studobj = g.OrderBy(y => y.Rollno) });

            foreach (var item in studdataOrderbyName)
            {

                Console.WriteLine("Standard= " + item.key);
                Console.WriteLine();
                foreach (var studitem in item.studobj)
                {

                    Console.WriteLine(studitem.Rollno + " " + studitem.Name + "  " + studitem.Standard);

                }
                Console.WriteLine();
            }



            Console.Read();
        }
    }
}
