using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> readNumbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int number = 0;
            int count = 1;
            int maxCount = 0;

            for (int i = 0; i < readNumbers.Count -1; i++)
            {
                if (readNumbers[i] == readNumbers[i + 1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        number = readNumbers[i];
                    }
                }
                else
                {
                    count = 1;
                }
            }
            if (maxCount == 0)
            {
                Console.WriteLine(readNumbers[0]);
            }
            else
            {
                for (int i = 0; i < maxCount; i++)
                {
                    Console.Write($"{number} ");
                }
            }
        }
    }
}
