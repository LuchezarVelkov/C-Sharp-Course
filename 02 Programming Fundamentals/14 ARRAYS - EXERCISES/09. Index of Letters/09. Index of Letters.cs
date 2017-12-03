using System;
using System.Linq;

namespace _09.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charRead = Console.ReadLine()
                .ToLower()
                .ToCharArray()
                .ToArray();

            foreach (var i in charRead)
            {
                Console.WriteLine($"{i.ToString()} -> {i - 97}");

            }
        }
    }
}
