using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace laba11
{
    public interface IComparer <in T>
    {
    int CompareTo(T x, T y);
    }

    struct Student
    {
        public string fio;
        public string test;
        public DateTime data_test;
        public int ozenka;
        public Student(string fio, string test, DateTime data_test, int ozenka)
        {
            this.fio = fio;
            this.test = test;
            this.data_test = data_test;
            this.ozenka = ozenka;
        }
    }
    public class Tree<TItem> : IComparer<Tree<TItem>>, IEnumerable<Tree<TItem>>, IEnumerable<TItem>
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
    }

        // возвращаем перечислитель
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<Tree<TItem>> GetEnumerator()
        {
          
//            yield return this;

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
//                MessageBox.Show(mas[ii].str);
                yield return mas[ii];
                if (mas[ii].left != null)
                    yield return mas[ii].left;
//                MessageBox.Show("mas[i].left.value");
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
        public int CompareTo(Tree<TItem> x, Tree<TItem> y)
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

        public void Insert(TItem value,string str,int ind)
        {
               
            if (this.count == 0)
            {
                this.value = value;
                this.str = str;
                this.ind = ind;
                this.count = 1;

            }
            else
            {
                Tree<TItem> val = new Tree<TItem>();
                val.value = value;
                val.str = str;
                val.ind = ind;
                if (CompareTo(this, val) == 1)
                {
                    if (this.left == null)
                        this.left = new Tree<TItem>();
                    left.Insert(value,str,ind);
                }
                else if (CompareTo(this, val) == -1)
                {
                 
                    if (this.right == null)
                        this.right = new Tree<TItem>();
                    right.Insert(value,str,ind);
                }
                else
                {
                   
                    this.count++;
                }
            }
            this.count++;
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
//            string result = "";
//            if (t.left != null)
//                result += Display(t.left);
//            result += t.value + " ";
//            if (t.right != null)
//                result += Display(t.right);
            return result;
        }
        public Tree()
        {
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
