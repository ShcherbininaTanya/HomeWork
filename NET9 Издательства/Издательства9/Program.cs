using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Издательства9
{
    class Program
    {
        public static double[] od = new double[3];
        public static void WhatKindOfIzdat()
        {
            Console.WriteLine("Выберите издательство:" + "\n" + "1 - Форум" + "\n" + "2 - Звезда" + "\n" + "3 - Печатник");
            int c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 1:
                    Forum f = new Forum();
                    f.newIzd();
                    f.CalculateIzd();
                    vivod vf = new vivod();
                    vf.infa(f);
                    od[0] = f.getDohod();
                    break;
                case 2:
                    Zvezda z = new Zvezda();
                    z.newIzd();
                    z.CalculateIzd();
                    vivod vz = new vivod();
                    vz.infa(z);
                    od[1] = z.getDohod();
                    break;
                case 3:
                    Pechatnik p = new Pechatnik();
                    p.newIzd();
                    p.CalculateIzd();
                    vivod vp = new vivod();
                    vp.infa(p);
                    od[2] = p.getDohod();
                    break;
                default:
                    break;
            }

        }
        static void Main(string[] args)
        {
            bool cycle = true;
            while (cycle)
            {
                WhatKindOfIzdat();
                Console.WriteLine("Продолжить?" + "\n" + "1 - Да" + "\n" + "2 - Нет");
                int q = int.Parse(Console.ReadLine());
                if (q != 1) cycle = false;
            }
            double countD = 0;
            for (int i = 0; i<od.Length; i++)
            {
                countD += od[i];
            }
            Console.WriteLine("Общий доход издательств: " + countD + " рублей");

            Console.Write("Для продолжения нажмите на любую клавишу...");
            Console.ReadKey(true);
        }

    }
}
