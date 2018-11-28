using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET4
{
    public class triangle
    {
        public int a;
        public int b;
        public int c;

        public bool isExist()
        {
            if ((this.a + this.b > this.c) & (this.a + this.c > this.b) & (this.b + this.c > this.a))
                return true;
            else
                return false;
        }
        public int Perimetr()
        {
            int P = this.a + this.b + this.c;
            return P;
        }
        public double Ploshad()
        {
            int a = this.a;
            int b = this.b;
            int c = this.c;
            double S;
            float p= (a + b + c)/2;
            S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }
        static void Main(string[] args)
        {
            triangle t = new triangle();
            Console.WriteLine("Введите первую сторону:");
            t.a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону:");
            t.b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третью сторону:");
            t.c = int.Parse(Console.ReadLine());
            bool ex = t.isExist();
            if (ex == true)
            {
                Console.WriteLine("Такой треугольник может существовать");
                int P = t.Perimetr();
                Console.WriteLine("Периметр треугольника равен " + P);
                double S = t.Ploshad();
                Console.WriteLine("Площадь треугольника равна " + S);
            }
            else
                Console.WriteLine("Такой треугольник не может существовать");
                Console.Write("Для продолжения нажмите на любую клавишу...");
                Console.ReadKey(true);
        }
    }
}
