using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, int>();
            var junk = new Dictionary<string, int>();
            result.Add("shards", 0);    // Shadowmourne
            result.Add("fragments", 0); // Valanyr
            result.Add("motes", 0);     // Dragonwrath
            string found = null;
            bool run = true;

            while (run)  //   50 shards 50 fragments 50 motes   ERROR
            {
                var readRow = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.ToLower())
                    .ToArray();

                int value = 0;

                for (int i = 0; i < readRow.Length; i++)
                {
                    string data = readRow[i];
                    if (i % 2 == 0)
                    {
                        value = int.Parse(data);
                    }
                    else if (data == "shards" || data == "fragments" || data == "motes")
                    {
                        if (result.ContainsKey(readRow[i]))
                        {
                            result[readRow[i]] += value;
                            value = 0;
                        }
                        else
                        {
                            result.Add(readRow[i], value);
                            value = 0;
                        }
                    }
                    else
                    {
                        if (junk.ContainsKey(readRow[i]))
                        {
                            junk[readRow[i]] += value;
                            value = 0;
                        }
                        else
                        {
                            junk.Add(readRow[i], value);
                            value = 0;
                        }
                    }
                    if (result["shards"] >= 250 || result["fragments"] >= 250 || result["motes"] >= 250)
                    {
                        int usedScore = 250;
                        if (result["shards"] >= 250)
                        {
                            result["shards"] -= usedScore;
                            found = "Shadowmourne";
                        }
                        else if (result["fragments"] >= 250)
                        {
                            result["fragments"] -= usedScore;
                            found = "Valanyr";
                        }
                        else // if (result["motes"] >= 250)
                        {
                            result["motes"] -= usedScore;
                            found = "Dragonwrath";
                        }
                        run = false;
                        if (!run)
                        {
                            break;
                        }
                    }
                }
            }

            Console.WriteLine($"{found} obtained!");
            foreach (var i in result.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{i.Key}: {i.Value}");
            }
            foreach (var i in junk.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{i.Key}: {i.Value}");
            }
        }
    }
}
