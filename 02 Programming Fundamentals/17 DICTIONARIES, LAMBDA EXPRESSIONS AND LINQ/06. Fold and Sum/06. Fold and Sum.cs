using System;
using System.Linq;

namespace _06.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var readNumbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int k = readNumbers.Length / 4;

            var firstRowLeft = readNumbers.Take(k).Reverse().ToArray();
            var firstRowRight = readNumbers.Skip(k*3).Take(k).Reverse().ToArray();
            var firstRow = firstRowLeft.Concat(firstRowRight).ToArray();
            var secondRow = readNumbers.Skip(k).Take(2 * k).ToArray();

            var sum = firstRow.Select((x, index) => x + secondRow[index]);
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
