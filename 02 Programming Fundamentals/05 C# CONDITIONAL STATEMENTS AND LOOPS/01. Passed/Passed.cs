using System;


namespace _01.Passed
{
    class Passed
    {
        static void Main(string[] args)
        {
            var readNumber = double.Parse(Console.ReadLine());

            Console.WriteLine(readNumber >= 3 ? "Passed!" : "");
        }
    }
}
