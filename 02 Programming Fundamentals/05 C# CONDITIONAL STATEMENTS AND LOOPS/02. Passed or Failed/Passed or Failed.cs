using System;

namespace _02.Passed_or_Failed
{
    class Program
    {
        static void Main(string[] args)
        {
            var readNumber = double.Parse(Console.ReadLine());
            Console.WriteLine(readNumber >= 3 ? "Passed!" : "Failed!");
        }
    }
}
