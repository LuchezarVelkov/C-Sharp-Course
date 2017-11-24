using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var readNumbers = int.Parse(Console.ReadLine());
            var vale = 0; //1
            var difVale = 0; //
            var previewVale = 0; //2

            for (int i = 1; i <= readNumbers; i++)
            {
                var firsNumber = 0;
                var secondNumber = 0;
                for (int i2 = 1; i2 <= 2; i2++)
                {
                    var readValue = int.Parse(Console.ReadLine());
                    if (i2 % 2 == 1)
                    {
                        secondNumber = readValue;
                    }
                    else
                    {
                        firsNumber = readValue;
                    }
                }
                if (i == 1)
                {
                    previewVale = (firsNumber + secondNumber);
                    vale = previewVale;
                }
                else
                {
                    if ((firsNumber + secondNumber) != previewVale)
                    {
                        difVale = Math.Abs(previewVale - (firsNumber + secondNumber));
                    }
                    previewVale = (firsNumber + secondNumber);
                }

            }
            if (difVale == 0)
            {
                Console.WriteLine("Yes, value=" + vale);
            }
            else
            {
                Console.WriteLine("No, maxdiff=" + difVale);
            }
        }
    }
}
