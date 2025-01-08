using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Misoli_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int sum = 0;
            Console.Write("Give a number:\n> ");
            int a = int.Parse(Console.ReadLine());
            while(a != 0)
            {
                count++;
                sum += a;
                Console.Write($"Give a number:\n> ");
                a = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Sum of numbers: {sum}");
            Console.Write($"Count of numbers: {count}");
        }
    }
}
