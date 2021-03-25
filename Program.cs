using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace CodeFirstApproachDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var ctx = new SchoolContext())
            //                {
            //    var grade1 = new Grade() { GradeID = 1, GradeName = "One" };

            //    ctx.Grades.Add(grade1);
            //    ctx.SaveChanges();

            //    var stud = new Student() { StudentName = "Jack", BirthDate = new DateTime(1998, 3, 12), Height = 4, StudentID = 1 };
            //    ctx.Students.Add(stud);
            //    ctx.SaveChanges();


            //}

            SchoolContext context = new SchoolContext();

            Console.WriteLine("done");
            Console.Read();

        }
    }
}
