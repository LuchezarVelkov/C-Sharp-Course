using System;

namespace _03.Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int readNumber = int.Parse(Console.ReadLine());

            PrintTriangle(readNumber);
        }

        static void PrintTriangle(int readNumber)
        {
            for (int row = 1; row <= readNumber; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
            for (int row = readNumber -1; row > 0; row--)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
