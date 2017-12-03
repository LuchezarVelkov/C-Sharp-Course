using System;

namespace _04.Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int readNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(SieveOfEratosthenes(readNumber));
        }

        static string SieveOfEratosthenes(int num)
        {
            bool[] primeNumbers = new bool[num + 1];

            primeNumbers[0] = primeNumbers[1] = false;

            for (int iSetTrue = 2; iSetTrue <= num; iSetTrue++)
            {
                primeNumbers[iSetTrue] = true;
            }
            
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (primeNumbers[i] == true)
                {
                    for (int j = i + 1; j <= num; j++)
                    {
                        if (j % i == 0 && primeNumbers[j] == true)
                        {
                            primeNumbers[j] = false;
                        }
                    }
                }
            }

            string result = null;
            for (int i = 0; i <= num; i++)
            {
                if (primeNumbers[i] == true)
                {
                    result += i + " ";
                }
            }
            return result; //2 3 5 7 11 13 17 19 23
        }
    }
}
