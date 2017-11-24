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
            if (num <= 9)
            {
                switch (num)
                {
                    case 1:
                        numText = "one";
                        break;
                    case 2:
                        numText = "two";
                        break;
                }
                Console.WriteLine(numText);
            }
            else
                Console.WriteLine("number too big");
        }
    }
}
