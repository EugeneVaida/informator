using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string s = textBox1.Text + " ";            
            label2.Text = label2.Text + " " + StringSearch(s); 

        }

        public int StringSearch(string s)
        {
            int count = 0;           
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    string s1 = s.Substring(0, i);
                    if (!(s1.Length % 2 == 0))
                    {
                        for (int j = 0; j < s1.Length; j++)
                        {
                            if (s1[j] == '1')
                            {
                                count++;
                            }
                        }                        
                    }
                    s = s.Remove(0, i + 1);
                    i = 0;
                }
            }
            return count;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar <= '9') && !(e.KeyChar >= '2') && e.KeyChar != 8))
            {
                e.Handled = true;
                MessageBox.Show("Поле не может содержать буквы");
            }
        }
    }
}
