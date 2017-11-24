using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._02_Harvest
{
    class Harvest
    {
        static void Main(string[] args)
        {
            var squareVineyard = int.Parse(Console.ReadLine());
            var vineyeardInSquare = double.Parse(Console.ReadLine());
            var needVineyardLiter = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var allVineyard = squareVineyard * vineyeardInSquare;
            var vine = ((allVineyard/100) * 40) / 2.5;
            var vineLeft = vine - needVineyardLiter;

            if (needVineyardLiter <= vine)
            {
                Console.WriteLine("Good harvest this year! Total wine: " + vine + " liters.");
                Console.WriteLine(Math.Ceiling(vineLeft) + " liters left -> " + Math.Ceiling(vineLeft / workers) + " liters per person.");
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More " + Math.Truncate(needVineyardLiter - vine) +" liters wine needed.");
            }
            
        }
    }
}
