using System;
using System.Collections.Generic;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            string name = Console.ReadLine();

            while (name != "stop")
            {
                result[name] = Console.ReadLine();
                name = Console.ReadLine();
            }

            foreach (var email in result)
            {
                if (!email.Value.EndsWith("us") && !email.Value.EndsWith("uk"))
                {
                    Console.WriteLine($"{email.Key} -> {email.Value}");

                }
            }
        }
    }
}
