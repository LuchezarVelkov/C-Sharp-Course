using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersToRead = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;
            for (int i = 0; i < numbersToRead; i++)
            {
                int numberRead = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += numberRead;
                }
                else
                {
                    oddSum += numberRead;
                }
            }
            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes, sum = " + evenSum);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(evenSum - oddSum));
            }
        }
    }
}
