using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
    class Program
    {
        static string DECtoBIN(int n)
        {
            string s = "";
            int del;
            while (n > 0)
            {
               del = n % 2;
                n = n / 2;
                s=del+s;
            }
            return s;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите число в десятичной системе:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Число " + n + " в двоичной системе счисления:");
            Console.WriteLine(DECtoBIN(n));
            string BinaryCode = Convert.ToString(n, 2);
            Console.WriteLine("Стандартная функция: " + BinaryCode);
            Console.Write("Для продолжения нажмите на любую клавишу...");
            Console.ReadKey(true);
        }
        
    }
}
