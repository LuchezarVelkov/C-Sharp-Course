using System;
using System.Linq;

namespace _08.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int winerNum = 0;
            int winerNumCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int firstNum = numbers[i];
                int count = 1;
                for (int i2 = i+1; i2 < numbers.Length; i2++)
                {
                    int secondNum = numbers[i2];
                    if (firstNum == secondNum)
                    {
                        count++;
                    }
                }
                if (count > winerNumCount)
                {
                    winerNumCount = count;
                    winerNum = numbers[i];
                }
            }
            Console.WriteLine(winerNum);
        }
    }
}
