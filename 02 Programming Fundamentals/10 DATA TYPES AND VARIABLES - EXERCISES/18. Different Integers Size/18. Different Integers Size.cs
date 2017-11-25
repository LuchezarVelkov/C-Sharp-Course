using System;

namespace _18.Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string readNumber = Console.ReadLine();
            
            string anser = null;
            string lastString = null;
            try
            {
                bool longNumber = long.Parse(readNumber) <= long.MaxValue;
                anser = $"{readNumber} can fit in:";
                Console.WriteLine(anser);
                lastString = $"* long";
            }
            catch (Exception)
            {
                Console.WriteLine($"{readNumber} can't fit in any type");
            }

            try
            {
                bool sbyteNumber = sbyte.Parse(readNumber) <= sbyte.MaxValue;
                Console.WriteLine($"* sbyte");
            }
            catch (Exception) {}

            try
            {
                bool byteNumber = byte.Parse(readNumber) <= byte.MaxValue;
                Console.WriteLine($"* byte");
            }
            catch (Exception){}

            try
            {
                bool shortNumber = short.Parse(readNumber) <= short.MaxValue;
                Console.WriteLine($"* short");
            }
            catch (Exception){}

            try
            {
                bool ushortNumber = ushort.Parse(readNumber) <= ushort.MaxValue;
                Console.WriteLine($"* ushort");
            }
            catch (Exception){}

            try
            {
                bool intNumber = int.Parse(readNumber) <= int.MaxValue;
                Console.WriteLine($"* int");
            }
            catch (Exception){}

            try
            {
                bool uintNumber = uint.Parse(readNumber) <= uint.MaxValue;
                Console.WriteLine($"* uint");
            }
            catch (Exception){}

            if (lastString != null)
            {
                Console.WriteLine(lastString);
            }
        }
    }
}
