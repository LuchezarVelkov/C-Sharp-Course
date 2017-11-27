using System;

namespace _03.Eng_Name_of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long readNumber = Math.Abs(long.Parse(Console.ReadLine()));
            Console.WriteLine(WriteLastNumberAtText(readNumber));
        }

        static string WriteLastNumberAtText(long n)
        {
            string lastDigitInText = null;
            n = n % 10;
            switch (n)
            {
                case 0:
                    lastDigitInText = "zero";
                    break;
                case 1:
                    lastDigitInText = "one";
                    break;
                case 2:
                    lastDigitInText = "two";
                    break;
                case 3:
                    lastDigitInText = "three";
                    break;
                case 4:
                    lastDigitInText = "four";
                    break;
                case 5:
                    lastDigitInText = "five";
                    break;
                case 6:
                    lastDigitInText = "six";
                    break;
                case 7:
                    lastDigitInText = "seven";
                    break;
                case 8:
                    lastDigitInText = "eight";
                    break;
                case 9:
                    lastDigitInText = "nine";
                    break;
            }

            return lastDigitInText;
        }
    }
}
