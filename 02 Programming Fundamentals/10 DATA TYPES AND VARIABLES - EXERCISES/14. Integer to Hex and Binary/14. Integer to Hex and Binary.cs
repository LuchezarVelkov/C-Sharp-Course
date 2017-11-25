using System;

namespace _14.Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int readNumber = int.Parse(Console.ReadLine());
            string hexadecimal = Convert.ToString(readNumber, 16).ToUpper(); // hexadecimal
            string binary = Convert.ToString(readNumber, 2).ToUpper();       // binary

            Console.WriteLine(hexadecimal);
            Console.WriteLine(binary);
        }
    }
}
