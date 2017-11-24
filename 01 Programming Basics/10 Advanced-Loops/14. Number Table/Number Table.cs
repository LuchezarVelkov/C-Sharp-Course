using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var readNumber = int.Parse(Console.ReadLine());

            for (int row = 1; row <= readNumber; row++)
            {
                for (int col = row; col <= readNumber; col++)
                {
                    Console.Write($"{col} ");
                }
                for (int col = readNumber - 1; col > readNumber - row; col--)
                {
                    Console.Write($"{col} ");
                }

                Console.WriteLine();
            }
        }
    }
}
