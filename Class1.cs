using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [Serializable()]
    public class Customer
    {

        public int CustomerID { get; set; }

        public int Amt { get; set; }

        public DateTime TranDate { get; set; }

        [NonSerialized()]
        private int _cardno;

        public int Cardno
        {
            get { return _cardno; }
            set { _cardno = value; }
        }

    }
}
