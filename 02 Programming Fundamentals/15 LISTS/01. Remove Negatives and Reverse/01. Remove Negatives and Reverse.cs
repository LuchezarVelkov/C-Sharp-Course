using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> readNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse).
                ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < readNumbers.Count; i++)
            {
                if (readNumbers[i] <= 0)
                {
                    continue;
                }
                else
                {
                    result.Add(readNumbers[i]);
                }
            }

            if (result.Count > 0)
            {
                result.Reverse();
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                Console.WriteLine("empty");

            }
        }
    }
}
