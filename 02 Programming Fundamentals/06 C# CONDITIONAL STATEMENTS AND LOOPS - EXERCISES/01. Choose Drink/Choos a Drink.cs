using System;

namespace _01.Choose_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string proffesion = Console.ReadLine();

            switch (proffesion)
            {
                case "Athlete":
                    Console.WriteLine("Water");
                    break;
                case "Businessman":
                case "Businesswoman":
                    Console.WriteLine("Coffee");
                    break;
                case "SoftUni Student":
                    Console.WriteLine("Beer");
                    break;
                default:
                    Console.WriteLine("Tea");
                    break;
            }
        }
    }
}
