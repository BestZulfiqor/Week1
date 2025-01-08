using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Misoli_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int sum = 0;
            while (count < 2)
            {
                int a = int.Parse(Console.ReadLine());
                if (a == 0)
                {
                    count++;
                }
                else
                {
                    count = 0;
                    sum += a; 
                }
            }
            Console.WriteLine(sum);

        }
    }
}
