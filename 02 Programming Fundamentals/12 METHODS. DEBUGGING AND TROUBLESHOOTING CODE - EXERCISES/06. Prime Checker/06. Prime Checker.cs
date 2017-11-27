using System;

namespace _06.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long readNumber = long.Parse(Console.ReadLine());
            Console.WriteLine(ItIsPrime(readNumber));
        }

        static bool ItIsPrime(long readNumber)
        {
            bool isPrime = true;
            if (readNumber <= 1)
            {
                isPrime = false;
            }
            if (readNumber % 2 == 2 && readNumber != 2) // 2 is only even prime number.
            {
                isPrime = false;
            }
            if (isPrime) // for speed optimization, if readNumber is odd can`t be Prime.
            {
                for (long i = 2; i <= readNumber - 1; i++)
                {
                    if (readNumber % i == 0) // one number is prime if can 
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            //string result = isPrime ? "Prime" : "Not Prime";
            return isPrime;
        }
    }
}
