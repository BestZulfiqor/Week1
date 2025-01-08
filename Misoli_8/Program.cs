using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misoli_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rev = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i > 0; i /= 10) 
            {
                rev = rev * 10 + i % 10;
            }
            Console.Write(rev);
        }
    }
}
