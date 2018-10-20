using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            Double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите корень какой степени вы хотите вычислить");
            Double n = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите точность");
            int t = int.Parse(Console.ReadLine());
            Console.WriteLine("Результат:");
            double rez = SqrtN(n, a);
            Console.WriteLine(Math.Round(rez, t));
            Console.WriteLine("Стандартная функция: " + Math.Round(Math.Pow(a, 1/n), t));
            Console.Write("Для продолжения нажмите на любую клавишу...");
            Console.ReadKey(true);
        }

        static double Stepen(double a, int st)
        {
            double result = 1;
            for (int i = 0; i < st; i++) result *= a;
            return result;
        }

        static double SqrtN(double n, double A, double eps = 0.0001)
        {
            var x0 = A/n;
            var x1 = (1/n)*((n-1)*x0+A/Stepen(x0,(int)n-1));

            while (Math.Abs(x1-x0)>eps)
            {
                x0 = x1;
                x1 = (1/n)*((n-1)*x0+A/Stepen(x0,(int)n-1));
            }

            return x1;
        }
    }
}
