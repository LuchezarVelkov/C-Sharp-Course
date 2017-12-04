using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> readNumbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();
            
            int index = 0;
            while (index != (readNumbers.Count -1))
            {
                if (readNumbers[index] == readNumbers[index +1])
                {
                    readNumbers[index] += readNumbers[index + 1];
                    readNumbers.RemoveAt(index + 1);
                    index = 0;
                }
                else
                {
                    index++;
                }
            }
            Console.WriteLine($"{string.Join(" ",readNumbers)}");

        }
    }
}
