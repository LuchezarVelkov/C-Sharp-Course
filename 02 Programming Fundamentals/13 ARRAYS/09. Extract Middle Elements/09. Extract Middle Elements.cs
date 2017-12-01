using System;
using System.Linq;

namespace _09.Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine($"{ExtractMiddle(numbers)}");
        }

        static string ExtractMiddle(int[] num)
        {
            int[] array = num;
            string result = null;

            if (array.Length == 1)
            {
                result = "{ " + array[0].ToString() + " }";
            }
            else if (array.Length % 2 == 0)
            {
                Console.WriteLine("{ " + (array[array.Length / 2 -1]) + ", " + (array[array.Length / 2]) + " }");
            }
            else if (array.Length % 2 == 1)
            {
                Console.WriteLine("{ " + (array[array.Length / 2 - 1]) + ", " + (array[array.Length / 2]) + ", " + (array[array.Length / 2 + 1]) +" }");
            }

            return result;
        }
    }
}
