using System;
using System.Linq;

namespace _07.Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayOne = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var arrayTwo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] arraySum = new int[Math.Max(arrayOne.Length, arrayTwo.Length)];

            for (int i = 0; i < arraySum.Length; i++)
            {
                arraySum[i] = arrayOne[i % arrayOne.Length] + arrayTwo[i % arrayTwo.Length];
            }

            foreach (int sum in arraySum)
            {
                Console.Write($"{sum} ");
            }
        }
    }
}
