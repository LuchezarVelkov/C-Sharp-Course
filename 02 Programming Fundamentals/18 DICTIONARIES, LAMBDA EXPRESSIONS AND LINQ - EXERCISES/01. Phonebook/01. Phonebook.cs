﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

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
                    //phoneBook.Add(key, value);
                    phoneBook[key] = value;
                }
                else // (phoneParameters[0] == "S")
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

                command = Console.ReadLine();
            }
        }
    }
}
