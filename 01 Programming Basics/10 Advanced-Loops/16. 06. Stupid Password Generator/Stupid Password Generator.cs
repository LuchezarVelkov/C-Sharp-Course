using System;

namespace _16._06.Stupid_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());

            for (int first = 1; first <= n; first++)
            {
                for (int second = 1; second <= n; second++)
                {
                    for (char third = 'a'; third < 'a' + l; third++)
                    {
                        for (char four = 'a'; four < 'a' + l; four++)
                        {
                            for (int five = Math.Max(first,second) + 1; five <= n; five++)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ",first,second,third,four,five);
                            }
                        }
                    }
                }
            }
        }
    }
}
