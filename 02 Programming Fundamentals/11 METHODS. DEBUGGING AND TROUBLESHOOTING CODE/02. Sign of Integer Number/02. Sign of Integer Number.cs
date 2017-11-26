using System;

namespace _02.Sign_of_Integer_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            double readNumber = double.Parse(Console.ReadLine());
            PrintSign(readNumber);
        }

        private static void PrintSign(double number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");

            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");

            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");

            }
        }
    }
}
