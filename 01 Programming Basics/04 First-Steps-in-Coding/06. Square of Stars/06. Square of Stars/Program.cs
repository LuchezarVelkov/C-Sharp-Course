﻿using System;

namespace Print_Squart_at_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', n));
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write("*");
                Console.Write(new string(' ', n - 2));
                Console.WriteLine('*');
            }
            Console.WriteLine(new string('*', n));
        }
    }
}
