using System;
using System.Collections.Generic;

namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string readString = Console.ReadLine();
            string[] words = readString.ToLower().Split(' ');

            var count = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (count.ContainsKey(word))
                {
                    count[word]++;
                }
                else
                {
                    count[word] = 1;
                }
            }

            List<string> uniceWords = new List<string>();
            foreach (var item in count)
            {
                if (item.Value % 2 == 1)
                {
                    uniceWords.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ",uniceWords));

        }
    }
}
