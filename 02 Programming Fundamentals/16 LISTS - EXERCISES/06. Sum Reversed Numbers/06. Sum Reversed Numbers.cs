using System;
using System.Linq;

namespace _06.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] readNumbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int sum = 0;
            for (int i = 0; i < readNumbers.Length; i++)
            {
                char[] numberInChar = readNumbers[i].ToArray();
                numberInChar.Reverse();
                string num = null;
                for (int i2 = numberInChar.Length - 1; i2 >= 0; i2--)
                {
                    num += numberInChar[i2].ToString();
                }
                sum += int.Parse(num);
            }
            Console.WriteLine(sum);
        }
    }
}
