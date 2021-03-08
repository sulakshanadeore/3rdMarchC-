using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{

   public abstract class GeoShapes
    {
        public int Length { get; set; }
        public int Height { get; set; }

        public  void ShowInfoOfShapes()
        {
            Console.WriteLine("cirlce has radius");
            Console.WriteLine("Triangle has height and base");
            Console.WriteLine("Rectangle has height and width");
        }

        public abstract double CalculateArea(int length=0,int width=0,int height=0,int radius=0);


      
    }

   public class Circle : GeoShapes
    {
        public override sealed double CalculateArea(int length = 0, int width = 0, int height = 0, int radius = 0)
        {
            return Math.PI * radius * radius;
        }
    }

    public class Triangle : GeoShapes
    {
        public override double CalculateArea(int length = 0, int width = 0, int height = 0, int radius = 0)
        {
            const float i = 0.5f;
            return i * width * height;
        }
    }
}
