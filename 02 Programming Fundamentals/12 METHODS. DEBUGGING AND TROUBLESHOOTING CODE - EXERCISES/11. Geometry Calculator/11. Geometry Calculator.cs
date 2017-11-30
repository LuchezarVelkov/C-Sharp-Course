using System;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeToCalculate = Console.ReadLine().ToLower();
            if (typeToCalculate == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine(AreaOfTriangle(side,height));
            }
            else if (typeToCalculate == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine(AreaOfSquare(side));
            }
            else if (typeToCalculate == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine(AreaOfRectangle(width,height));
            }
            else if (typeToCalculate == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine(AreaOfCircle(radius));
            }
        }

        static string AreaOfCircle(double radius)
        {
            string result = (Math.PI * radius * radius).ToString("0.00");
            return $"{result}";
        }

        static string AreaOfSquare(double side)
        {
            string result = Math.Pow(side,2).ToString("0.00");
            return $"{result}";
        }

        static string AreaOfRectangle(double width, double height)
        {
            string result = (width * height).ToString("0.00");
            return $"{result}";
        }

        static string AreaOfTriangle(double side, double height)
        {
            string result = ((side * height) /2).ToString("0.00");
            return result;
        }
    }
}
