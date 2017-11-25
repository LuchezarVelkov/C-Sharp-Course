using System;

namespace _06.Strings_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();
            object obj = firstWord + " " + secondWord;
            Console.WriteLine((string)obj);
        }
    }
}
