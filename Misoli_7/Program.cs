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
            //string input = Console.ReadLine();
            //char[] digits = input.ToCharArray();
            //Array.Sort(digits); // Сортировка по возрастанию
            //string sortedNumber = new string(digits);
            //Console.WriteLine(sortedNumber);

            //int number = int.Parse(Console.ReadLine());
            //List<int> digits = new List<int>();

            //// Извлечение цифр числа
            //while (number > 0)
            //{
            //    digits.Add(number % 10); // Берем последнюю цифру
            //    number /= 10;           // Убираем последнюю цифру
            //}

            //// Сортировка цифр
            //digits.Sort(); // Сортировка по возрастанию

            //// Сборка числа из отсортированных цифр
            //int sortedNumber = 0;
            //foreach (int digit in digits)
            //{
            //    sortedNumber = sortedNumber * 10 + digit; // Добавляем цифру к числу
            //}

            //Console.WriteLine(sortedNumber);

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
