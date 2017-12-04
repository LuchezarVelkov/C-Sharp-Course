using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> readWords = Console.ReadLine()
                .Split(new char[] 
                {' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[', ']'}
                , StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            
            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();
            List<string> upperCase = new List<string>();

            for (int i = 0; i < readWords.Count; i++)
            {
                if (readWords[i].All(char.IsLower))
                {
                    lowerCase.Add(readWords[i]);
                }
                else if (readWords[i].All(char.IsUpper))
                {
                    upperCase.Add(readWords[i]);
                }
                else
                {
                    mixedCase.Add(readWords[i]);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }
    }
}
