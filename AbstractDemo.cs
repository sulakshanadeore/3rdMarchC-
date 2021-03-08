using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLibrary;
namespace OOPs
{
    class AbstractDemo
    {
        static void Main(string[] args)
        {
            //GeoShapes shapes = new GeoShapes();
            Circle circle = new Circle();
            double Circlearea=circle.CalculateArea(radius: 3);
            Console.WriteLine(Circlearea);

            Triangle t = new Triangle();
            t.Height = 12;
            double triArea=t.CalculateArea(height:t.Height,width: 3);
            Console.WriteLine(triArea);

            Console.Read();
        }
    }
}
