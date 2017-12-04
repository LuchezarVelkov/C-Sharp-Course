using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> readNumber = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> sqrtNumbers = new List<int>();

            for (int i = 0; i < readNumber.Count; i++)
            {
                if (Math.Sqrt(readNumber[i]) == (int)Math.Sqrt(readNumber[i]))
                {
                    sqrtNumbers.Add(readNumber[i]);

                }
            }

            sqrtNumbers.Sort();
            sqrtNumbers.Reverse();
            Console.WriteLine(string.Join(" ", sqrtNumbers));
        }
    }
}
