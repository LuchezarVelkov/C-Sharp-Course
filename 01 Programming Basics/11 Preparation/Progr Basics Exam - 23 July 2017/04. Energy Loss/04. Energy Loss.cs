using System;

namespace _04.Energy_Loss
{
    class Program
    {
        static void Main(string[] args)
        {
            var countOfDays = int.Parse(Console.ReadLine());
            var countOfDancers = int.Parse(Console.ReadLine());
            var totalEnergyUsed = 0.0;

            for (int i = 1; i <= countOfDays; i++)
            {
                var countOfHours = int.Parse(Console.ReadLine());
                var usedEnergy = 0;
                if (i % 2 == 0 && countOfHours % 2 == 0)
                {
                    usedEnergy = 68;
                }
                else if (i % 2 == 1 && countOfHours % 2 == 0)
                {
                    usedEnergy = 49;
                }
                else if (i % 2 == 0 && countOfHours % 2 == 1)
                {
                    usedEnergy = 65;
                }
                else if (i % 2 == 1 && countOfHours % 2 == 1)
                {
                    usedEnergy = 30;
                }
                totalEnergyUsed += countOfDancers * usedEnergy;
            }
            var totalEnergy = 100 * countOfDancers * countOfDays;
            var unusedEnergy = totalEnergy - totalEnergyUsed;
            var unusedEnergyForDancer = unusedEnergy / countOfDancers / countOfDays;
            if (unusedEnergyForDancer > 50)
            {
                Console.WriteLine($"They feel good! Energy left: {unusedEnergyForDancer:F2}");
            }
            else
            {
                Console.WriteLine($"They are wasted! Energy left: {unusedEnergyForDancer:F2}");
            }
        }
    }
}
