using System;

namespace _06.Group_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine()); // A-Z
            char char2 = char.Parse(Console.ReadLine()); // a-z
            char char3 = char.Parse(Console.ReadLine()); // a-z
            char char4 = char.Parse(Console.ReadLine()); // a-z
            int num5 = int.Parse(Console.ReadLine()); // 0-9
            int combinations = 0;

            for (char symbol1 = 'A'; symbol1 <= char1; symbol1++)
            {
                for (char symbol2 = 'a'; symbol2 <= char2; symbol2++)
                {
                    for (char symbol3 = 'a'; symbol3 <= char3; symbol3++)
                    {
                        for (char symbol4 = 'a'; symbol4 <= char4; symbol4++)
                        {
                            for (int symbol5 = 0; symbol5 <= num5; symbol5++)
                            {
                                combinations++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(combinations -1);
        }
    }
}
