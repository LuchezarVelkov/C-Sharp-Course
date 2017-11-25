using System;

namespace _20_What_type_can_be_used_for_N__bonus_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine($"  {new string('_', 100)}");
                Console.WriteLine($"|| sbyte   || min value = {sbyte.MinValue} {new string(' ', 25)} || max value = {sbyte.MaxValue}{new string(' ', 27)}||");
                Console.WriteLine($"|| byte    || min value = {byte.MinValue} {new string(' ', 28)} || max value = {byte.MaxValue}{new string(' ', 27)}||");
                Console.WriteLine($"|| short   || min value = {short.MinValue} {new string(' ', 23)} || max value = {short.MaxValue}{new string(' ', 25)}||");
                Console.WriteLine($"|| ushort  || min value = {ushort.MinValue} {new string(' ', 28)} || max value = {ushort.MaxValue}{new string(' ', 25)}||");
                Console.WriteLine($"|| int     || min value = {int.MinValue} {new string(' ', 18)} || max value = {int.MaxValue}{new string(' ', 20)}||");
                Console.WriteLine($"|| uint    || min value = {uint.MinValue} {new string(' ', 28)} || max value = {uint.MaxValue}{new string(' ', 20)}||");
                Console.WriteLine($"|| long    || min value = {long.MinValue} {new string(' ', 9)} || max value = {long.MaxValue}{new string(' ', 11)}||");
                Console.WriteLine($"|| ulong   || min value = {ulong.MinValue} {new string(' ', 28)} || max value = {ulong.MaxValue}{new string(' ', 10)}||");
                Console.WriteLine($"|| float   || min value = {float.MinValue} {new string(' ', 16)} || max value = {float.MaxValue}{new string(' ', 18)}||");
                Console.WriteLine($"|| double  || min value = {double.MinValue} {new string(' ', 7)} || max value = {double.MaxValue}{new string(' ', 9)}||");
                Console.WriteLine($"|| decimal || min value = {decimal.MinValue} || max value = {decimal.MaxValue} ||");
                Console.WriteLine($"  {new string('_', 100)}");
                Console.WriteLine();
                Console.Write("Please enter a Number:");
                string readNumber = Console.ReadLine();

                string anser = null;
                string lastString = null;
                try
                {
                    bool decimalNumber = decimal.Parse(readNumber) <= decimal.MaxValue;
                    anser = $"Number {readNumber} can fit in:";
                    Console.WriteLine(anser);
                    lastString = $"* decimal";
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
                catch (Exception) { }

                try
                {
                    bool byteNumber = byte.Parse(readNumber) <= byte.MaxValue;
                    Console.WriteLine($"* byte");
                }
                catch (Exception) { }

                try
                {
                    bool shortNumber = short.Parse(readNumber) <= short.MaxValue;
                    Console.WriteLine($"* short");
                }
                catch (Exception) { }

                try
                {
                    bool ushortNumber = ushort.Parse(readNumber) <= ushort.MaxValue;
                    Console.WriteLine($"* ushort");
                }
                catch (Exception) { }

                try
                {
                    bool intNumber = int.Parse(readNumber) <= int.MaxValue;
                    Console.WriteLine($"* int");
                }
                catch (Exception) { }

                try
                {
                    bool uintNumber = uint.Parse(readNumber) <= uint.MaxValue;
                    Console.WriteLine($"* uint");
                }
                catch (Exception) { }

                try
                {
                    bool longNumber = long.Parse(readNumber) <= long.MaxValue;
                    Console.WriteLine($"* long");
                }
                catch (Exception) { }

                try
                {
                    bool ulongNumber = ulong.Parse(readNumber) <= ulong.MaxValue;
                    Console.WriteLine($"* ulong");
                }
                catch (Exception) { }

                try
                {
                    bool floatNumber = float.Parse(readNumber) <= float.MaxValue;
                    Console.WriteLine($"* float");
                }
                catch (Exception) { }

                try
                {
                    bool doubleNumber = double.Parse(readNumber) <= double.MaxValue;
                    Console.WriteLine($"* double");
                }
                catch (Exception) { }

                if (lastString != null)
                {
                    Console.WriteLine(lastString);
                }

                try
                {
                    Console.WriteLine();
                    Console.WriteLine($"Do you wont to chek another number");
                    Console.Write($"Y / N ? ");
                    char continued = char.Parse(Console.ReadLine());
                    if (continued == 'y' || continued == 'Y')
                    {
                        Console.Clear();
                    }
                    else
                    {
                        return;
                    }
                }
                catch (Exception)
                {
                    return;
                }
            }
        }
    }
}
