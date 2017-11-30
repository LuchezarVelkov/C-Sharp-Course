using System;

namespace _01.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dayOfWeak = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int readNumber = int.Parse(Console.ReadLine());
            if (readNumber > 0 && readNumber <= dayOfWeak.Length)
            {
                Console.WriteLine($"{dayOfWeak[readNumber - 1]}");
            }
            else
            {
                Console.WriteLine($"Invalid Day!");

            }

        }
    }
}
