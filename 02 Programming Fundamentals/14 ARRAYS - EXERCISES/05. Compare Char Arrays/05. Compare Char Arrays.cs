using System;
using System.Linq;

namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstRow = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondRow = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            for (int i = 0; i < Math.Min(firstRow.Length, secondRow.Length); i++)
            {
                if (firstRow[i] < secondRow[i])
                {
                    Console.WriteLine($"{string.Join("",firstRow)}");
                    Console.WriteLine($"{string.Join("", secondRow)}");
                    return;
                }
                else if (firstRow[i] > secondRow[i])
                {
                    Console.WriteLine($"{string.Join("", secondRow)}");
                    Console.WriteLine($"{string.Join("", firstRow)}");
                    return;
                }
            }

            if (firstRow.Length <= secondRow.Length)
            {
                Console.WriteLine($"{string.Join("", firstRow)}");
                Console.WriteLine($"{string.Join("", secondRow)}");
            }
            else
            {
                Console.WriteLine($"{string.Join("", secondRow)}");
                Console.WriteLine($"{string.Join("", firstRow)}");
            }
        }
    }
}
