using System;

namespace _08_Sunglasses
{
    class Sunglasses
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var firstAndLastRow = new string('*', size * 2) + new string(' ', size) + new string('*', size * 2);
            var middleRow = string.Empty;
            Console.WriteLine(firstAndLastRow);
            for (int row = 1; row <= size -2; row++)
            {
                middleRow = '*' + new string('/', (size * 2) - 2) + '*';
                if (row - 1 == (size - 1) / 2 - 1)
                {
                    middleRow = middleRow + new string('|',size);
                }
                else
                {
                    middleRow = middleRow + new string(' ', size);
                }
                middleRow = middleRow + '*' + new string('/', (size * 2) - 2) + '*';
                Console.WriteLine(middleRow);
            }
            Console.WriteLine(firstAndLastRow);
        }
    }
}
