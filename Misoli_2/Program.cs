using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misoli_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i <= a; i++)
            {
                sum += Math.Pow(n, i);
            }
            Console.WriteLine(sum);
        }
    }
}
