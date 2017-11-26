using System;

namespace _09.Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int readNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvensAndOdds(readNumber));
        }

        static int GetMultipleOfEvensAndOdds(int readNumber)
        {
            int even = 0;
            int odd = 0;
            while (readNumber != 0)
            {
                int lastDigit = readNumber % 10;
                if (lastDigit % 2 == 0)
                {
                    even += lastDigit;
                }
                else
                {
                    odd += lastDigit;
                }
                readNumber = readNumber / 10;
            }
            int sum = even * odd;
            return sum;
        }
    }
}
