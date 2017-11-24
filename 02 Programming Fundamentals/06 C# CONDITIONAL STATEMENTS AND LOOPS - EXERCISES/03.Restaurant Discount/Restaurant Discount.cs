using System;

namespace _03.Restaurant_Dis
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string place = null;
            double price = 0;
            double discount = 0;

            if (groupSize <= 50)
            {
                place = "Small Hall";
                price = 2500;
            }
            else if (groupSize <= 100)
            {
                place = "Terrace";
                price = 5000;
            }
            else if (groupSize <= 120)
            {
                place = "Great Hall";
                price = 7500;
            }
            else if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            if (groupSize < 120)
            {
                if (package == "Normal")
                {
                    price += 500;
                    discount = 0.5;
                }
                else if (package == "Gold")
                {
                    price += 750;
                    discount = 0.10;
                }
                else if (package == "Platinum")
                {
                    price += 1000;
                    discount = 0.15;
                }
                double priceForPerson = (price - (price * discount)) / groupSize;
                Console.WriteLine($"We can offer you the {place}");
                Console.WriteLine($"The price per person is {priceForPerson:F}$");
            }
        }
    }
}
