using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLibrary;
namespace OOPs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter Employeeid");
            //int empid = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Employee Name");
            //string empname = Console.ReadLine();

            //Console.WriteLine("Enter Employee City");
            //string empcity = Console.ReadLine();



            //Employee emp = new Employee();
            //emp.AcceptEmployeeDetails(empid, empname, empcity);
            //emp.ShowDetails(out int eid, out string ename, out string city);
            //Console.WriteLine(eid + " " + ename + " " + city);



            //string a=Employee.AcceptData();
            //Console.WriteLine(a);
            //string b=Employee.ShowData();
            //Console.WriteLine(b);

            //int fno, sno;
            //fno = 10;
            //sno = 20;

            //int ans=Employee.AddNos(fno, sno);
            //Console.WriteLine(ans);


            //Employee emp1 = new Employee();//instance of Employee , instance name is emp1-- () create instance -- they are called default constructor
            //emp1.employeeid = 1;
            //emp1.employeename = "A";
            //Employee emp2 = new Employee();
            //emp2.employeeid = 2;
            //emp2.employeename = "B";
            //bool ans=emp1.Equals(emp2);
            //Console.WriteLine(ans);

            //bool secondans=emp1.employeename.Equals(emp2.employeename);
            //Console.WriteLine(secondans);


            //Employee emp3=new Employee();
            //emp3 = emp2;
            //emp3.employeeid = 4;
            //emp3.employeename = "C";
            //Console.WriteLine("Print Emp3");
            //Console.WriteLine(emp3.employeeid);
            //Console.WriteLine(emp3.employeename);
            //Console.WriteLine("Print Emp2");
            //Console.WriteLine(emp2.employeeid);
            //Console.WriteLine(emp2.employeename);
            //Console.WriteLine("Compare emp2 & emp3");
            //bool c = emp3.Equals(emp2);

            //if (emp2==emp3)
            //{
            //    Console.WriteLine("they are equal");
            //}
            //else
            //{
            //    Console.WriteLine("Not equal");
            //}


            //Console.WriteLine(c);


            //Employee e1 = new Employee();
            //e1.AcceptEmployeeDetails(12, "ABC", "Pune");
            //Console.WriteLine("Without out, using string as return type");
            //string data=e1.ShowDetails();
            //Console.WriteLine(data);
            //Console.WriteLine("Using Out....");
            //e1.DisplayDetails(out int empid, out string empname, out string empcity);
            //Console.WriteLine(empid);
            //Console.WriteLine(empname);
            //Console.WriteLine(empcity);

            Emp e1 = new Emp();
            string e1data=e1.ShowEmpDetails();
            Console.WriteLine(e1data);

            Emp e2 = new Emp(1, "Aniket");
            string e2data=e2.ShowEmpDetails();
            Console.WriteLine(e2data);

            Emp e3 = new Emp(2,"Nachiket","Pune","Maharashtra");
            
            string e3data=e3.ShowEmpDetails();
            Console.WriteLine(e3data);

            Emp e4 = new Emp(e3);


            Console.ReadKey();

        }
    }
}
