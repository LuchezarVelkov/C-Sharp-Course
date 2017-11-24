using System;

namespace _11.Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int readNumber = int.Parse(Console.ReadLine());

            while (readNumber % 2 == 0)
            {
                Console.WriteLine("Please write an odd number.");
                readNumber = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The number is: {Math.Abs(readNumber)}");
        }
    }
}
