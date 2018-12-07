using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace laba11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
          
            InitializeComponent();
          
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string res;
            DateTime d = new DateTime(2018, 3, 2);
             Student st3;
             Tree<string> t3;
            Student st1 = new Student("Кузнецова В.И.","обществознание",d,5);    
            Student st2 = new Student("Ошов А.С.", "химия", d, 4);
            Student st4 = new Student("Щербинина Т.В.", "информатика", d, 5);
            Student st5 = new Student("Юнусов Р.М", "история", d, 5);

            Tree<string> t = new Tree<string>(st1.str);

            Tree<string> t1 = new Tree<string>(t,st2.str);

            Tree<string> t4 = new Tree<string>(t, st4.str);

            Tree<string> t5 = new Tree<string>(t, st5.str);

            if (textBox3.Text != "")
            {
                st3 = new Student(textBox3.Text, textBox4.Text, dateTimePicker1.Value, Convert.ToInt32(textBox6.Text));
                 t3 = new Tree<string>(t, st3.str);
            }
           
            res = t.Display(t);
            MessageBox.Show(res);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
