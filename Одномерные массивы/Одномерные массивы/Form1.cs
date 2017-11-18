using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Одномерные_массивы
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            double[] arr;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            if (int.TryParse(textBox1.Text, out int k))
            {
                for (int i = 0; i < int.Parse(textBox1.Text); i++)
                {
                    dataGridView1.Columns.Add((i + 1).ToString(), (i + 1).ToString());
                    dataGridView1.Columns[i].Width = 200;
                }
                dataGridView1.Rows.Add(1);
                dataGridView1.RowHeadersWidth = 100;
                dataGridView1.Rows[0].HeaderCell.Value = "Элементы";
            }
            else
            {
                MessageBox.Show("Только число!");
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RandomArray();            
        }

        public double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            double k = random.NextDouble();
            return k;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                random.
            }
            else
            {

            }
        }

        public void RandomArray()
        {
            Random random = new Random();

            double[] arr = new double[k];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.NextDouble() * (30 + 30) * (-10) + random.Next(1, 1000);
                dataGridView1[i, 0].Value = arr[i];
            }            
        }

        public void Max(double[] array)
        {
            double max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            label2.Text = label2.Text + max;

        }


        
    }
}
