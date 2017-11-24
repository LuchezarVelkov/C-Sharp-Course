using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            var birthDateAsString = Console.ReadLine();
            var format = "dd-MM-yyyy";
            var birthDate = DateTime.ParseExact(birthDateAsString, format, CultureInfo.InvariantCulture);
            birthDate = birthDate.AddDays(999);
            Console.WriteLine(birthDate.ToString(format));
        }
    }
}
