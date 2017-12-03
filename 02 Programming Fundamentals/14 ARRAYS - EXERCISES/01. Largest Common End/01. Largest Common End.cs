using System;
using System.Linq;


namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringArrayOne = Console.ReadLine().Split(' ').ToArray();
            var stringArrayTwo = Console.ReadLine().Split(' ').ToArray();
            int counterOne = 0;
            int counterTwo = 0;

            for (int i = 0; i < Math.Min(stringArrayOne.Length, stringArrayTwo.Length); i++)
            {
                if (stringArrayOne[i] == stringArrayTwo[i])
                {
                    counterOne++;
                }
                if (stringArrayOne[stringArrayOne.Length -1 -i] == stringArrayTwo[stringArrayTwo.Length - 1 -i])
                {
                    counterTwo++;
                }
            }
            Console.WriteLine(Math.Max(counterOne,counterTwo));
        }
    }
}
