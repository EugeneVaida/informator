using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);            
            double step = double.Parse(textBox2.Text);
            double x = double.Parse(textBox3.Text);
            int b = int.Parse(textBox4.Text);
            int k = 0;
            var count_step = (double) n /step;
            int num = 0;
            while (x <= b)
            {
                ShowResult(x,num,Summ(count_step, k,x),Function_Y(x),Difference(Summ(count_step, k, x), Function_Y(x)));                
                x = x + step;
                num++;
            }
            
        }

        public int Fact(int k)
        {
            if (k == 0)
                return 1;
            else
            {
                int g = 1;
                for (int i = 1; i <= k; i++)
                {
                    g = g * i;
                }
                return g;
            }
        }

        public double Summ(double count_step, int k, double x)
        {
            double sum = 0;
            for (int i = 0; i <= count_step; i++)
            {
                sum = sum + (Math.Cos(i * x) / Fact(i)); 
            }
            return sum;
        }

        public double Function_Y(double x)
        {
            return Math.Pow(Math.E, Math.Cos(x)) * Math.Cos(Math.Sin(x));
        }

        public double Difference(double x, double y)
        {
            return Math.Round(Math.Abs(y - x));
        }

        public void ShowResult(double value, int num,double x, double y, double diff)
        {
            listBox1.Items.Add(value + " " + num + " " + x + " " + y + " " + diff); 
            
        }        

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 45 && e.KeyChar != 46 && e.KeyChar != ',')
            {
                e.Handled = true;
                MessageBox.Show("Поле не может содержать буквы");
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 45 && e.KeyChar != 46)
            {
                e.Handled = true;
                MessageBox.Show("Поле не может содержать буквы");
            }
        }
    }
}
