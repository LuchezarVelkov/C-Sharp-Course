using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Triangle_of_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            for (int row = 1; row <= count; row++)
            {
                Console.Write('$');
                for (int colum = 1; colum < row; colum++)
                {
                    Console.Write(" $");
                }
                Console.WriteLine();
            }
        }
    }
}
