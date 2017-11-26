using System;

namespace _05.Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double farenheith = double.Parse(Console.ReadLine());
            double celsius = FarenheithToCelsius(farenheith);
            Console.WriteLine($"{celsius:F2}");

        }

        static double FarenheithToCelsius(double readNumber)
        {
            double celsius = (readNumber - 32) / 1.8;
            return celsius;
        }
    }
}
