using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            var readNumber = int.Parse(Console.ReadLine());

            int fact = 1;

            do
            {
                fact = fact * readNumber;
                readNumber--;
            } while (readNumber >= 1);
            Console.WriteLine(fact);
        }
    }
}
