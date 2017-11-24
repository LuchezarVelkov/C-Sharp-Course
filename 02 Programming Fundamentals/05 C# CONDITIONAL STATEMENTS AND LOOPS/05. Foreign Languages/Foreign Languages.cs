using System;

namespace _05.Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string langRead = Console.ReadLine().ToUpper();
            switch (langRead)
            {
                case "USA":
                case "ENGLAND":
                    Console.WriteLine("English");
                    break;
                case "SPAIN":
                case "MEXICO":
                case "ARGENTINA":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
