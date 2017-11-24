using System;

namespace _06.Interval_of_N
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            if (secondNum < firstNum)
            {
                var numToChange = firstNum;
                firstNum = secondNum;
                secondNum = numToChange;
            }
            for (int i = firstNum; i <= secondNum; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
