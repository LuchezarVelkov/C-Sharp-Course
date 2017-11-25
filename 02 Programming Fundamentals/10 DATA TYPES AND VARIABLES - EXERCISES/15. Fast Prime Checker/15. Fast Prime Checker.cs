using System;

namespace _15.Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int readMaxNumber = int.Parse(Console.ReadLine());
            for (int currentNumber = 2; currentNumber <= readMaxNumber; currentNumber++)
            {
                bool prime = true;
                for (int i2 = 2; i2 <= Math.Sqrt(currentNumber); i2++)
                {
                    if (currentNumber % i2 == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                Console.WriteLine($"{currentNumber} -> {prime}");
            }

        }
    }
}
