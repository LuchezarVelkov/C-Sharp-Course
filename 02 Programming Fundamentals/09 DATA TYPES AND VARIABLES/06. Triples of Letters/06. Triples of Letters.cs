using System;

namespace _06.Triples_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int readNumber = int.Parse(Console.ReadLine());

            for (char firstChar = 'a'; firstChar <= 96 + readNumber; firstChar++)
            {
                for (char secondChar = 'a'; secondChar <= 96 + readNumber; secondChar++)
                {
                    for (char thirdChar = 'a'; thirdChar <= 96 + readNumber; thirdChar++)
                    {
                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }
        }
    }
}
