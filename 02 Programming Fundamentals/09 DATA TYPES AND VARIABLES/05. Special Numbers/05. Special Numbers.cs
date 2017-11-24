using System;

namespace _05.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int readNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= readNumber; i++)
            {
                int lastDigit = i % 10;
                int firstDigit = (i / 10) % 10;
                bool specialNumber = lastDigit + firstDigit == 5 || lastDigit + firstDigit == 7 || lastDigit + firstDigit == 11;
                if (specialNumber)
                {
                    Console.WriteLine($"{i} -> {specialNumber}");
                }
                else
                {
                    Console.WriteLine($"{i} -> {specialNumber}");
                }
            }
        }
    }
}
