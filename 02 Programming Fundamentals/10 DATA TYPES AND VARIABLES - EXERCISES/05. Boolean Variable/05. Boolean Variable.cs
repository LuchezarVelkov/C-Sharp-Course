using System;

namespace _05.Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string read = Console.ReadLine();
            bool type = Convert.ToBoolean(read);
            Console.WriteLine(type ? "Yes" : "No");
        }
    }
}
