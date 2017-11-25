using System;

namespace _10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int century = int.Parse(Console.ReadLine());

            int years = century * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            decimal minutes = hours * 60;
            decimal seconds = minutes * 60;
            decimal milliseconds = seconds * 1000;
            decimal microseconds = milliseconds * 1000;
            decimal nanoseconds = microseconds * 1000;

            Console.WriteLine($"{century} centuries = " +
                              $"{years} years = " +
                              $"{days} days = " +
                              $"{hours} hours = " +
                              $"{minutes} minutes = " +
                              $"{seconds} seconds = " +
                              $"{milliseconds} milliseconds = " +
                              $"{microseconds} microseconds = " +
                              $"{nanoseconds} nanoseconds");
        }
    }
}
