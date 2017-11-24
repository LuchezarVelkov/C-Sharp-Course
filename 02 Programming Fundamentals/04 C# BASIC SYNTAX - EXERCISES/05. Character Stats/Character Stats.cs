using System;


namespace _05.Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var health = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var energy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());

            string healthDiagram = "|";
            string energyDiagram = "|";

            for (int healthCount = 1; healthCount <= maxHealth ; healthCount++)
            {
                if (healthCount <= health)
                {
                    healthDiagram += "|";
                }
                else
                {
                    healthDiagram += ".";
                }
            }

            for (int energyCount = 1; energyCount <= maxEnergy; energyCount++)
            {
                if (energyCount <= energy)
                {
                    energyDiagram += "|";
                }
                else
                {
                    energyDiagram += ".";
                }
            }

            healthDiagram += "|";
            energyDiagram += "|";

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: {healthDiagram}"); //   ||||||.....|
            Console.WriteLine($"Energy: {energyDiagram}");
        }
    }
}
