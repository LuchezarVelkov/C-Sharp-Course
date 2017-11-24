using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var readNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i <= readNumber; i+=2)
            {
                var result = (int)Math.Pow(2, i);
                Console.WriteLine(result);
            }
        }
    }
}
