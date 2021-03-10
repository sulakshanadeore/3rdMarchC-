using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributesDemo
{
    [Emp(empid:1234,loc:"Bangalore")]
    delegate void d1();

    [Emp(1013,"Pune")]
    class Manager
    {



    }
}
