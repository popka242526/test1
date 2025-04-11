using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;

namespace laba3
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double f;
            double a = double.Parse(textBox1.Text); ;
            double b = double.Parse(textBox2.Text); ;
            double x = double.Parse(textBox3.Text);
            if (Log(Pow(a, 2) + b * x) == 0 || Tan(a * x / PI)<0)
            {
                label1.Text="Ошибка: значение не опредлено";
                label4.Text = "Ошибка: значение не опредлено";
            }

            else
                {
                    f=(Pow(Cos(a * x), 2) * Log(Tan(a*x / PI)) / Log(Pow(a, 2) + (b * x),5));

                    label1.Text = "Значение F:" + f.ToString();
                    label4.Text = "Значение F в двоичной системе:" + Convert.ToString((int)f, 2);
                }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
