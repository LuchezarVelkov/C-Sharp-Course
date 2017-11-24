using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Numbers_N_to_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var readNumber = int.Parse(Console.ReadLine());
            for (int i = readNumber; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
