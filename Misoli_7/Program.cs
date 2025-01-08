using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Misoli_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberStr = Console.ReadLine();
            int sumOfDigits = 0;
            int productOfDigits = 1;

            for (int i = 0; i < numberStr.Length; i++)
            {
                int digit = int.Parse(numberStr[i].ToString());
                sumOfDigits += digit;
                productOfDigits *= digit;
            }

            Console.WriteLine($"{string.Join("+", numberStr.ToCharArray())}={sumOfDigits}");
            Console.WriteLine($"{string.Join("*", numberStr.ToCharArray())}={productOfDigits}");
        }
    }
}
