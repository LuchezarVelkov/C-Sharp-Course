using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] len = new int[numbers.Length];
            int[] prev = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                int index = -1;
                //var prevIndex = index == -1 ? 0 : len[i-1];
                for (int left = 0; left < i; left++)
                {
                    //if (numbers[left] < numbers[i] && numbers[left] <= numbers[prevIndex])
                    if (numbers[left] < numbers[i])
                    {
                        len[i]++;
                        if (index == -1)
                        {
                            index = left;
                        }
                        else if (numbers[left] > numbers[index])
                        {
                            index = left;
                        }
                    }
                }
                len[i]++;
                prev[i] = index;
            }
            Console.WriteLine(string.Join(" ",len));
            Console.WriteLine(string.Join(" ", prev));
        }
    }
}
