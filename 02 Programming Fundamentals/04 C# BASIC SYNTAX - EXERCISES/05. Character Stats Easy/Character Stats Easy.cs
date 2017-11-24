using System;

namespace _05.Character_Stats_Easy
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

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |" + new string('|',health) + new string ('.',maxHealth - health) + '|');
            Console.WriteLine($"Energy: |" + new string('|',energy) + new string ('.',maxEnergy - energy) + '|');
        }
    }
}
