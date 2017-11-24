using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pass = "s3cr3t!P@ssw0rd";
            if (input == pass)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
