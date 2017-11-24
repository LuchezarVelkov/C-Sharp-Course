using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Equal_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordOne = Console.ReadLine().ToUpper();
            var wordTwo = Console.ReadLine().ToUpper();
            Console.WriteLine(wordOne == wordTwo ? "yes" : "no");
        }
    }
}
