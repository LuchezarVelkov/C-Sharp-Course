using System;

namespace _07.Cake_Ingredie
{
    class Program
    {
        static void Main(string[] args)
        {
            string read = null;
            int usedProducts = 0;

            while (true)
            {
                read = Console.ReadLine();
                if (read == "Bake!")
                {
                    break;
                }
                Console.WriteLine($"Adding ingredient {read}.");
                usedProducts++;
            }
            Console.WriteLine($"Preparing cake with {usedProducts} ingredients.");
        }
    }
}
