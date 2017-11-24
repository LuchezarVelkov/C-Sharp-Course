using System;

namespace _02.Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var sideA = double.Parse(Console.ReadLine());
            var sideB = double.Parse(Console.ReadLine());
            var sum = sideA * sideB;
            Console.WriteLine($"{sum:F2}");
        }
    }
}
