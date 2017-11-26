using System;

namespace _01.Blank_Receipt
{
    class Program
    {
        static void PrintReceiptHeader()
        {
            Console.WriteLine($"CASH RECEIPT");
            Console.WriteLine($"------------------------------");
        }

        static void PrintReceiptBody()
        {
            Console.WriteLine($"Charged to____________________");
            Console.WriteLine($"Received by___________________");
        }

        static void PrintReceiptFootery()
        {
            Console.WriteLine($"------------------------------");
            Console.WriteLine($"\u00A9 SoftUni");
        }

        static void PrintReceipt()
        {
            PrintReceiptHeader();
            PrintReceiptBody();
            PrintReceiptFootery();
        }

        static void Main(string[] args)
        {
            PrintReceipt();
        }
    }
}
