using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine().ToUpper();
            var town = Console.ReadLine().ToUpper();
            var quantity = double.Parse(Console.ReadLine());
            if (town == "SOFIA")
            {
                if (product == "COFFEE")
                {
                    Console.WriteLine(quantity * 0.50);
                }
                else if (product == "WATER")
                {
                    Console.WriteLine(quantity * 0.80);
                }
                else if (product == "BEER")
                {
                    Console.WriteLine(quantity * 1.20);
                }
                else if (product == "SWEETS")
                {
                    Console.WriteLine(quantity * 1.45);
                }
                else if (product == "PEANUTS")
                {
                    Console.WriteLine(quantity * 1.60);
                }
            }
            else if (town == "PLOVDIV")
            {
                if (product == "COFFEE")
                {
                    Console.WriteLine(quantity * 0.40);
                }
                else if (product == "WATER")
                {
                    Console.WriteLine(quantity * 0.70);
                }
                else if (product == "BEER")
                {
                    Console.WriteLine(quantity * 1.15);
                }
                else if (product == "SWEETS")
                {
                    Console.WriteLine(quantity * 1.30);
                }
                else if (product == "PEANUTS")
                {
                    Console.WriteLine(quantity * 1.50);
                }
            }
            else if (town == "VARNA")
            {
                if (product == "COFFEE")
                {
                    Console.WriteLine(quantity * 0.45);
                }
                else if (product == "WATER")
                {
                    Console.WriteLine(quantity * 0.70);
                }
                else if (product == "BEER")
                {
                    Console.WriteLine(quantity * 1.10);
                }
                else if (product == "SWEETS")
                {
                    Console.WriteLine(quantity * 1.35);
                }
                else if (product == "PEANUTS")
                {
                    Console.WriteLine(quantity * 1.55);
                }
            }
        }
    }
}
