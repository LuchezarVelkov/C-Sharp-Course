using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            var yearType = Console.ReadLine().ToLower();
            var holydaysInYear = int.Parse(Console.ReadLine());
            var weakendsToTravel = int.Parse(Console.ReadLine());
            var weakendsToPlay = ((48 - weakendsToTravel) * 0.75) + weakendsToTravel + (holydaysInYear * (2.0 / 3));

            if (yearType == "leap")
            {
                Console.WriteLine(Math.Truncate(weakendsToPlay * 1.15));
            }
            else if (yearType == "normal")
            {
                Console.WriteLine(Math.Truncate(weakendsToPlay));
            }
        }
    }
}
