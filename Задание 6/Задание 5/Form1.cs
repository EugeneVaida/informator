using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int m = int.Parse(textBox2.Text);
            // Create DataBase and Array size
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.RowHeadersWidth = 100;
            
            for (int i = 1; i <= n; i++)
            {
                dataGridView1.Columns.Add(i.ToString(), i.ToString());
                dataGridView1.Columns[i-1].Width = 20;
            }
            
            for (int i = 1; i <= m; i++)
            {
                dataGridView1.Rows.Add(1);
                dataGridView1.Rows[i-1].HeaderCell.Value = "Строка" + " " + i;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int m = int.Parse(textBox2.Text);
            int[,] ArrayOfValues = new int[n,m];
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (!(int.TryParse(ReadFromData( i, j ).ToString(), out int s)))
                    {
                        MessageBox.Show("В таблице присутствуют элементы неверного типа данных");
                        break;
                    }

                    else ArrayOfValues[i,j] = int.Parse(ReadFromData( i, j ));
                }



            }

            
            label2.Text = label2.Text + " " + CountOfResults(ArrayOfValues, n , m);

        }

        public string ReadFromData(int i, int j)
        {

            string k;
            if (dataGridView1[i, j].Value == null)
                k = " ";
            else
                k = dataGridView1[i, j].Value.ToString();
            return k;
        }

        public int CountOfResults(int [,] Array, int n, int m)
        {
            int count = 0;
            for (int i = 1; i < n - 1; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (Array[i, j] < Array[i - 1 , j] && Array[i,j] > Array[i + 1, j])
                        count++;
                }
            }
            return count;
        }
    }
}
