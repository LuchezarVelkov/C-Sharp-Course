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
                for (int i2 = 2; i2 <= Math.Sqrt(readNumber); i2++)
                {
                    if (readNumber % i2 == 0)
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
