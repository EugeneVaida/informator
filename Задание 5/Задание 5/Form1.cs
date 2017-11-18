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

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            for (int i = 1; i <= n; i++)
            {
                dataGridView1.Columns.Add(i.ToString(), i.ToString());
                dataGridView1.Columns[i - 1].Width = 20;
            }
            dataGridView1.Rows.Add(1);
            dataGridView1.RowHeadersWidth = 100;
            dataGridView1.Rows[0].HeaderCell.Value = "Элементы";
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            
            int[] ArrayOfValues = new int[n];

            for (int i = 0; i < n; i++)
            {
                
                    if (!(int.TryParse(ReadFromData(i).ToString(), out int s)))
                    {
                        MessageBox.Show("В таблице присутствуют элементы неверного типа данных");
                        break;
                    }

                    else ArrayOfValues[i] = int.Parse(ReadFromData(i));

            }

            label2.Text = label2.Text + " " + CountOfResults(ArrayOfValues);
        }

        public string ReadFromData(int i)
        {

            string k;
            if (dataGridView1[i,0].Value == null)
                k = " ";
            else
                k = dataGridView1[i,0].Value.ToString();
            return k;
        }

        public int CountOfResults(int[] Array)
        {
            int count = 0;
            int result = 1;
            int buf_1 = -1;
            int buf_2 = -1;
            for (int i = 0; i < Array.Length && count < 2; i++)
            {
                if (buf_1 == -1)
                {
                    if (Array[i] == 0)
                    {
                        buf_1 = i;
                        count++;
                    }                       
                }
                else
                {
                    if (Array[i] == 0)
                    {
                        buf_2 = i;
                        count++;
                    }                        
                }
                                                           
            }
            if ( (buf_2 - buf_1) < 2)
            {
                result = 0;
            }
            else
            {
                for (int t = buf_1 + 1; t < buf_2; t++)
                {
                    result *= Array[t];
                }
            }
            
            return result;
        }
    }
}
