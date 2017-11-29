using System;

namespace _07.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int stopNum = int.Parse(Console.ReadLine());
            Console.WriteLine(CheckPrimeFromTo(startNum, stopNum)); // 2, 3, 5, 7
        }

        static string CheckPrimeFromTo(int startNum, int stopNum)
        {
            bool itsPrime = true;
            string prime = null;
            for (int currentNumber = startNum; currentNumber <= stopNum; currentNumber++)
            {
                if (currentNumber < 2 || currentNumber % 2 == 2 && currentNumber != 2)
                {
                    itsPrime = false;
                }
                if (itsPrime)
                {
                    for (int i2 = 2; i2 <= Math.Sqrt(currentNumber); i2++)
                    {
                        if (currentNumber % i2 == 0)
                        {
                            itsPrime = false;
                            break;
                        }
                    }
                    if (itsPrime)
                    {
                        if (prime == null)
                        {
                            prime += $"{currentNumber}";
                        }
                        else
                        {
                            prime += $", {currentNumber}";
                        }
                    }
                }
                itsPrime = true;
            }
            return prime;
        }
    }
}
