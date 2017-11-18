using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Комплексные_числа
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Complex p1 = new Complex(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
            Complex p2 = new Complex(double.Parse(textBox3.Text), double.Parse(textBox4.Text));           

            if (radioButton1.Checked)
                listBox1.Items.Add(p1 + p2);
            if (radioButton2.Checked)
                listBox1.Items.Add(p1 * p2);
            if (radioButton3.Checked)
                listBox1.Items.Add(p1 / p2);



        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9') && (e.KeyChar != 8))
            {
                e.Handled = true;
                MessageBox.Show("Строка не должна содержать буквы");
            }
        }
    }
}
