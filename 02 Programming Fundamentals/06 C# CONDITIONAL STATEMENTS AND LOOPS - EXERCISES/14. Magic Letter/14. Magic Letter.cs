using System;

namespace _14.Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char readA = char.Parse(Console.ReadLine());
            char readB = char.Parse(Console.ReadLine());
            char ignore = char.Parse(Console.ReadLine());

            for (char char1 = readA; char1 <= readB; char1++)
            {
                for (char char2 = readA; char2 <= readB; char2++)
                {
                    for (char char3 = readA; char3 <= readB; char3++)
                    {
                        if (char1 != ignore && char2 != ignore && char3 != ignore)
                        {
                            string result = $"{char1}{char2}{char3} ";
                            Console.Write(result);
                        }
                    }
                }
            }
        }
    }
}
