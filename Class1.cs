using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialViewsExceptionHandingDemo.Models
{
    public class Class1
    {

        public int firstnumber { get; set; }

        public int secondnumber { get; set; }

        public int Addition { get { return firstnumber + secondnumber; } }


        public int subtraction { get { return firstnumber - secondnumber; } }
    }
}