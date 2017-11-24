using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = Console.ReadLine().ToUpper();
            if ((i == "BANANA") || (i == "APPLE") || (i == "KIWI") || (i == "CHERRY") || (i == "LEMON") || (i == "GRAPES"))
            {
                Console.WriteLine("fruit");
            }
            else if ((i == "TOMATO") || (i== "CUCUMBER") || (i == "PEPPER") || (i == "CARROT"))
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
