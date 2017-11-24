using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine().ToUpper();
            if (figure == "SQUARE")
            {
                var a = double.Parse(Console.ReadLine());
                Console.WriteLine(a*a);
            }
            if (figure == "RECTANGLE")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                Console.WriteLine(a * b);
            }
            if (figure == "CIRCLE")
            {
                var a = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.PI * a * a);
            }
            if (figure == "TRIANGLE")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                Console.WriteLine((a * b) / 2);
            }
        }
    }
}
