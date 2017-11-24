using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Magical_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var readNumber = int.Parse(Console.ReadLine());

            for (int num1 = 1; num1 <= 9; num1++)
            {
                for (int num2 = 1; num2 <= 9; num2++)
                {
                    for (int num3 = 1; num3 <= 9; num3++)
                    {
                        for (int num4 = 1; num4 <= 9; num4++)
                        {
                            for (int num5 = 1; num5 <= 9; num5++)
                            {
                                for (int num6 = 1; num6 <= 9; num6++)
                                {
                                    if (num1 * num2 * num3 * num4 * num5 * num6 == readNumber)
                                    {
                                        Console.Write("{0}{1}{2}{3}{4}{5} ",num1,num2,num3,num4,num5,num6);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
