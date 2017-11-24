using System;

namespace _04.Hottel
{
    class Hottel
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            var studioPrice = 0;
            var doublePrice = 0;
            var suitePrice = 0;
            var studioDiscount = 0.0;
            var doubleDiscount = 0.0;
            var suiteDiscount = 0.0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                doublePrice = 65;
                suitePrice = 75;
                if (nights > 7)
                {
                    studioDiscount = 0.05;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 60;
                doublePrice = 72;
                suitePrice = 82;
                if (nights > 14)
                {
                    doubleDiscount = 0.10;
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studioPrice = 68;
                doublePrice = 77;
                suitePrice = 89;
                if (nights > 14)
                {
                    suiteDiscount = 0.15;
                }
            }
            
            var priceForStudio = (studioPrice * nights) - ((studioPrice * nights) * studioDiscount);
            var priceForDouble = (doublePrice * nights) - ((doublePrice * nights) * doubleDiscount);
            var priceForSuite = (suitePrice * nights) - ((suitePrice * nights) * suiteDiscount);

            if (month == "September" || month == "October")
            {
                if (nights > 7)
                {
                    priceForStudio -= 60;
                }
            }
            Console.WriteLine($"Studio: {priceForStudio:F} lv.");
            Console.WriteLine($"Double: {priceForDouble:F} lv.");
            Console.WriteLine($"Suite: {priceForSuite:F} lv.");
        }
    }
}