using System;

namespace _08.Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            if (type == "int")
            {
                int firstValue = int.Parse(Console.ReadLine());
                int secondValue = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstValue,secondValue));
            }
            else if (type == "char")
            {
                char firstValue = char.Parse(Console.ReadLine());
                char secondValue = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstValue, secondValue));
            }
            else if (type == "string")
            {
                string firstValue = Console.ReadLine();
                string secondValue = Console.ReadLine();
                var bigger = firstValue.CompareTo(secondValue);
                Console.WriteLine(GetMax(firstValue, secondValue));
            }
        }

        static int GetMax(int firstValye, int secondValue)
        {
            int bigger;
            if ((int)firstValye > (int)secondValue)
            {
                bigger = firstValye;
            }
            else
            {
                bigger = secondValue;
            }
            return bigger;
        }

        static char GetMax(char firstValye, char secondValue)
        {
            char bigger;
            if ((char)firstValye > (char)secondValue)
            {
                bigger = firstValye;
            }
            else
            {
                bigger = secondValue;
            }
            return bigger;
        }

        static string GetMax(string firstValye, string secondValue)
        {
            var checkBigger = firstValye.CompareTo(secondValue);
            string bigger = null;
            if (checkBigger == 1)
            {
                bigger = $"{firstValye}";
            }
            else if (checkBigger == -1)
            {
                bigger = $"{secondValue}";
            }
            else
            {
                bigger = $"Equal";
            }
            return bigger;
        }
    }
}
