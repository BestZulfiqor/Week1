using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misoli_10
{
    internal class Program
    {
        static int Func(int a)
        {
            int sum = 0;
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    sum++;
                }
            }
            if (sum != 0)
            {
                return a;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split();
            int[] nums = new int[n];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(s[i]);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (Func(nums[i]) != 0)
                {
                    Console.Write(Func(nums[i]) + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
