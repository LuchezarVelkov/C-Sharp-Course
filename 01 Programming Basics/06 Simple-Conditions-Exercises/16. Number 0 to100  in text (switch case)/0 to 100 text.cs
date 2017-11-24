using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Number_0_to100_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var numText = "";
            if (num < 0)
            {
                Console.WriteLine("invalid number");
            }
            else if (num <= 20)
            {
                switch (num)
                {
                    case 0:
                        numText = "zero";
                        break;
                    case 1:
                        numText = "one";
                        break;
                    case 2:
                        numText = "two";
                        break;
                    case 3:
                        numText = "three";
                        break;
                    case 4:
                        numText = "four";
                        break;
                    case 5:
                        numText = "five";
                        break;
                    case 6:
                        numText = "six";
                        break;
                    case 7:
                        numText = "seven";
                        break;
                    case 8:
                        numText = "eight";
                        break;
                    case 9:
                        numText = "nine";
                        break;
                    case 10:
                        numText = "ten";
                        break;
                    case 11:
                        numText = "eleven";
                        break;
                    case 12:
                        numText = "twelve";
                        break;
                    case 13:
                        numText = "thirteen";
                        break;
                    case 14:
                        numText = "fourteen";
                        break;
                    case 15:
                        numText = "fifteen";
                        break;
                    case 16:
                        numText = "sixteen";
                        break;
                    case 17:
                        numText = "seventeen";
                        break;
                    case 18:
                        numText = "eighteen";
                        break;
                    case 19:
                        numText = "nineteen";
                        break;
                    case 20:
                        numText = "twenty";
                        break;
                }
                Console.WriteLine(numText);
            }
            else if (num <= 29)
            {
                num = num % 10;
                switch (num)
                {
                    case 0:
                        break;
                    case 1:
                        numText = " one";
                        break;
                    case 2:
                        numText = " two";
                        break;
                    case 3:
                        numText = " three";
                        break;
                    case 4:
                        numText = " four";
                        break;
                    case 5:
                        numText = " five";
                        break;
                    case 6:
                        numText = " six";
                        break;
                    case 7:
                        numText = " seven";
                        break;
                    case 8:
                        numText = " eight";
                        break;
                    case 9:
                        numText = " nine";
                        break;
                }
             Console.WriteLine("twenty" + numText);
            }
            else if (num <= 39)
            {
                num = num % 10;
                switch (num)
                {
                    case 0:
                        break;
                    case 1:
                        numText = " one";
                        break;
                    case 2:
                        numText = " two";
                        break;
                    case 3:
                        numText = " three";
                        break;
                    case 4:
                        numText = " four";
                        break;
                    case 5:
                        numText = " five";
                        break;
                    case 6:
                        numText = " six";
                        break;
                    case 7:
                        numText = " seven";
                        break;
                    case 8:
                        numText = " eight";
                        break;
                    case 9:
                        numText = " nine";
                        break;
                }
                Console.WriteLine("thirty" + numText);
            }
            else if (num <= 49)
            {
                num = num % 10;
                switch (num)
                {
                    case 0:
                        break;
                    case 1:
                        numText = " one";
                        break;
                    case 2:
                        numText = " two";
                        break;
                    case 3:
                        numText = " three";
                        break;
                    case 4:
                        numText = " four";
                        break;
                    case 5:
                        numText = " five";
                        break;
                    case 6:
                        numText = " six";
                        break;
                    case 7:
                        numText = " seven";
                        break;
                    case 8:
                        numText = " eight";
                        break;
                    case 9:
                        numText = " nine";
                        break;
                }
                Console.WriteLine("forty" + numText);
            }
            else if (num <= 59)
            {
                num = num % 10;
                switch (num)
                {
                    case 0:
                        break;
                    case 1:
                        numText = " one";
                        break;
                    case 2:
                        numText = " two";
                        break;
                    case 3:
                        numText = " three";
                        break;
                    case 4:
                        numText = " four";
                        break;
                    case 5:
                        numText = " five";
                        break;
                    case 6:
                        numText = " six";
                        break;
                    case 7:
                        numText = " seven";
                        break;
                    case 8:
                        numText = " eight";
                        break;
                    case 9:
                        numText = " nine";
                        break;
                }
                Console.WriteLine("fifty" + numText);
            }
            else if (num <= 69)
            {
                num = num % 10;
                switch (num)
                {
                    case 0:
                        break;
                    case 1:
                        numText = " one";
                        break;
                    case 2:
                        numText = " two";
                        break;
                    case 3:
                        numText = " three";
                        break;
                    case 4:
                        numText = " four";
                        break;
                    case 5:
                        numText = " five";
                        break;
                    case 6:
                        numText = " six";
                        break;
                    case 7:
                        numText = " seven";
                        break;
                    case 8:
                        numText = " eight";
                        break;
                    case 9:
                        numText = " nine";
                        break;
                }
                Console.WriteLine("sixty" + numText);
            }
            else if (num <= 69)
            {
                num = num % 10;
                switch (num)
                {
                    case 0:
                        break;
                    case 1:
                        numText = " one";
                        break;
                    case 2:
                        numText = " two";
                        break;
                    case 3:
                        numText = " three";
                        break;
                    case 4:
                        numText = " four";
                        break;
                    case 5:
                        numText = " five";
                        break;
                    case 6:
                        numText = " six";
                        break;
                    case 7:
                        numText = " seven";
                        break;
                    case 8:
                        numText = " eight";
                        break;
                    case 9:
                        numText = " nine";
                        break;
                }
                Console.WriteLine("sixty" + numText);
            }
            else if (num <= 79)
            {
                num = num % 10;
                switch (num)
                {
                    case 0:
                        break;
                    case 1:
                        numText = " one";
                        break;
                    case 2:
                        numText = " two";
                        break;
                    case 3:
                        numText = " three";
                        break;
                    case 4:
                        numText = " four";
                        break;
                    case 5:
                        numText = " five";
                        break;
                    case 6:
                        numText = " six";
                        break;
                    case 7:
                        numText = " seven";
                        break;
                    case 8:
                        numText = " eight";
                        break;
                    case 9:
                        numText = " nine";
                        break;
                }
                Console.WriteLine("seventy" + numText);
            }
            else if (num <= 89)
            {
                num = num % 10;
                switch (num)
                {
                    case 0:
                        break;
                    case 1:
                        numText = " one";
                        break;
                    case 2:
                        numText = " two";
                        break;
                    case 3:
                        numText = " three";
                        break;
                    case 4:
                        numText = " four";
                        break;
                    case 5:
                        numText = " five";
                        break;
                    case 6:
                        numText = " six";
                        break;
                    case 7:
                        numText = " seven";
                        break;
                    case 8:
                        numText = " eight";
                        break;
                    case 9:
                        numText = " nine";
                        break;
                }
                Console.WriteLine("eighty" + numText);
            }
            else if (num <= 99)
            {
                num = num % 10;
                switch (num)
                {
                    case 0:
                        break;
                    case 1:
                        numText = " one";
                        break;
                    case 2:
                        numText = " two";
                        break;
                    case 3:
                        numText = " three";
                        break;
                    case 4:
                        numText = " four";
                        break;
                    case 5:
                        numText = " five";
                        break;
                    case 6:
                        numText = " six";
                        break;
                    case 7:
                        numText = " seven";
                        break;
                    case 8:
                        numText = " eight";
                        break;
                    case 9:
                        numText = " nine";
                        break;
                }
                Console.WriteLine("ninety" + numText);
            }
            else if (num == 100)
            {
                Console.WriteLine("one hundred");
            }
            else
            {
                Console.WriteLine("invalid number");
            }
        }
    }
}
