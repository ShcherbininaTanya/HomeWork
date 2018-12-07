using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public delegate int Deleg(int h, int m, int s, string zadan); // 1. Объявляем делегат
    public delegate void Deleg1(string zadan); // 1. Объявляем делегат
    public delegate int Deleg2(int hhh,int hhhn,string zadan); // 1. Объявляем делегат
    public partial class Form1 : Form
    {
        int h, m, s;
        string zadan;
      
        public Form1()
        {
            InitializeComponent();
        }
        public string getTextBox_1(object sender, EventArgs e)
        {
            return textBox1.Text;
        }
        public string getTextBox_2(object sender, EventArgs e)
        {
            return textBox2.Text;
        }
        public string getTextBox_3(object sender, EventArgs e)
        {
            MessageBox.Show(textBox3.Text);
            return this.textBox3.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int hhh,hhhn;
           h = Convert.ToInt32(textBox1.Text);
            m = Convert.ToInt32(textBox2.Text);
          s = Convert.ToInt32(textBox3.Text);
          zadan = Convert.ToString(textBox4.Text);
          Class1 rab1 = new Class1();
          hhh = h * 3600 + m * 60 + s;
          hhhn = h * 3600 + m * 60 + s;
          while (hhh >= 0)
          {
                   Thread.Sleep(1000); 
          hhh=rab1.Start1(hhh,hhhn,zadan);
          h = hhh / 3600;
          m = (hhh - h * 3600) / 60;
          s = hhh - h * 3600 - m * 60;
          label1.Text = Convert.ToString(h);
          label3.Text = Convert.ToString(m);
          label5.Text = Convert.ToString(s);
          label1.Refresh();
          label3.Refresh();
          label5.Refresh();
           }

          h = Convert.ToInt32(textBox5.Text);
          m = Convert.ToInt32(textBox6.Text);
          s = Convert.ToInt32(textBox7.Text);
          zadan = Convert.ToString(textBox8.Text);
          Class2 rab2 = new Class2();
          rab2.Nachalo += delegate       // обрабатываем события с помощью анонимных делегатов
          {
              MessageBox.Show("Начало отсчёта! " + zadan);

          };
          rab2.Konez += delegate       // добавление ссылки  на другое анонимное событие
          { MessageBox.Show("Обратный отсчёт завершён!"); };
          Deleg2 del = new Deleg2(rab2.Start1); //  Создаем переменную делегата и связываем c методом

          hhh = h * 3600 + m * 60 + s;
          hhhn = h * 3600 + m * 60 + s;
          while (hhh >= 0)
          {
              hhh = del(hhh, hhhn, zadan);  //сработал делегат
              if (hhh >= 0)
              {
                  h = hhh / 3600;
                  m = (hhh - h * 3600) / 60;
                  s = hhh - h * 3600 - m * 60;
                  Preob(h, m, s);
              }

          } 

          h = Convert.ToInt32(textBox10.Text);
          m = Convert.ToInt32(textBox11.Text);
          s = Convert.ToInt32(textBox12.Text);
          zadan = Convert.ToString(textBox9.Text);
          Class3 rab3 = new Class3();
          Deleg del3 = (h1, m1, s1,zadan1) => h * 3600 + m * 60 + s - 1;//  Создаем переменную делегата с помощью лямбда-выражения

          rab3.Nach(zadan);
            while (h + m + s > 0)
          {
              Thread.Sleep(1000);
              
              hhh = del3(h, m, s,zadan);  //сработал делегат
              h = hhh / 3600;
              m = (hhh - h * 3600) / 60;
              s = hhh - h * 3600 - m * 60;
              label1.Text = Convert.ToString(h);
              label3.Text = Convert.ToString(m);
              label5.Text = Convert.ToString(s);
              label1.Refresh();
              label3.Refresh();
              label5.Refresh();
             }
            rab3.Kon(zadan);
        }
  
        public void Preob(int h, int m, int s)
        {
             label1.Text = Convert.ToString(h);
                    label3.Text = Convert.ToString(m);
                    label5.Text = Convert.ToString(s);
                    label1.Refresh();
                    label3.Refresh();
                    label5.Refresh();
        }
      

        public class Class1
        {

            public int Start1(int hhh, int hhhn, string zadan)
            {
                if (hhh > 0)
                {
                    if (hhh == hhhn)
                        Nach(zadan);  // запуск метода
                    Thread.Sleep(1000);
                }
                else
                    Kon();  // запуск метода
                return hhh - 1;

            }
            public void Nach(string zadan)
            {
                MessageBox.Show("Начало отсчёта! "+zadan);

            }
            public void Kon()
            {
                MessageBox.Show("Обратный отсчёт завершён!");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        public class Class2
        {
          
            public event Deleg1 Nachalo;  // связываем событие с делегатом
            public event Deleg1 Konez;
            public int Start1(int hhh,int hhhn,string zadan)
            {
                if (hhh > 0)
                {
                    if (hhh == hhhn)
                        Nachalo(zadan);  // запуск события
                    Thread.Sleep(1000);
                }
                else
                    Konez(zadan);  // запуск события
                return hhh-1;
              
            }
          
        }
        public class Class3
        {

            public void Nach(string zadan)
            {
                MessageBox.Show("Начало отсчёта! " + zadan);

            }
            public void Kon(string zadan)
            {
                MessageBox.Show("Обратный отсчёт завершён!");

            }


        }

    }
}
