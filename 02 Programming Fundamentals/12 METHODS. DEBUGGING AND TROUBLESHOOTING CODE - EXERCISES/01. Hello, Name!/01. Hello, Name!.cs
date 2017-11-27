using System;

namespace _01.Hello__Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            string readName = Console.ReadLine();
            Console.WriteLine(SayHello(readName));
        }

        static string SayHello(string name)
        {
            string hello = $"Hello, {name}!";
            return hello;
        }
    }
}
