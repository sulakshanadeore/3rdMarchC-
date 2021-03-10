using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributesDemo
{
    [System.AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = true)]
     class EmpAttribute : Attribute
    {
        // See the attribute guidelines at 
        //  http://go.microsoft.com/fwlink/?LinkId=85236
        public int Empid { get; set; }
        public string Location { get; set; }

        public EmpAttribute(int empid,string loc)
        {
            Empid = empid;
            Location = loc;
        }

        readonly string positionalString;

        // This is a positional argument
        public EmpAttribute(string positionalString)
        {
            this.positionalString = positionalString;

            // TODO: Implement code here

            throw new NotImplementedException();
        }

        public string PositionalString
        {
            get { return positionalString; }
        }

        // This is a named argument
        public int NamedInt { get; set; }
    }



    //[System.AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    //sealed class OfficeAttribute : EmpAttribute
    //{
    //    // See the attribute guidelines at 
    //    //  http://go.microsoft.com/fwlink/?LinkId=85236
    //    readonly string positionalString;

    //    // This is a positional argument
    //    public MyAttribute(string positionalString)
    //    {
    //        this.positionalString = positionalString;

    //        // TODO: Implement code here

    //        throw new NotImplementedException();
    //    }

    //    public string PositionalString
    //    {
    //        get { return positionalString; }
    //    }

    //    // This is a named argument
    //    public int NamedInt { get; set; }
    //}
}
