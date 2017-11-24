using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Numbers_with_Step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            var readNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("The numbers is:");
            for (int i = 1; i <= readNumber; i += 3)
            {
                Console.WriteLine(i);
            }

        }
    }
}
