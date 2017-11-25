using System;

namespace _04.Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string readNumber = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(readNumber, 16));
        }
    }
}
