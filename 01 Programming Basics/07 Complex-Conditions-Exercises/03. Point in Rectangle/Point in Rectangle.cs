﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Point_in_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            if ((x1 < x2) && (y1 < y2))
            {
                if ((x >= x1) && (x <= x2))
                {
                    if ((y >= y1) && (y <= y2))
                    {
                        Console.WriteLine("Inside");
                    }
                    else
                    {
                        Console.WriteLine("Outside");
                    }
                }
                else
                {
                    Console.WriteLine("Outside");
                }
            }
        }
    }
}
