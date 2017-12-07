using System;
using System.Linq;

namespace _07.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)

        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var arguments = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            while (numbers.Contains(arguments[0]))
            {
                int bomb = numbers.IndexOf(arguments[0]);

                for (int i = 0; i < arguments[1]; i++)
                {
                    if (bomb -1 >= 0)
                    {
                        numbers.RemoveAt(bomb - 1);
                        bomb--;
                    }
                }

                for (int i2 = 0; i2 < arguments[1]; i2++)
                {
                    if (bomb + 1 <= numbers.Count -1)
                    {
                        numbers.RemoveAt(bomb + 1);
                    }
                }
                numbers.RemoveAt(bomb);
            }

            int sum = 0;
            for (int i3 = 0; i3 < numbers.Count; i3++)
            {
                sum += numbers[i3];
            }

            Console.WriteLine($"{sum}");

        }
    }
}
