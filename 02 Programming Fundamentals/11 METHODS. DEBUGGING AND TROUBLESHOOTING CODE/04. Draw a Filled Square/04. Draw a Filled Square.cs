using System;

namespace _04.Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int readNumber = int.Parse(Console.ReadLine());
            PrintHeader(readNumber);
            PrintMiddleRow(readNumber);
            PrintHeader(readNumber);
        }

        private static void PrintMiddleRow(int readNumber)
        {
            for (int row = 1; row <= readNumber -2; row++)
            {
                Console.Write('-');
                for (int col = 1; col < readNumber; col++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }
        }

        private static void PrintHeader(int readNumber)
        {
            Console.WriteLine(new string('-', 2 * readNumber));
        }
    }
}
