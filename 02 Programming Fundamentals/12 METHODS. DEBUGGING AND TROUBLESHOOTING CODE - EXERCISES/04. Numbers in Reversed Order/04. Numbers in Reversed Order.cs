using System;

namespace _04.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string readDouble = Console.ReadLine();
            Console.WriteLine(ReverseNumber(readDouble));
        }

        static string ReverseNumber(string readDouble)
        {
            string newValue = null;
            while (readDouble.Length > 0)
            {
                char lastChar = readDouble[readDouble.Length - 1];
                newValue += lastChar;
                readDouble = readDouble.Remove(readDouble.Length - 1);
            }
            return newValue;
        }
    }
}
