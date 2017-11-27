using System;

namespace _05.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int readNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(FibonacciNumbers(readNumber));
        }

        static int FibonacciNumbers(int readNumber)
        {
            var firstNumber = 0;
            var secondNumber = 1;
            for (int i = 1; i <= readNumber; i++)
            {
                int newNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = newNumber;
            }
            return secondNumber;
        }
    }
}
