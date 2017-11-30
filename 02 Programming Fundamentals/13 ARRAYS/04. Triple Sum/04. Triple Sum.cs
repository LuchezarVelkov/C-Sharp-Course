using System;
using System.Linq;

namespace _04.Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            bool notMatch = true;
            for (int a = 0; a < nums.Length; a++)
            {
                for (int b = a + 1; b < nums.Length; b++)
                {
                    int sum = nums[a] + nums[b];
                    if (nums.Contains(sum))
                    {
                        Console.WriteLine($"{nums[a]} + {nums[b]} == {sum}");
                        notMatch = false;
                    }
                }
            }
            if (notMatch)
            {
                Console.WriteLine($"No");

            }
        }
    }
}
