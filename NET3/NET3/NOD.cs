using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET3
{
    public class NOD
    {
        public void vremyaEV(int a, int b)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            nodEv(a, b);
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine("Затраченное время: " + ts);

        }
        public void vremyaBIN(int a, int b)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            nodBin(a, b);
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine("Затраченное время: " + ts);

        }
        public int nodEv(int a, int b)
        {
            while (b != 0)
                b = a % (a = b);
            return a;
        }
        public int nodEv(int a, int b, int c)
        {
            a = nodEv(a, b);
            while (c != 0)
                c = a % (a = c);
            return a;
        }
        public int nodEv(int a, int b, int c, int d)
        {
            a = nodEv(a, b, c);
            while (d != 0)
                d = a % (a = d);
            return a;
        }
        public int nodEv(int a, int b, int c, int d, int e)
        {
            a = nodEv(a, b, c, d);
            while (e != 0)
                e = a % (a = e);
            return a;
        }

        public int nodBin(int a, int b)
        {
            if (a == 0)
                return b;                          
            if (b == 0)
                return a;                     
            if (a == b)
                return a;                          
            if (a == 1 || b == 1)
                return 1;                          
            if ((a & 1) == 0)                      
                return ((b & 1) == 0)
                    ? nodBin(a >> 1, b >> 1) << 1       
                    : nodBin(a >> 1, b);                
            else                                     
                return ((b & 1) == 0)
                    ? nodBin(a, b >> 1)                 
                    : nodBin(b, a > b ? a - b : b - a); 
        }

        static void Main(string[] args)
        {
            NOD nn = new NOD();
            int a, b, c, d, e;
            bool cycle=true;
            while (cycle)
            {
                Console.WriteLine("Введите количество чисел:");
                int s = int.Parse(Console.ReadLine());
                switch (s)
                {
                    case 2:
                        Console.WriteLine("Наибольший общий делитель для двух чисел:");
                        Console.WriteLine("Введите первое число");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Наибольший общий делитель (алгоритм Евклида): " + "\n" + nn.nodEv(a, b));
                        nn.vremyaEV(a, b);
                        Console.WriteLine("Наибольший общий делитель (бинарный алгоритм Евклида): " + "\n" + nn.nodBin(a, b));
                        nn.vremyaBIN(a, b);
                        break;
                    case 3:
                        Console.WriteLine("Наибольший общий делитель для трех чисел:");
                        Console.WriteLine("Введите первое число");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите третье число");
                        c = int.Parse(Console.ReadLine());
                        Console.WriteLine("Наибольший общий делитель: " + nn.nodEv(a, b, c));
                        break;
                    case 4:
                        Console.WriteLine("Наибольший общий делитель для четырех чисел:");
                        Console.WriteLine("Введите первое число");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите третье число");
                        c = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите четвертое число");
                        d = int.Parse(Console.ReadLine());
                        Console.WriteLine("Наибольший общий делитель: " + nn.nodEv(a, b, c, d));
                        break;
                    case 5:
                        Console.WriteLine("Наибольший общий делитель для пяти чисел:");
                        Console.WriteLine("Введите первое число");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите второе число");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите третье число");
                        c = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите четвертое число");
                        d = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите пятое число");
                        e = int.Parse(Console.ReadLine());
                        Console.WriteLine("Наибольший общий делитель: " + nn.nodEv(a, b, c, d, e));
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Продолжить?" + "\n" + "1 - Да" + "\n"+ "2 - Нет");
                int cc = int.Parse(Console.ReadLine());
                if (cc == 1) cycle = true;
                else cycle = false;
            }
            Console.Write("Для продолжения нажмите на любую клавишу...");
            Console.ReadKey(true);
        }
    }
}
