using System;
using System.Numerics;

namespace _13.Factorial
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
            Console.WriteLine($"{result}");

        }
    }
}
