using System;
using System.Linq;

namespace _05.Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //var numbers = Console.ReadLine().Split(' ').Select(s => double.Parse(s)).ToArray();
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);
                numbers[i] = Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($" => {numbers[i]}");

            }
        }
    }
}
