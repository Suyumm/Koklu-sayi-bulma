using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            double delta ,x1, x2;

            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox2.Text);
            c = Convert.ToInt16(textBox3.Text);

            delta = b * b - 4 * a * c;

            if (delta>0)
            {
                x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                textBox4.Text = x1.ToString();
                textBox5.Text = x2.ToString();
            }
            else if (delta ==0)
            {
                x1 = -b / 2 * a;
                textBox4.Text = x1.ToString();
                textBox5.Text = x1.ToString();

            }
            else
            {
                textBox4.Text = "Kök Yoktur";
                textBox5.Text = "Kök Yoktur";
            }
        }
    }
}