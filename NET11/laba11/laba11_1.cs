using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace laba11
{
    public interface IComparer <in T> //используется для сравнения элементов
    {
    int CompareTo(T x, T y);
    }

    struct Student
    {
        public string fio;
        public string test;
        public DateTime data_test;
        public int ozenka;
        public string str;
        public Student(string fio, string test, DateTime data_test, int ozenka)
        {
            this.fio = fio;
            this.test = test;
            this.data_test = data_test;
            this.ozenka = ozenka;
            this.str = fio + "-" + test + "-" + data_test.ToString("dd.MM.yyyy") + "-" + ozenka + "\n";
        }
    }
    public class Tree<TItem> : IComparer<Tree<TItem>>, IEnumerable<Tree<TItem>>, IEnumerable<TItem> //чтобы участвать в работе оператора foreach, подключаются к классу, в котором этот оператор употребляется
    {
        public TItem value; // хранимая строка
        public int ind;
        public string str;
        public int count;    // счётчик повторений
        public Tree<TItem> left;    // ссылка на левое поддерево
        public Tree<TItem> right;   // ссылка на правое поддерево
 
        public Tree(TItem ch)
        {
            this.value = ch;
            if (ch.GetType() == typeof(string))
            {
                this.str = ch.ToString();
                this.ind = 0;
            }
            else
            {
                if (ch.GetType() == typeof(int))
                {
                    this.str = "";
                    this.ind = Convert.ToInt32(ch.ToString());
                }
                else
                    this.ind = 0;
            }
            this.count = 1;
        }

        public Tree(Tree<TItem> t,TItem ch)
        {
 
                Tree<TItem> val = new Tree<TItem>(ch);
                val.value = ch;
                if (ch.GetType() == typeof(string))
                {
                    val.str = ch.ToString();
                    val.ind = 0;
                }
                else
                {
                    val.str = "";
                    val.ind = Convert.ToInt32(ch.ToString());
                }

                if (CompareTo(t, val) == 1)
                {

                    if (t.left == null)
                        t.left = new Tree<TItem>(val.value);
                    this.left = new Tree<TItem>(t.left,val.value);
                }
                else if (CompareTo(t, val) == -1)
                {


                    if (t.right == null)
                        t.right = new Tree<TItem>( val.value);
                    this.right = new Tree<TItem>(t.right,val.value);
                }
                else
                {

                    t.count++;
                }

                t.count++;
       
        }
        IEnumerator IEnumerable.GetEnumerator() //создаем перечислитель
        {
            return GetEnumerator();
        }
        public IEnumerator<Tree<TItem>> GetEnumerator() //использование ключевого слова yield означает, что метод является итератором
        {
            //ключевое слово yield используется для перебора по коллекции или массиву
            Tree<TItem>[] mas=new Tree<TItem>[100];
            var current=this;
            int i=0;
            while (current.right != null)
            {

                mas[i] = current.right;
                current = current.right;
 
                i++;
            }
            for (int ii = i-1; ii >= 0; ii--)
            {
                yield return mas[ii];
                if (mas[ii].left != null)
                    yield return mas[ii].left;
            }
            yield return this;
            current = this;
            i = 0;
            while (current.left != null)
            {
                mas[i] = current.left;
                current = current.left;
                i++;
            }
            for (int ii = 0; ii < i; ii++)
            {
                if (mas[ii].right != null)
                    yield return mas[ii].right;
                yield return mas[ii];
                
            }

            
        }
        
        public int CompareTo(Tree<TItem> x, Tree<TItem> y) //сравнение 
        {
            if (y.str != "")
            {
            
                return string.Compare(x.str, y.str);
            }
            else
            {
                if (x.ind == y.ind)
                    return 0;
                else
                {

                    if (x.ind > y.ind)
                        return 1;
                    else
                        return -1;
                }
            }
        }

   
        public string Display(Tree<TItem> t)
        {
            string result = "";
            foreach (Tree<TItem> tt in t)
            {
                if (tt.str!="")
                result +=" "+tt.str;
                else
                    result += " " + tt.ind;
            }

            return result;
        }

        IEnumerator<TItem> IEnumerable<TItem>.GetEnumerator()
        {
            MessageBox.Show("333333");
            yield return this.value;
            if (this.left != null)
            {
                ((IEnumerable<TItem>)this.left).GetEnumerator();
                yield return this.left.value;
            }
            if (this.right != null)
            {
                ((IEnumerable<TItem>)this.right).GetEnumerator();
                yield return this.right.value;
            }
          
        }
    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
          
        }
    }
}
