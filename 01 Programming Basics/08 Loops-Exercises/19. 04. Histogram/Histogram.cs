using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._04.Histogram
{
    class Histogram
    {
        static void Main(string[] args)
        {
            var numbersToRead = int.Parse(Console.ReadLine());
            var under200 = 0;
            var under399 = 0;
            var under599 = 0;
            var under799 = 0;
            var upper800 = 0;

            for (int i = 1; i <= numbersToRead; i++)
            {
                var read = int.Parse(Console.ReadLine());
                if (read < 200 && read >= 1)
                {
                    under200++;
                }
                else if (read <= 399)
                {
                    under399++;
                }
                else if (read <= 599)
                {
                    under599++;
                }
                else if (read <= 799)
                {
                    under799++;
                }
                else if (read <= 1000)
                {
                    upper800++;
                }
            }
            var step = 100.00 / numbersToRead;
            double procUnder200 = under200 * step;
            double procUnder399 = under399 * step;
            double procUnder599 = under599 * step;
            double procUnder799 = under799 * step;
            double procUpper800 = upper800 * step;
            Console.Write("{0:f2}", procUnder200);
            Console.WriteLine("%");
            Console.Write("{0:f2}", procUnder399);
            Console.WriteLine("%");
            Console.Write("{0:f2}", procUnder599);
            Console.WriteLine("%");
            Console.Write("{0:f2}", procUnder799);
            Console.WriteLine("%");
            Console.Write("{0:f2}", procUpper800);
            Console.WriteLine("%");
        }
    }
}
