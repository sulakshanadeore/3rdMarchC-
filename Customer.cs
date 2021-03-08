using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCollectionDemo
{
    public class Customer
    {
        public Customer()
        {

        }

        public Customer(int cid,string cname,string custcity)
        {
            this.Custid = cid;
            this.Custname = cname;
            this.City = custcity;
        }
        public int Custid { get; set; }

        public string  Custname { get; set; }
        public string City { get; set; }
    }
}
