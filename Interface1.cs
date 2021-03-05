using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
  public  interface Interface1
    {
         void M1();

    }

    public interface Interface2
    {
        void M2();
    }

    interface I3:Interface1,Interface2
    {
        void M3();
    }

    class AnotherClass : MyClass,I3
    {
        public new void M1()
        {
            throw new NotImplementedException();
        }

        public void M2()
        {
            throw new NotImplementedException();
        }

        public void M3()
        {
            throw new NotImplementedException();
        }
    }

    public class MyClass : Interface1, Interface2
    {
        public void M1()//std 
        {
            throw new NotImplementedException();
        }

        void Interface2.M2()//explicit
        {
            throw new NotImplementedException();
        }
    }
}
