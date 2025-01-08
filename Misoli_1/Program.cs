using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misoli_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            while (a != 0)
            {
                a = int.Parse(Console.ReadLine());
                if (max <= a)
                {
                    max = a;
                }
            }
            Console.WriteLine(max);
        }
    }
}
