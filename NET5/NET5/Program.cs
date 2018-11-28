using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET5
{
    public class vector
    {
        public int x;
        public int y;
        public int z;

        public vector()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;
        }
        public vector(int xx, int yy, int zz)
        {
            this.x = xx;
            this.y = yy;
            this.z = zz;
        }

        public static vector operator +(vector v1, vector v2)
        {
            vector v = new vector();
            v.x = v1.x + v2.x;
            v.y = v1.y + v2.y;
            v.z = v1.z + v2.z;
            return v;
        }
        public static vector operator -(vector v1, vector v2)
        {
            vector v = new vector();
            v.x = v1.x - v2.x;
            v.y = v1.y - v2.y;
            v.z = v1.z - v2.z;
            return v;
        }
        public static vector operator *(vector v1, int a)
        {
            vector v = new vector();
            v.x = v1.x * a;
            v.y = v1.y * a;
            v.z = v1.z * a;
            return v;
        }
        public static int operator *(vector v1, vector v2)
        {
            int s;
            s = v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
            return s;
        }
        public double dlina()
        {
            double d = Math.Sqrt(this.x * this.x + this.y * this.y + this.z * this.z);
            return d;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество векторов");
            int n = int.Parse( Console.ReadLine());
            vector[] v = new vector[n+1];
            for (int i = 1; i<=n; i++)
            {
                Console.WriteLine("Введите x:");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите y:");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите z:");
                int z = int.Parse(Console.ReadLine());
                v[i] = new vector(x, y, z);
            }
            bool c=true;
            while (c)
            {
                Console.WriteLine("Доступные векторы:");
                for (int i = 1; i<n+1; i++)
                {
                    Console.WriteLine("v" + i + " = [" + v[i].x + ", " + v[i].y + ", " + v[i].z + "]");
                }
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1 - сложение двух векторов" + "\n" + "2 - вычитание одного вектора из другого" + "\n" + "3 - умножение вектора на число" + "\n" + "4 - скалярное произведение двух веторов" + "\n" + "5 - длина вектора");
                int s = int.Parse(Console.ReadLine());
                int v1, v2;
                vector rez = new vector();
                switch (s)
                {
                    case 1:
                        Console.WriteLine("Выберите первый вектор:");
                        v1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Выберите второй вектор:");
                        v2 = int.Parse(Console.ReadLine());
                        rez = v[v1] + v[v2];
                        Console.WriteLine("v" + v1 + " + v" + v2 + " = [" + rez.x + ", " + rez.y + ", " + rez.z + "]");
                        break;
                    case 2:
                        Console.WriteLine("Выберите первый вектор:");
                        v1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Выберите второй вектор:");
                        v2 = int.Parse(Console.ReadLine());
                        rez = v[v1] - v[v2];
                        Console.WriteLine("v" + v1 + " - v" + v2 + " = [" + rez.x + ", " + rez.y + ", " + rez.z + "]");
                        break;
                    case 3:
                        Console.WriteLine("Выберите вектор:");
                        v1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите число:");
                        int a = int.Parse(Console.ReadLine());
                        rez = v[v1] * a;
                        Console.WriteLine("v" + v1 + " * " + a + " = [" + rez.x + ", " + rez.y + ", " + rez.z + "]");
                        break;
                    case 4:
                        Console.WriteLine("Выберите первый вектор:");
                        v1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Выберите второй вектор:");
                        v2 = int.Parse(Console.ReadLine());
                        int r = v[v1] * v[v2];
                        Console.WriteLine("v" + v1 + " * v" + v2 + " = " + r);
                        break;
                    case 5:
                        Console.WriteLine("Выберите вектор:");
                        v1 = int.Parse(Console.ReadLine());
                        double rr = v[v1].dlina();
                        Console.WriteLine("Длина вектора v" + v1 + " = " + Math.Round(rr, 2));
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Продолжить вычисления?" + "\n" + "1 - Да" + "\n" + "2 - Нет");
                int p = int.Parse(Console.ReadLine());
                if (p == 1) c = true;
                else c = false;

            }
            Console.WriteLine("Нажмите на любую клавижу для продолжения...");
            Console.Read();

        }
    }
}
