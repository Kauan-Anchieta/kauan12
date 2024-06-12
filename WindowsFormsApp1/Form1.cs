using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/".ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*".ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-".ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",".ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+".ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string expressao = textBox1.Text;
            string[] parte = expressao.Split('+', '-', '/', '*');

            if (parte.Length != 2)
            {
                MessageBox.Show("Inválido");
                return;
            }

            if (!double.TryParse(parte[0], out double num1) || !double.TryParse(parte[1], out double num2))
            {
                MessageBox.Show("Inválido!");
                return;
            }
                

            double resultado;
            switch (expressao[parte[0].Length])
            {
                case '+':
                    resultado = num1 + num2;
                    textBox1.Text = resultado.ToString();
                    break;
                
                case '-':
                    resultado = num1 - num2;
                    textBox1.Text = resultado.ToString();
                    break;

                case '/':
                    resultado = num1 / num2;
                    textBox1.Text = resultado.ToString();
                    break;

                case '*':
                    resultado = num1 * num2;
                    textBox1.Text = resultado.ToString();
                    break;

                    
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
