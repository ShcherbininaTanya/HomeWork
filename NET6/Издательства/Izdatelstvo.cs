using System;

namespace Издательства
{
    
    public class Forum
    {
        public string name;
        public double book;
        public double magazine;
        public double newspaper;
        public double booklet;
        public double price_b;       //цена за страницу книги
        public double price_m;       //за журнал
        public double price_np;      //за газету
        public double price_bl;      //за буклет
        public double dohod;

        public Forum()
        {
            name = "Форум";
            price_b = 3;
            price_m = 4.5;
            price_np = 2;
            price_bl = 2.5;
        }
        public Forum(double sb, double sm, double sn, double sbl)
        {
            name = "Форум";
            price_b = 3;
            book = sb;
            price_m = 4.5;
            magazine = sm;
            price_np = 2;
            newspaper = sn;
            price_bl = 2.5;
            booklet = sbl;
        }

        public void newForum()
        {
            Console.WriteLine("Вы выбрали издательство Форум");
            Console.WriteLine("Введите количество страниц книг");
            book = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество страниц журналов");
            magazine = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество страниц газет");
            newspaper = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество страниц буклетов");
            booklet = double.Parse(Console.ReadLine());
        }
        public double CalculateForum()
        {
            double dohod = book * price_b + magazine * price_m + newspaper * price_np + booklet * price_bl;
            this.dohod = dohod;
            return this.dohod;
        }
    }

    public class Zvezda
    {
        public string name;
        public double book;
        public double magazine;
        public double price_b;       //цена за страницу книги
        public double price_m;       //за журнал
        public double dohod;

        public Zvezda()
        {
            name = "Звезда";
            price_b = 5;
            price_m = 6;
        }
        public Zvezda(double sb, double sm)
        {
            name = "Звезда";
            price_b = 5;
            book = sb;
            price_m = 6;
            magazine = sm;
        }
        public void newZvezda()
        {
            Console.WriteLine("Вы выбрали издательство Звезда");
            Console.WriteLine("Введите количество страниц книг");
            book = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество страниц журналов");
            magazine = double.Parse(Console.ReadLine());
        }
        public double CalculateZvezda()
        {
            double dohod = book * price_b + magazine * price_m;
            this.dohod = dohod;
            return this.dohod;
        }
    }

    public class Pechatnik
    {
        public string name;
        public double magazine;
        public double newspaper;
        public double booklet;
        public double price_m;       //цена за журнал
        public double price_np;      //за газету
        public double price_bl;      //за буклет
        public double dohod;

        public Pechatnik()
        {
            name = "Печатник";
            price_m = 3.5;
            price_np = 1.5;
            price_bl = 4;
        }
        public Pechatnik(double sm, double sn, double sbl)
        {
            name = "Печатник";
            price_m = 3.5;
            magazine = sm;
            price_np = 1.5;
            newspaper = sn;
            price_bl = 4;
            booklet = sbl;
        }
        public void newPechatnik()
        {
            Console.WriteLine("Вы выбрали издательство Печатник");
            Console.WriteLine("Введите количество страниц журналов");
            magazine = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество страниц газет");
            newspaper = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество страниц буклетов");
            booklet = double.Parse(Console.ReadLine());
        }
        public double CalculatePechatnik()
        {
            double dohod = magazine * price_m + newspaper * price_np + booklet * price_bl;
            this.dohod = dohod;
            return this.dohod;
        }
    }

    public class vivod
    {
        public void infa(Forum f)
        {
            Console.WriteLine("Информация об издательстве " + f.name);
            Console.WriteLine("Количество напечатанных страниц книг: " + f.book);
            Console.WriteLine("Цена одной страницы книги: " + f.price_b);
            Console.WriteLine("Количество напечатанных страниц журналов: " + f.magazine);
            Console.WriteLine("Цена одной страницы журнала: " + f.price_m);
            Console.WriteLine("Количество напечатанных страниц газет: " + f.newspaper);
            Console.WriteLine("Цена одной страницы газеты: " + f.price_np);
            Console.WriteLine("Количество напечатанных буклетов: " + f.booklet);
            Console.WriteLine("Цена одной страницы буклета: " + f.price_bl);
            Console.WriteLine("Общий доход издательства: " + f.CalculateForum());
        }

        public void infa(Zvezda z)
        {
            Console.WriteLine("Информация об издательстве " + z.name);
            Console.WriteLine("Количество напечатанных страниц книг: " + z.book);
            Console.WriteLine("Цена одной страницы книги: " + z.price_b);
            Console.WriteLine("Количество напечатанных страниц журналов: " + z.magazine);
            Console.WriteLine("Цена одной страницы журнала: " + z.price_m);
            Console.WriteLine("Общий доход издательства: " + z.CalculateZvezda());
        }

        public void infa(Pechatnik p)
        {
            Console.WriteLine("Информация об издательстве " + p.name);
            Console.WriteLine("Количество напечатанных страниц журналов: " + p.magazine);
            Console.WriteLine("Цена одной страницы журнала: " + p.price_m);
            Console.WriteLine("Количество напечатанных страниц газет: " + p.newspaper);
            Console.WriteLine("Цена одной страницы газеты: " + p.price_np);
            Console.WriteLine("Количество напечатанных буклетов: " + p.booklet);
            Console.WriteLine("Цена одной страницы буклета: " + p.price_bl);
            Console.WriteLine("Общий доход издательства: " + p.CalculatePechatnik());
        }

    }


}
