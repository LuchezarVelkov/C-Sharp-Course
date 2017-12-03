using System;
using System.Linq;

namespace _10.Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int diference = int.Parse(Console.ReadLine());

            int maxDif = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int i2 = i+1; i2 < numbers.Length; i2++)
                {
                    int chek = numbers[i] - numbers[i2];
                    if (Math.Abs(chek) == diference)
                    {
                        maxDif++;
                    }
                }
            }
            Console.WriteLine(maxDif);
        }
    }
}
