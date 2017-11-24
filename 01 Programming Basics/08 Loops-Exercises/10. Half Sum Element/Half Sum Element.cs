using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var readNumber = int.Parse(Console.ReadLine());
            var sum = 0;
            var maxNum = 0;
            for (int i = 1; i <= readNumber; i++)
            {
                var number = int.Parse(Console.ReadLine());
                sum += number;
                if (number > maxNum)
                {
                    maxNum = number;
                }
            }
            if (maxNum == (sum-maxNum))
            {
                Console.WriteLine("Yes, Sum = " + maxNum);
            }
            else
            {
                var difference = sum - maxNum;
                var differenceToMaxNum = Math.Abs(maxNum - difference);
                Console.WriteLine("No, Diff = " + differenceToMaxNum);
            }
        }
    }
}
