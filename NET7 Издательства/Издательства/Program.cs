using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Издательства
{
    class Program
    {
        public static void WhatKindOfIzdat()
        {
                Console.WriteLine("Выберите издательство:" + "\n" + "1 - Форум" + "\n" + "2 - Звезда" + "\n" + "3 - Печатник");
                int c = int.Parse(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        Forum f = new Forum();
                        f.newForum();
                        f.CalculateForum();
                        vivod vf = new vivod();
                        vf.infa(f);
                        break;
                    case 2:
                        Zvezda z = new Zvezda();
                        z.newZvezda();
                        z.CalculateZvezda();
                        vivod vz = new vivod();
                        vz.infa(z);
                        break;
                    case 3:
                        Pechatnik p = new Pechatnik();
                        p.newPechatnik();
                        p.CalculatePechatnik();
                        vivod vp = new vivod();
                        vp.infa(p);
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
            
        }    
    }
}
