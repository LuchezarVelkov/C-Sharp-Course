using System;

namespace _06.Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double area = Calculate_Triangle_Area(sideA, sideB);
            Console.WriteLine($"{area}");

        }

        static double Calculate_Triangle_Area(double sideA, double sideB)
        {
            double area = (sideA * sideB) / 2;
            return area;
        }
    }
}
