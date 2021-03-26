using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeAppLibrary
{
    public class Customer
    {
        Nullable<int> custid;
        //string s1 = null;
        //int no1 = null;//VAlue types cannot be assigned a null
        //Nullable<int> no1 = null;
        

        public void AcceptData(int? _custid)
        {
            this.custid = _custid;
            if (this.custid == null)
            {
                Console.WriteLine("custid is null");
             //   throw new NullReferenceException();
            }
            else
            {
                Console.WriteLine("cust id= " + custid);
            }
        }

        public int Print(int i)
        {
            i += 242342;
            return i;

        }

        public int Divide(int i, int j)
        {
            return i / j;
        }
        public char takeInput(char c)
        {
            return c;
        }

    }
}
