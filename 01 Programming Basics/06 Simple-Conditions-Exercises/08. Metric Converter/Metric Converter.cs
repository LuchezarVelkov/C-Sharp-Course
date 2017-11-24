using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var from = Console.ReadLine().ToUpper();
            var to = Console.ReadLine().ToUpper();

            var a = 0.0;
            var b = 0.0;

            switch (from)
            {
                case "M":
                    num = num / 1.0;
                    break;

                case "MM":
                    num = num / 1000.0;
                    break;

                case "CM":
                    num = num / 100.0;
                    break;

                case "MI":
                    num = num / 0.000621371192;
                    break;
                case "IN":
                    num = num / 39.3700787;
                    break;

                case "KM":
                    num = num / 0.001;
                    break;

                case "FT":
                    num = num / 3.2808399;
                    break;

                case "YD":
                    num = num / 1.0936133;
                    break;
            }
            switch (to)
            {
                case "M":
                    num = num * 1.0;
                    break;

                case "MM":
                    num = num * 1000.0;
                    break;

                case "CM":
                    num = num * 100.0;
                    break;

                case "MI":
                    num = num * 0.000621371192;
                    break;
                case "IN":
                    num = num * 39.3700787;
                    break;

                case "KM":
                    num = num * 0.001;
                    break;

                case "FT":
                    num = num * 3.2808399;
                    break;

                case "YD":
                    num = num * 1.0936133;
                    break;
            }
            Console.WriteLine(num);
        }
    }
}
