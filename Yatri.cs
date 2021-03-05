using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLibrary;
namespace OOPs
{
   public class Yatri
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Mode of travel");
            string mode = Console.ReadLine();
            ITravel travel = new TwoWheeler();
                   

            string tmode=travel.TravelMode();

            if (mode == tmode)
            {
                TwoWheeler tw = new TwoWheeler();
                tw.NoofWheels = 2;
                tw.Pay(12, 33, "sdfsf@ok");
                bool ans = tw.PaymentStatus;
                Console.WriteLine(ans);
            }
            else
            {
                                                             TrainTravel traintravel = new TrainTravel();
                traintravel.InvNo = 123;
                traintravel.Amt = 1000;
                DateTime dt = new DateTime(2021, 03, 12);
                string det = traintravel.Pay(traintravel.InvNo, traintravel.Amt);
                Console.WriteLine(det);
                string data = traintravel.ShowDetails(dt);
                Console.WriteLine("Your date of travel- " + data);
            }
            
            Console.Read();
        }
    }
}
