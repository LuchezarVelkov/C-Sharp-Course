using System;

namespace _15.Neighbou_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());
            int peshoHealth = 100;
            int goshoHealth = 100;
            int round = 1;

            while (true)
            {
                if (round % 2 == 1)
                {
                    goshoHealth -= peshoDamage;
                    if (goshoHealth > 0)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    peshoHealth -= goshoDamage;
                    if (peshoHealth > 0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                    }
                    else
                    {
                        break;
                    }
                }
                if (round % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;

                }
                round++;
            }
            var winer = goshoHealth > peshoHealth ? "Gosho" : "Pesho";
            Console.WriteLine($"{winer} won in {round}th round.");
        }
    }
}
