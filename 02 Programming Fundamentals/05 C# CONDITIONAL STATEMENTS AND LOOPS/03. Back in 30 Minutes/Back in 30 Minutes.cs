using System;

namespace _03.Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes = minutes + 30;
            if (minutes > 59)
            {
                hour++;
                if (hour > 23)
                {
                    hour = hour - 24;
                }
                minutes = minutes - 60;
            }

            Console.WriteLine($"{hour}:{minutes:D2}");
        }
    }
}
