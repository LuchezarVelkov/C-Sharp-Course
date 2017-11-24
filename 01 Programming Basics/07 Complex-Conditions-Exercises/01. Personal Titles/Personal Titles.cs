using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = double.Parse(Console.ReadLine());
            var sex = Console.ReadLine().ToUpper();
            if (age >= 16)
            {
                if (sex == "F")
                {
                    Console.WriteLine("Ms.");
                }
                else
                {
                    Console.WriteLine("Mr.");
                }
            }
            else
            {
                if (sex == "M")
                {
                    Console.WriteLine("Master");
                }
                else
                {
                    Console.WriteLine("Miss");
                }
            }
        }
    }
}
