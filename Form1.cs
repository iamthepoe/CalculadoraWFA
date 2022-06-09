using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;
            valor1 = double.Parse(textBox1.Text);
            valor2 = double.Parse(textBox2.Text);
            resultado = valor1 + valor2;
            textBox3.Text = resultado.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;
            valor1 = double.Parse(textBox1.Text);
            valor2 = double.Parse(textBox2.Text);
            resultado = valor1 - valor2;
            textBox3.Text = resultado.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;
            valor1 = double.Parse(textBox1.Text);
            valor2 = double.Parse(textBox2.Text);
            resultado = valor1 / valor2;
            textBox3.Text = resultado.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;
            valor1 = double.Parse(textBox1.Text);
            valor2 = double.Parse(textBox2.Text);
            resultado = valor1 * valor2;
            textBox3.Text = resultado.ToString();
        }
    }
}
