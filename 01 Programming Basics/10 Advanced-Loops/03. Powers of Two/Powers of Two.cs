using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Powers_of_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            var readNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i <= readNumber; i++)
            {
                int pow = (int)Math.Pow(2, i); // Math.Pow(number, *vale) 2 на нулева степен е 1 !!!
                Console.WriteLine(pow);
            }
        }
    }
}
