using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Employee
    {
        //variables must always be private
         private int employeeid;
         private string employeename;
         private string employeecity;

         public void AcceptEmployeeDetails(int empid,string ename,string city)
        {
            employeeid = empid;
            employeename = ename;
            employeecity = city;
        }

        public void DisplayDetails(out int empid,out string empname,out string empcity)
        {
            empid = employeeid;
            empname = employeename;
            empcity = employeecity;

        }

        public string ShowDetails()
        {
            
            return employeeid + employeename + employeecity;



        }

        public static string AcceptData()
        {
            return "Accepting Data here....";
        }

        public static string ShowData()
        {
            return "Showing Data here";

        }

        public static int AddNos(int i, int j)
        {
            int k = 0;
            k = i + j;
            return k;
        }




    }
}
