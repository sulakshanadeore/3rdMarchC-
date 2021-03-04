using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Emp
    {
        
        private static int _empid=1;
        private string _ename;
        private string _city;
        private string _state;
        //constructor is method without return type and has same name of the class
        //Default constructor-optional, is required if u want to call the default constructor for object creation
        public Emp()
        {
            Console.WriteLine(_empid);
        }

        
        //Parameterised Constructor
        public Emp(int empid, string ename):this(empid)
        {
           
            _ename = ename;

        }

        public Emp(int empid)
        {
            _empid = _empid+1;
        }
        //Constructor Chaining
        public Emp(int empid,string ename,string city):this(empid,ename)
        {
            _city = city;
        }

        public Emp(int empid,string ename,string city,string state):this(empid,ename,city)
        {
            _state = state;
        }

        public Emp(Emp copy)
        {
            //_empid = copy._empid;
            _ename = copy._ename;
            _city = copy._city;
            _state = copy._state;
            Console.WriteLine("copied all data successfully...");
        }

        static Emp()
        {
            //static constructor  automatically called
            //It is called once in the life time  of the class
            //They are used for initilization  purpose
            Console.WriteLine("This constructor is called befre ay other constructor for the class i called ...." +
                "U are the first user");
        }

        public string ShowEmpDetails()
        {
            return _empid + _ename + _city  + _state;
        }


    }
}
