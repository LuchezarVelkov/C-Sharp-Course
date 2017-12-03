using System;
using System.Linq;

namespace _06.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine() // 1 1 2 3 4 4
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int winnerNum = 0;
            int timeUsed = 0;
            for (int i = 0; i < num.Length; i++)
            {
                int number = num[i];
                int used = 1;
                for (int i2 = i + 1; i2 < num.Length; i2++)
                {
                    if (num[i2] == num[i])
                    {
                        used++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (timeUsed < used)
                {
                    winnerNum = number;
                    timeUsed = used;
                }
            }

            for (int i = 0; i < timeUsed; i++)
            {
                Console.Write(winnerNum + " ");
            }
            Console.WriteLine();
        }
    }
}
