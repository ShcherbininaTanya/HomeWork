using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_5_2
{
    public class mnogochlen
    {
        public int a;
        public int b;
        public int c;

        public mnogochlen()
        {
            this.a = 0;
            this.b = 0;
            this.c = 0;
        }
        public mnogochlen(int aa, int bb, int cc)
        {
            this.a = aa;
            this.b = bb;
            this.c = cc;
        }

        public static mnogochlen operator +(mnogochlen m1, mnogochlen m2)
        {
            mnogochlen m = new mnogochlen();
            m.a = m1.a + m2.a;
            m.b = m1.b + m2.b;
            m.c = m1.c + m2.c;
            return m;
        }
        public static mnogochlen operator -(mnogochlen m1, mnogochlen m2)
        {
            mnogochlen m = new mnogochlen();
            m.a = m1.a - m2.a;
            m.b = m1.b - m2.b;
            m.c = m1.c - m2.c;
            return m;
        }
        public static mnogochlen operator *(mnogochlen m1, int x)
        {
            mnogochlen m = new mnogochlen();
            m.a = m1.a * x;
            m.b = m1.b * x;
            m.c = m1.c * x;
            return m;
        }
       
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество многочленов");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Многочлен - уравнение вида a*x^2+b*x+c=0");
            mnogochlen[] m = new mnogochlen[n + 1];
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Введите a:");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите b:");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите c:");
                int c = int.Parse(Console.ReadLine());
                m[i] = new mnogochlen(a, b, c);
            }
            bool cyc = true;
            while (cyc)
            {
                Console.WriteLine("Доступные векторы:");
                for (int i = 1; i < n + 1; i++)
                {
                    Console.WriteLine("m" + i + " : " + m[i].a + " * x^2 + " + m[i].b + " * x + " + m[i].c + " = 0");
                }
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1 - сложение двух многочленов" + "\n" + "2 - вычитание одного многочлена из другого" + "\n" + "3 - умножение многочлена на число" );
                int s = int.Parse(Console.ReadLine());
                int m1, m2;
                mnogochlen rez = new mnogochlen();
                switch (s)
                {
                    case 1:
                        Console.WriteLine("Выберите первый многочлен:");
                        m1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Выберите второй многочлен:");
                        m2 = int.Parse(Console.ReadLine());
                        rez = m[m1] + m[m2];
                        Console.WriteLine("m" + m1 + " + m" + m2 + " = " + rez.a + " * x^2 + " + rez.b + " * x + " + rez.c + " = 0");
                        break;
                    case 2:
                        Console.WriteLine("Выберите первый многочлен:");
                        m1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Выберите второй многочлен:");
                        m2 = int.Parse(Console.ReadLine());
                        rez = m[m1] - m[m2];
                        Console.WriteLine("m" + m1 + " - m" + m2 + " = " + rez.a + " * x^2 + " + rez.b + " * x + " + rez.c + " = 0");
                        break;
                    case 3:
                        Console.WriteLine("Выберите многочлен:");
                        m1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите число:");
                        int x = int.Parse(Console.ReadLine());
                        rez = m[m1] * x;
                        Console.WriteLine("m" + m1 + " * " + x + " = " + rez.a + " * x^2 + " + rez.b + " * x + " + rez.c + " = 0");
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Продолжить вычисления?" + "\n" + "1 - Да" + "\n" + "2 - Нет");
                int p = int.Parse(Console.ReadLine());
                if (p == 1) cyc = true;
                else cyc = false;

            }
            Console.WriteLine("Нажмите на любую клавижу для продолжения...");
            Console.Read();

        }
    }
}
