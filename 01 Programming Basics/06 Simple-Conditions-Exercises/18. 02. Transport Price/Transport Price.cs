using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._02.Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var time = Console.ReadLine().ToUpper();
            var price = 0.0;
            if (n <20)
            {
                //Taxi
                if (time == "DAY")
                {
                    price = 0.70 + (n * 0.79);
                }

                else if (time == "NIGHT")
                {
                    price = 0.70 + (n * 0.90);
                }
                Console.WriteLine(price.ToString("0.00"));
            }

            else if ((n >= 20) && (n <100))
            {
                //BUS
                if ((time == "DAY") || (time == "NIGHT"))
                {
                    price = n * 0.09;
                }
                Console.WriteLine(price.ToString("0.00"));
            }

            else if (n >= 100)
            {
                //TRAIN
                if ((time == "DAY") || (time == "NIGHT"))
                {
                    price = n * 0.06;
                }
                Console.WriteLine(price.ToString("0.00"));
            }
        }
    }
}
