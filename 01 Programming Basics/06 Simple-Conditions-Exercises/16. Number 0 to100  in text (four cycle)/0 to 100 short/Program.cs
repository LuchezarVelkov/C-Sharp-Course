using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class Program
{
    public static void Main()
    {
        var num = int.Parse(Console.ReadLine());
        var unitsten = (num / 10) % 10;
        var unit = num % 10;
        string str = null;
        string[] units = { null, "one", "two", "three", "four", "five", "six", "seven", "eight", "nine","ten","eleven", "twelve",
                             "thirteen", "fourteen", "fifteen", "sixteen","seventeen", "eighteen", "nineteen" };
        string[] unitstens = { null, "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy","eighty", "ninety" };
        if (num >= 101 || num < 0)
        {
            Console.Write("invalid number");
        }
        else if (num == 0)
        {
            str = "zero";
        }
        else if (num >= 1 && num <= 19)
        {
            str = units[num];
        }
        else if (num == 20 || num == 30 || num == 40 || num == 50 || num == 60 || num == 70 ||
        num == 80 || num == 90)
        {
            str = unitstens[unitsten];
        }
        else if (num > 20 && num <= 99)
        {
            str = unitstens[unitsten] + " " + units[unit];
        }
        else if (num == 100)
        {
            str = "one hundred";
        }
        Console.WriteLine(str);
    }
}