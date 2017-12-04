using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> readNumbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            readNumbers.Sort();
            Console.WriteLine(string.Join(" <= ",readNumbers));
        }
    }
}
