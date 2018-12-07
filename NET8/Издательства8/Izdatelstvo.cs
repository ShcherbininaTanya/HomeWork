using System;

namespace Издательства8
{
    public class Izdatelstvo
    {
        public string name;
        protected double book;
        protected double magazine;
        protected double newspaper;
        protected double booklet;
        public double price_b;       //цена за страницу книги
        public double price_m;       //за журнал
        public double price_np;      //за газету
        public double price_bl;      //за буклет
        protected double dohod;

        public Izdatelstvo()
        {
            name = "Издательство";
            price_b = 3;
            price_m = 4.5;
            price_np = 2;
            price_bl = 2.5;
        }
        public Izdatelstvo(double sb, double sm, double sn, double sbl)
        {
            name = "Издательство";
            price_b = 3;
            book = sb;
            price_m = 4.5;
            magazine = sm;
            price_np = 2;
            newspaper = sn;
            price_bl = 2.5;
            booklet = sbl;
        }

        public void setBook(double b)
        {
            while (b < 0)
            {
                Console.WriteLine("Введите количество страниц книг еще раз");
                b = double.Parse(Console.ReadLine());
            }
            book = b;
        }
        public double getBook()
        {
            return book;
        }
        public void setMag(double m)
        {
            while (m < 0)
            {
                Console.WriteLine("Введите количество страниц журналов еще раз");
                m = double.Parse(Console.ReadLine());
            }
            magazine = m;
        }
        public double getMag()
        {
            return magazine;
        }
        public void setNews(double n)
        {
            while (n < 0)
            {
                Console.WriteLine("Введите количество страниц газет еще раз");
                n = double.Parse(Console.ReadLine());
            }
            newspaper = n;
        }
        public double getNews()
        {
            return newspaper;
        }
        public void setBL(double b)
        {
            while (b < 0)
            {
                Console.WriteLine("Введите количество страниц буклетов еще раз");
                b = double.Parse(Console.ReadLine());
            }
            booklet = b;
        }
        public double getBL()
        {
            return booklet;
        }
        public void setDohod(double d)
        {
            while (d < 0)
            {
                Console.WriteLine("Введите количество страниц еще раз");
                d = double.Parse(Console.ReadLine());
            }
            dohod = d;
        }
        public double getDohod()
        {
            return dohod;
        }

        public virtual void newIzd()
        {
            Console.WriteLine("Вы выбрали издательство Форум");
            Console.WriteLine("Введите количество страниц книг");
            setBook(double.Parse(Console.ReadLine()));
            Console.WriteLine("Введите количество страниц журналов");
            setMag(double.Parse(Console.ReadLine()));
            Console.WriteLine("Введите количество страниц газет");
            setNews(double.Parse(Console.ReadLine()));
            Console.WriteLine("Введите количество страниц буклетов");
            setBL(double.Parse(Console.ReadLine()));
        }
        public virtual double CalculateIzd()
        {
            double dohod = book * price_b + magazine * price_m + newspaper * price_np + booklet * price_bl;
            this.dohod = dohod;
            return this.dohod;
        }
    }

    public class Forum : Izdatelstvo
    {
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
    }

    public class Zvezda : Izdatelstvo
    {
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

        public override void newIzd()
        {
            //base.newIzd();
            Console.WriteLine("Вы выбрали издательство Звезда");
            Console.WriteLine("Введите количество страниц книг");
            setBook(double.Parse(Console.ReadLine()));
            Console.WriteLine("Введите количество страниц журналов");
            setMag(double.Parse(Console.ReadLine()));
        }

        public override double CalculateIzd()
        {
            double dohod = book * price_b + magazine * price_m;
            this.dohod = dohod;
            return this.dohod;
        }
    }

    public class Pechatnik : Izdatelstvo
    {
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

        public override void newIzd()
        {
            Console.WriteLine("Вы выбрали издательство Печатник");
            Console.WriteLine("Введите количество страниц журналов");
            setMag(double.Parse(Console.ReadLine()));
            Console.WriteLine("Введите количество страниц газет");
            setNews(double.Parse(Console.ReadLine()));
            Console.WriteLine("Введите количество страниц буклетов");
            setBL(double.Parse(Console.ReadLine()));
        }
        public override double CalculateIzd()
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
            Console.WriteLine("Количество напечатанных страниц книг: " + f.getBook());
            Console.WriteLine("Цена одной страницы книги: " + f.price_b);
            Console.WriteLine("Количество напечатанных страниц журналов: " + f.getMag());
            Console.WriteLine("Цена одной страницы журнала: " + f.price_m);
            Console.WriteLine("Количество напечатанных страниц газет: " + f.getNews());
            Console.WriteLine("Цена одной страницы газеты: " + f.price_np);
            Console.WriteLine("Количество напечатанных буклетов: " + f.getBL());
            Console.WriteLine("Цена одной страницы буклета: " + f.price_bl);
            Console.WriteLine("Общий доход издательства: " + f.getDohod());
        }

        public void infa(Zvezda z)
        {
            Console.WriteLine("Информация об издательстве " + z.name);
            Console.WriteLine("Количество напечатанных страниц книг: " + z.getBook());
            Console.WriteLine("Цена одной страницы книги: " + z.price_b);
            Console.WriteLine("Количество напечатанных страниц журналов: " + z.getMag());
            Console.WriteLine("Цена одной страницы журнала: " + z.price_m);
            Console.WriteLine("Общий доход издательства: " + z.getDohod());
        }

        public void infa(Pechatnik p)
        {
            Console.WriteLine("Информация об издательстве " + p.name);
            Console.WriteLine("Количество напечатанных страниц журналов: " + p.getMag());
            Console.WriteLine("Цена одной страницы журнала: " + p.price_m);
            Console.WriteLine("Количество напечатанных страниц газет: " + p.getNews());
            Console.WriteLine("Цена одной страницы газеты: " + p.price_np);
            Console.WriteLine("Количество напечатанных буклетов: " + p.getBL());
            Console.WriteLine("Цена одной страницы буклета: " + p.price_bl);
            Console.WriteLine("Общий доход издательства: " + p.getDohod());
        }

    }
}
