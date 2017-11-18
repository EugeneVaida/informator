using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_8
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            students.Add(new Student()
            {
                Name = textBox1.Text,
                Age = textBox3.Text,
                GroupNumber = int.Parse(textBox2.Text),
                Chemistry = int.Parse(textBox4.Text),
                Math = int.Parse(textBox5.Text),
                Phisics = int.Parse(textBox6.Text),
                ComputerScience = int.Parse(textBox7.Text),
                Average = (double.Parse(textBox4.Text) + double.Parse(textBox5.Text) + double.Parse(textBox6.Text) + double.Parse(textBox7.Text)) / 4

            });

                           
        }
            
        public void ShowStudents( List<Student> p)
        {
            dataGridView1.Rows.Clear();
            int index = 0;
            foreach (var Student in p){
                dataGridView1.Rows.Add(1);
                dataGridView1[0, index].Value = Student.Name;
                dataGridView1[1, index].Value = Student.GroupNumber ;
                dataGridView1[2, index].Value = Student.Age ;
                dataGridView1[3, index].Value = Student.Chemistry ;
                dataGridView1[4, index].Value = Student.Math ;
                dataGridView1[5, index].Value = Student.Phisics ;
                dataGridView1[6, index].Value = Student.ComputerScience ;
                dataGridView1[7, index].Value = Student.Average;

                index++;
            }
            
        }

        public void Change(List<Student> p)
        {
            foreach (var Student in p)
            {                
                textBox1.Text = Student.Name;
                textBox2.Text = Student.GroupNumber.ToString();
                textBox3.Text = Student.Age;
                textBox4.Text = Student.Chemistry.ToString();
                textBox5.Text = Student.Math.ToString();
                textBox6.Text = Student.Phisics.ToString();
                textBox7.Text = Student.ComputerScience.ToString();
                textBox8.Text = Student.Average.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowStudents(students.Where(x => x.ComputerScience >= 8 && x.Chemistry >= 8 && x.Math >= 8 && (x.Phisics == 4 | x.Phisics == 5)).ToList());
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9'))
            {
                e.Handled = true;
                MessageBox.Show("Поле может содержпть только цифры");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Change(students.Where(x => x.Name.Contains(textBox8.Text)).ToList());
            var Row = (students.Where(x => x.Name.Contains(textBox8.Text)).ToList());
            students.Remove(Row.FirstOrDefault());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowStudents(students);
        }
    }
}
