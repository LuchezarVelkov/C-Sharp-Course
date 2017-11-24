using System;

namespace _03.Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            var readNumber = double.Parse(Console.ReadLine());
            double sumKm = readNumber * 1.60934;
            Console.WriteLine($"{sumKm:F2}");
        }
    }
}
