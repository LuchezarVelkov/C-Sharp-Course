using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            var readNumber = int.Parse(Console.ReadLine());
            var firstNumber = 0;
            var secondNumber = 1;
            for (int i = 1; i <= readNumber; i++)
            {
                int newNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = newNumber;

            }
            Console.WriteLine(secondNumber);
        }
    }
}
