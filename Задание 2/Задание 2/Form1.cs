using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_2
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int z = int.Parse(textBox3.Text);
            double x = ValueOf_X(z);

            double y = a * ValueOfFunction(comboBox1.Text, x) - Math.Log(x + 2.5, Math.E) + b * ((Math.Pow(Math.E, x)) - (Math.Pow(Math.E, -x)));

            listBox1.Items.Add(y);
        }

        public double ValueOfFunction(string value, double x)
        {
            double r = 0;
            switch (value)
            {
                case "2*x": r = 2 * x;
                    break;
                case "x*x": r = x * x;
                    break;
                case "x / 3": r = x / 3;
                    break;                  
            }
            return r;
        }

        public double ValueOf_X(int z)
        {
            if (z < -1)
                return -z / 3;
            else
                return Math.Abs(z);
        }
    }
}
