using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Number_0._._._9_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var numText = "number too big";
            if (num <= 9)
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
                }
                Console.WriteLine(numText);
            }
            else
                Console.WriteLine(numText);
        }
    }
}
