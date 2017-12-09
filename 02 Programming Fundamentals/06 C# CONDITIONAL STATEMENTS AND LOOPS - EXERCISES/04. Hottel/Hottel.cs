using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());
            var priceS = 0.0;
            var priceD = 0.0;
            var priceSuite = 0.0;

            switch (month)
            {
                case "May":
                case "October":

                    priceS = 50;
                    if (nights > 7)
                    {
                        priceS *= 0.95;
                    }
                    priceD = 65;

                    priceSuite = 75;
                    break;
                case "June":
                case "September":
                    priceS = 60;
                    priceD = 72;

                    if (nights > 14)
                    {
                        priceD *= 0.90;
                    }

                    priceSuite = 82;

                    break;
                case "July":
                case "August":
                case "December":
                    priceS = 68;

                    priceD = 77;

                    priceSuite = 89;

                    if (nights > 14)
                    {
                        priceSuite *= 0.85;
                    }

                    break;
            }
            var totalStudioPrice = priceS * nights;
            var totalDoublePrice = priceD * nights;
            var totalSuitePrice = priceSuite * nights;

            if ((month == "September" && nights > 7) ||
                    (month == "October" && nights > 7))
            {
                totalStudioPrice -= priceS;
            }
            Console.WriteLine("Studio: {0:F2} lv.", totalStudioPrice);
            Console.WriteLine("Double: {0:F2} lv.", totalDoublePrice);
            Console.WriteLine("Suite: {0:F2} lv.", totalSuitePrice);
        }
    }
}