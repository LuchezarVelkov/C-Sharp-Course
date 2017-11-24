using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersToRead = int.Parse(Console.ReadLine());
            int firstSum = 0;
            int secondSum = 0;
            for (int i = 0; i < numbersToRead; i++)
            {
                var readNumber = int.Parse(Console.ReadLine());
                firstSum += readNumber;
            }
            for (int i = 0; i < numbersToRead; i++)
            {
                var readNumber = int.Parse(Console.ReadLine());
                secondSum += readNumber;
            }
            if (firstSum == secondSum)
            {
                Console.WriteLine("Yes, sum = " + firstSum);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(firstSum - secondSum));
            }
        }
    }
}
