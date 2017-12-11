using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phoneBook = new SortedDictionary<string, string>();

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] phoneParameters = command
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (phoneParameters[0] == "A")
                {
                    string key = phoneParameters[1];
                    string value = phoneParameters[2];
                    phoneBook[key] = value;
                }
                else if (phoneParameters[0] == "S")
                {
                    string key = phoneParameters[1];
                    if (phoneBook.ContainsKey(key))
                    {
                        Console.WriteLine($"{key} -> {phoneBook[key]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {key} does not exist.");
                    }
                }
                else if (phoneParameters[0] == "ListAll")
                {
                    foreach (var item in phoneBook)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }
                command = Console.ReadLine();
            }
        }
    }
}
