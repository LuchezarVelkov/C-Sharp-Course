using System;

namespace _12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int readNumberN = int.Parse(Console.ReadLine()); // first digit decreas from N to 1
            int readNumberM = int.Parse(Console.ReadLine()); // second digit increas from 1 to M
            int maxSum = int.Parse(Console.ReadLine());
            int sum = 0;
            int combinations = 0;

            for (int num1 = readNumberN; num1 >= 1; num1--)
            {
                if (sum >= maxSum)
                {
                    break;
                }
                for (int num2 = 1; num2 <= readNumberM; num2++)
                {
                    //Console.WriteLine($"{num1} {num2}");
                    sum = sum + (3 * (num1 * num2));
                    combinations++;
                    if (sum >= maxSum)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"{combinations} combinations");
            if (sum < maxSum)
            {
                Console.WriteLine($"Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"Sum: {sum} >= {maxSum}");
            }
        }
    }
}
