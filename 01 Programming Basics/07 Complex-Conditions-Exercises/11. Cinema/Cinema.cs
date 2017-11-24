using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            var projection = Console.ReadLine().ToLower();
            var row = int.Parse(Console.ReadLine());
            var colum = int.Parse(Console.ReadLine());
            var price = 0.00;
            if (projection == "premiere")
            {
                price = 12.00;
            }
            else if (projection == "normal")
            {
                price = 7.50;
            }
            else if (projection == "discount")
            {
                price = 5.00;
            }
            Console.Write("{0:f2}", row * colum * price);
            Console.WriteLine(" leva");
        }
    }
}
