using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace _03.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] delete = new int[3];
            delete = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var newNumbers = numbers.Take(delete[0]).ToList();

            for (int i = 1; i <= delete[1]; i++)
            {
                newNumbers.RemoveAt(0);
            }
            
            if (newNumbers.Contains(delete[2]))
            {
                Console.WriteLine($"YES!");

            }
            else
            {
                Console.WriteLine($"NO!");

            }
        }
    }
}
