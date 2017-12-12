using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stop = false;
            string[] read = Console.ReadLine()
                .Split(new char[] {':'},StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var nameAndScore = new Dictionary<string, string>();

            while (!stop)
            {
                if (read[0] == "JOKER")
                {
                    stop = true;
                    break;
                }

                if (nameAndScore.ContainsKey(read[0]))
                {
                    nameAndScore[read[0]] += "," + read[1];
                }
                else
                {
                    nameAndScore.Add(read[0],read[1]);
                }

                read = Console.ReadLine()
                .Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            foreach (var item in nameAndScore)
            {
                Console.WriteLine($"{item.Key}: {GetScores(item.Value)}");
            }
        }

        static string GetScores(string cards)
        {
            int sum = 0;

            string[] readCards = cards
                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .Distinct()
                .ToArray();

            foreach (var i in readCards)
            {
                string item = i;
                if (item.Length == 3)
                {
                    int power = 10;
                    int typePower = 0;
                    string type = item[2].ToString();
                    if (type == "S")
                    {
                        typePower = 4;
                    }
                    else if (type == "H")
                    {
                        typePower = 3;
                    }
                    else if (type == "D")
                    {
                        typePower = 2;
                    }
                    else if (type == "C")
                    {
                        typePower = 1;
                    }
                    sum += power * typePower;
                }
                else //(item.Length == 2)
                {
                    int power = 0;
                    if (item[0] == 'J')
                    {
                        power = 11;
                    }
                    else if (item[0] == 'Q')
                    {
                        power = 12;
                    }
                    else if (item[0] == 'K')
                    {
                        power = 13;
                    }
                    else if (item[0] == 'A')
                    {
                        power = 14;
                    }
                    else
                    {
                        power = int.Parse(item[0].ToString());
                    }
                    int typePower = 0;
                    string type = item[1].ToString();
                    if (type == "S")
                    {
                        typePower = 4;
                    }
                    else if (type == "H")
                    {
                        typePower = 3;
                    }
                    else if (type == "D")
                    {
                        typePower = 2;
                    }
                    else if (type == "C")
                    {
                        typePower = 1;
                    }
                    sum += power * typePower;
                }
            }
            return sum.ToString();
        }
    }
}
