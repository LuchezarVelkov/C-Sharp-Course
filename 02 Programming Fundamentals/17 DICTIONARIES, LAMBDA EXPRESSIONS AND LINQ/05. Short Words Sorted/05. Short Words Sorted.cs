using System;
using System.Linq;

namespace _05.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
                .ToLower()
                .Split(new char[] { ' ', '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?' }
                ,StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var wordUnderFiveChar = text
                .Distinct()
                .Where(x => x.Length <5)
                .OrderBy(x => x)
                .ToArray();

            Console.WriteLine(string.Join(", ",wordUnderFiveChar));
        }
    }
}
