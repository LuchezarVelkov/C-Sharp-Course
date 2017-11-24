using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._02_Sleeping_Tom
{
    class Program
    {
        static void Main(string[] args)
        {
            var holydays = int.Parse(Console.ReadLine());
            var workDays = 365 - holydays;
            var timeToPlay = (workDays * 63) + (holydays * 127);
            var normPlay = 30000 - timeToPlay;

            if (normPlay >= 0)
            {
                var timeToPlayRead = TimeSpan.FromMinutes(normPlay);
                var hours = (int)timeToPlayRead.TotalHours;
                var minutes = timeToPlayRead.Minutes;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine(hours + " hours and " + minutes + " minutes less for play");
            }

            else if ( normPlay < 0)
            {
                normPlay = normPlay * -1;
                var timeToPlayRead = TimeSpan.FromMinutes(normPlay);
                var hours = (int)timeToPlayRead.TotalHours;
                var minutes = timeToPlayRead.Minutes;
                Console.WriteLine("Tom will run away");
                Console.WriteLine(hours + " hours and " + minutes + " minutes more for play");
            }
        }
    }
}
