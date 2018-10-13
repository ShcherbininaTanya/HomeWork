using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Работа с консолью:");
            Console.WriteLine("Введите координату X");
            decimal xx = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату Y");
            decimal yy = decimal.Parse(Console.ReadLine());
            Console.WriteLine("{0,-15} {1,-5}", "X: " + xx, "Y: " + yy);

            Console.WriteLine("Работа с файлом:");
            using (StreamReader file = new StreamReader(@"C:\Tanya\Универ\Net\Проекты\text.txt"))
            {
                while (!file.EndOfStream)
                {
                    string[] mass = file.ReadLine().Split(' ');
                    decimal x = decimal.Parse(mass[0]);
                    decimal y = decimal.Parse(mass[1]);
                    Console.WriteLine("{0,-15} {1,-5}", "X: "+x, "Y: "+y);
                }
                Console.Write("Для продолжения нажмите на любую клавишу");
                Console.ReadKey(true);
            }
        }
    }
}
