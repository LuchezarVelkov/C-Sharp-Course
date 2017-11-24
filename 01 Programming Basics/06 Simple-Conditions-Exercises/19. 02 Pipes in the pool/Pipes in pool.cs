using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._02_Pipes_in_the_pool
{
    class Program
    {
        static void Main(string[] args)
        {
            var volumePool = int.Parse(Console.ReadLine());
            var pipeOne = int.Parse(Console.ReadLine());
            var pipeTwo = int.Parse(Console.ReadLine());
            var hours = double.Parse(Console.ReadLine());

            var pipeOneFill = pipeOne * hours;
            var pipeTwoFill = pipeTwo * hours;
            var volumePoolFill = pipeOneFill + pipeTwoFill;
            var pipeOneFillProc = Math.Round((pipeOneFill / volumePoolFill) * 100);
            var pipeTwoFillProc = Math.Round((pipeTwoFill / volumePoolFill) * 100);
            var volumePoolFillProc = (volumePoolFill / volumePool) *100;

            if (volumePoolFillProc <= 99)
            {
                Console.WriteLine("The pool is " + volumePoolFillProc + "% full. Pipe 1: " + pipeOneFillProc + "%. Pipe 2: " + pipeTwoFillProc + "%.");
            }

            else
            {
                Console.WriteLine("For " + hours + " hours the pool overflows with " + (volumePoolFill - volumePool).ToString("0.0") + " liters.");
            }

        }
    }
}
