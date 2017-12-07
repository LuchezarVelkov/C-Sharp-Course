using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> readNumbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();
            while (command != "Odd" && command != "Even")
            {
                List<string> commandArguments = command
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

                if (commandArguments[0] == "Delete")
                {
                    while (readNumbers.Remove(int.Parse(commandArguments[1])))
                    {
                        readNumbers.Remove(int.Parse(commandArguments[1]));
                    }
                }

                if (commandArguments[0] == "Insert")
                {
                    readNumbers.Insert(int.Parse(commandArguments[2]),int.Parse(commandArguments[1]));
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < readNumbers.Count; i++)
            {
                if (readNumbers[i] % 2 == 0 && command == "Even")
                {
                    Console.Write(readNumbers[i] + " ");
                }
                else if (readNumbers[i] % 2 == 1 && command == "Odd")
                {
                    Console.Write(readNumbers[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
