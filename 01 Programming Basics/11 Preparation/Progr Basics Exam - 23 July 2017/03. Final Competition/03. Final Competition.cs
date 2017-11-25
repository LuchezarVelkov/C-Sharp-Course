using System;

namespace _03.Final_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            var countOfDancers = int.Parse(Console.ReadLine());
            var scores = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string place = Console.ReadLine().ToLower();
            double winPrice = 0;
            double taxes = 0;

            if (place == "bulgaria")
            {
                winPrice = scores * countOfDancers;
                if (season == "summer")
                {
                    taxes = winPrice * 0.05;
                }
                else
                {
                    taxes = winPrice * 0.08;
                }
            }
            else
            {
                winPrice = scores * countOfDancers;
                winPrice += winPrice * 0.5;
                if (season == "summer")
                {
                    taxes = winPrice * 0.10;
                }
                else
                {
                    taxes = winPrice * 0.15;
                }
            }
            var donation = (winPrice - taxes) * 0.75;
            var awardForPlayer = (winPrice - taxes - donation) / countOfDancers;
            Console.WriteLine($"Charity - {donation:F2}");
            Console.WriteLine($"Money per dancer - {awardForPlayer:F2}");
        }
    }
}
