using System;

namespace _06_Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var spaces = size - 1;
            for (int row = 1; row <= size; row++)
            {
                for (int emptySpaces = 1; emptySpaces <= spaces; emptySpaces++)
                {
                    Console.Write(' ');
                }
                Console.Write('*');
                for (int stars = 1; stars < row; stars++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
                spaces--;
            }
            spaces = 1;
            size = size - 1;
            var countOfStars = size;
            for (int row = 1; row <= size; row++)
            {
                for (int witeSpaces = 1; witeSpaces <= spaces; witeSpaces++)
                {
                    Console.Write(' ');
                }
                Console.Write("*");
                for (int stars = 1; stars <= countOfStars -1; stars++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
                spaces++;
                countOfStars--;
            }
        }
    }
}
