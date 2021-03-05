using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public interface ITravel
    {
        string TravelMode();

    }

    public class TwoWheeler:InvoicePayment,ITravel
    {

        public int NoofWheels { get; set; }

        public string TravelMode()
        {
            string mode = "TwoWheeler";
            return mode;
        }
    }
     interface ITravelDetails {
        string ShowDetails(DateTime traveldate);

    }

    public class TrainTravel :InvoicePayment,ITravel,ITravelDetails
    {
        
        
        public string ShowDetails(DateTime traveldate)
        {
            //throw new NotImplementedException();

            DateTime dt = traveldate;
            return dt.ToLongDateString();
        }

        public string TravelMode()
        {
            string mode = "TrainTravel";
            return mode;
        }
    }


}
