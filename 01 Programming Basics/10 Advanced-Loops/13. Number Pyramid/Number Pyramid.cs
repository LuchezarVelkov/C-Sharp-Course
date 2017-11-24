using System;

namespace _13.Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var readNumber = int.Parse(Console.ReadLine());
            int num = 1;
            for (int row = 0; row < readNumber; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    Console.Write($"{num} ");
                    if (num == readNumber)
                    {
                        return;
                    }
                    num++;
                }
                Console.WriteLine();
            }
        }
    }
}
