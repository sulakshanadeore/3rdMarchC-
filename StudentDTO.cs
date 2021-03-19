using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstCoreMVCWebApplication.Models;
namespace FirstCoreMVCWebApplication.DTO
{
    public class StudentDTO
    {
        static List<Student> studs = new List<Student>();

        public List<Student> GetStudents()
        {

            studs.Add(new Student {FirstName="A",LastName="A",Mobile="22234",Email="a@gmail.com" });

            studs.Add(new Student { FirstName = "B", LastName = "B", Mobile = "33334", Email = "b@gmail.com" });

            studs.Add(new Student { FirstName = "C", LastName = "C", Mobile = "66634", Email = "c@gmail.com" });

            return studs;
        }
    }
}
