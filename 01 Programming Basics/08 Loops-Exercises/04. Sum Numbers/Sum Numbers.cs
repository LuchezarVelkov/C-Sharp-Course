﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersToSum = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < numbersToSum; i++)
            {
                var number = int.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
