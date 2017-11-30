using System;
using System.Numerics;

namespace _14.Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger readNumber = BigInteger.Parse(Console.ReadLine());
            BigInteger result = 1;
            for (int i = 2; i <= readNumber; i++)
            {
                result = result * i;
            }
            int numberOfZeros = 0;
            while (true)
            {
                if (result % 10 == 0)
                {
                    numberOfZeros++;
                    result = result / 10;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"{numberOfZeros}");

        }
    }
}
