using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = double.Parse(Console.ReadLine());
            var currency = Console.ReadLine().ToUpper();
            var toCurrency = Console.ReadLine().ToUpper();

            var value1 = 0.0; // Declarate defaulth value if not put 0.0 format is INT not Double
            var value2 = 0.0; // Declarate defaulth value if not put 0.0 format is INT not Double

            //double value1 = 0; // Another way to Declarate value1 to Double format
            //double value2 = 0; // Another way to Declarate value1 to Double format

            switch (currency)
            {
                case "BGN":
                    value1 = 1.0;
                    break;
                case "USD":
                    value1 = 1.79549;
                    break;
                case "EUR":
                    value1 = 1.95583;
                    break;
                case "GBP":
                    value1 = 2.53405;
                    break;
            }

            switch (toCurrency)
            {
                case "BGN":
                    value2 = 1.0;
                    break;
                case "USD":
                    value2 = 1.79549;
                    break;
                case "EUR":
                    value2 = 1.95583;
                    break;
                case "GBP":
                    value2 = 2.53405;
                    break;
            }

            var sum = (value1 / value2) * value;

            Console.WriteLine(Math.Round(sum, 2));
        }
        
    }
}
