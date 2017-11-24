using System;

namespace _02.Choose_Drink_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string proffesion = Console.ReadLine();
            int quantities = int.Parse(Console.ReadLine());
            var waterPrice = 0.70 * quantities;
            var coffeePrice = 1.00 * quantities;
            var beerPrice = 1.70 * quantities;
            var teaPrice = 1.20 * quantities;

            switch (proffesion)
            {
                case "Athlete":
                    Console.WriteLine($"The {proffesion} has to pay {waterPrice:F2}.");
                    break;
                case "Businessman":
                case "Businesswoman":
                    Console.WriteLine($"The {proffesion} has to pay {coffeePrice:F2}.");
                    break;
                case "SoftUni Student":
                    Console.WriteLine($"The {proffesion} has to pay {beerPrice:F2}.");
                    break;
                default:
                    Console.WriteLine($"The {proffesion} has to pay {teaPrice:F2}.");
                    break;
            }
        }
    }
}
