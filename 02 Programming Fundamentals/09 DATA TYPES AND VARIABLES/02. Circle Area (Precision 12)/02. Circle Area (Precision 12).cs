﻿using System;

namespace _02.Circle_Area__Precision_12_
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f12}", Math.PI * r * r);
            //double radius = Math.PI * r * r;
            //Console.WriteLine($"{radius:F12}");
        }
    }
}
