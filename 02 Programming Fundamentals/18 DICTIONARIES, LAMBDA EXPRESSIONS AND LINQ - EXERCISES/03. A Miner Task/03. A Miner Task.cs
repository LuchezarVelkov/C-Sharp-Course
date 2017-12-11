using System;
using System.Collections.Generic;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> results = new Dictionary<string, long>();
            
            for (int i = 1; ; i+=2)
            {
                string resource = Console.ReadLine();
                long quantity = 0;

                if (resource == "stop")
                {
                    break;
                }
                else if(i % 2 == 1)
                {
                    quantity = long.Parse(Console.ReadLine());
                    if (resource == "stop")
                    {
                        break;
                    }
                }

                if (results.ContainsKey(resource))
                {
                    results[resource] += quantity;
                }
                else
                {
                    results.Add(resource, quantity);
                }
            }
            foreach (var item in results)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
