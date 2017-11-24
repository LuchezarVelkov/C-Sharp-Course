using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Time__15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var min = int.Parse(Console.ReadLine());
            min = min + 15;
            if (min >= 60)
            {
                min = min - 60;
                hour = hour + 1;
            }
            if (hour >= 24)
            {
                hour = 0;
            }
            if (min < 10)
            {
                Console.WriteLine(hour + ":0" + min);
            }
            else
                Console.WriteLine(hour + ":" + min);
        }
    }
}
