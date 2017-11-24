using System;

namespace _04.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            var foodName = Console.ReadLine();
            var volume = double.Parse(Console.ReadLine());
            var energyContent = double.Parse(Console.ReadLine()); // in 100 ml
            var sugarContent = double.Parse(Console.ReadLine());

            double sumEnergy = (volume / 100) * energyContent;
            double sumSugar = (volume / 100) * sugarContent;

            Console.WriteLine($"{volume}ml {foodName}:");
            Console.WriteLine($"{sumEnergy}kcal, {sumSugar}g sugars");
        }
    }
}
