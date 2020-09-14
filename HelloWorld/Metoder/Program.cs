using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine(add(number));

            string[] reverse = new string[3] { "Jag ", "heter ", "Andreas "};
            Console.WriteLine(ord(reverse));
            Console.WriteLine();
            Console.WriteLine("Largest Number: " + sort(number).Item1 + "\nSmallest Number: " + sort(number).Item2);

        }

        static int add(int[] number)
        {
            var sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }
            return sum;
        }

        static string ord(string[] reverse)
        {
            var sum = "";
            for (int i = 0; i < reverse.Length; i++)
            {
                sum += reverse[i];
            }
            Array.Reverse(reverse);
            Console.WriteLine();
            for (int i = 0; i < reverse.Length; i++)
            {
                
                sum += reverse[i];
            }
            return sum;
        }

        static (int,int) sort(int[] number)
        {
            int big = number.Max();
            int small = number.Min();
            int[] bigAndSmall = { big, small };
           
            return (number.Max(), number.Min());
        }
    }
}
