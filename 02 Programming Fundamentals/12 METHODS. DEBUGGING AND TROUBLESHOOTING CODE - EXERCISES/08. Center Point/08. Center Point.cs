using System;

namespace _08.Center_Podouble
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());


            Console.WriteLine(CordinateCheck(x1,y1,x2,y2)); //(-1, 2)
        }

        static string CordinateCheck(double x1, double y1, double x2, double y2)
        {
            string result = null;
            double distance1 = Math.Sqrt(Math.Pow(x1,2) + Math.Pow(y1,2));
            double distance2 = Math.Sqrt(Math.Pow(x2,2) + Math.Pow(y2,2));
            if (distance1 < distance2)
            {
                result = $"({x1}, {y1})";
            }
            else if (distance2 < distance1)
            {
                result = $"({x2}, {y2})";
            }
            else
            {
                result = $"({x1}, {y1})";
            }
            return result;
        }
    }
}
