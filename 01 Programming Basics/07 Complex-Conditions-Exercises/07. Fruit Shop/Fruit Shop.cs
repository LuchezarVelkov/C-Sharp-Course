using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine().ToUpper();
            var day = Console.ReadLine().ToUpper();
            var quantity = double.Parse(Console.ReadLine());
            var price = -1.0;
            if ((day == "MONDAY") || (day == "TUESDAY") || (day == "WEDNESDAY") || (day == "THURSDAY") || (day == "FRIDAY"))
            {
                if (fruit == "BANANA")
                {
                    price = 2.50;
                }
                else if (fruit == "APPLE")
                {
                    price = 1.20;
                }
                else if (fruit == "ORANGE")
                {
                    price = 0.85;
                }
                else if (fruit == "GRAPEFRUIT")
                {
                    price = 1.45;
                }
                else if (fruit == "KIWI")
                {
                    price = 2.70;
                }
                else if (fruit == "PINEAPPLE")
                {
                    price = 5.5;
                }
                else if (fruit == "GRAPES")
                {
                    price = 3.85;
                }
            }
            else if ((day == "SATURDAY") || (day == "SUNDAY"))
            {
                if (fruit == "BANANA")
                {
                    price = 2.70;
                }
                else if (fruit == "APPLE")
                {
                    price = 1.25;
                }
                else if (fruit == "ORANGE")
                {
                    price = 0.90;
                }
                else if (fruit == "GRAPEFRUIT")
                {
                    price = 1.60;
                }
                else if (fruit == "KIWI")
                {
                    price = 3.00;
                }
                else if (fruit == "PINEAPPLE")
                {
                    price = 5.60;
                }
                else if (fruit == "GRAPES")
                {
                    price = 4.20;
                }
            }
            if (price >= 0)
            {
                Console.WriteLine("{0:f2}", price * quantity);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
