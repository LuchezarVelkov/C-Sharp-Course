using System;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char readChar = char.Parse(Console.ReadLine());

            if (readChar >= 48 && readChar <= 57)
            {
                Console.WriteLine("digit");
            }
            else if (readChar == 97 || readChar == 101 || readChar == 105 ||
                readChar == 111 || readChar == 117 || readChar == 121)
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
