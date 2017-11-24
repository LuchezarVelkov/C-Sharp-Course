using System;

namespace _06.Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string readDay = Console.ReadLine();
            int readAge = int.Parse(Console.ReadLine());

            if (readDay == "Weekday")
            {
                if ((readAge >= 0 && readAge <= 18) || (readAge > 64  && readAge <= 122))
                {
                    Console.WriteLine("12$");
                }
                else if (readAge > 18 && readAge <= 64)
                {
                    Console.WriteLine("18$");
                }
            }
            else if (readDay == "Weekend")
            {
                if ((readAge >= 0 && readAge <= 18) || (readAge > 64 && readAge <= 122))
                {
                    Console.WriteLine("15$");
                }
                else if (readAge > 18 && readAge <= 64)
                {
                    Console.WriteLine("20$");
                }
            }
            else if (readDay == "Holiday")
            {
                if ((readAge >= 0 && readAge <= 18))
                {
                    Console.WriteLine("5$");
                }
                else if (readAge > 18 && readAge <= 64)
                {
                    Console.WriteLine("12$");
                }
                else if (readAge > 64 && readAge <= 122)
                {
                    Console.WriteLine("10$");
                }
            }
            if  (readAge < 0 || readAge > 122)
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
