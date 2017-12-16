using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int readRows = int.Parse(Console.ReadLine());
            var result = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < readRows; i++)
            {
                var readData = Console.ReadLine()
                    .Split(' ')
                    .ToArray();

                var ip = readData[0];
                var name = readData[1];
                var duration = int.Parse(readData[2]);

                if (result.ContainsKey(name))
                {
                    if (result[name].ContainsKey(ip))
                    {
                        result[name][ip] += duration;
                    }
                    else
                    {
                        result[name].Add(ip, duration);
                    }
                }
                else
                {
                    result.Add(name,new SortedDictionary<string, int> { { ip, duration } });
                }
            }

            foreach (var user in result)
            {
                var totalDurationOfUser = result[user.Key].Values.Sum();
                var listOfIps = user.Value.Keys.ToList();
                Console.WriteLine($"{user.Key}: {totalDurationOfUser} [{string.Join(", ", listOfIps)}]");
            }

        }
    }
}
