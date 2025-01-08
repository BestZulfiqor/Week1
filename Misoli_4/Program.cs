using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Misoli_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ints = new int[n];
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < ints.Length - 1; i++)
            {
                if (ints[i] > 0 && ints[i + 1] > 0 || ints[i] < 0 && ints[i + 1] < 0)
                {
                    Console.WriteLine("YES");
                    return;
                }
            }
            Console.WriteLine("NO");
        }
    }
}
