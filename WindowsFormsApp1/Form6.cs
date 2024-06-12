using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double numero1 = double.Parse(textBox1.Text.Trim());
                double numero2 = double.Parse(textBox2.Text.Trim());
                double numero3 = double.Parse(textBox3.Text.Trim());

                double media = CalcularMedia(new double[] { numero1, numero2, numero3 });
                label1.Text = $"Média: {media}";
                label1.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                label1.Text = "Erro ao calcular a média.";
                label1.ForeColor = Color.Red;
            }
        }

        private double CalcularMedia(double[] numeros)
        {
            if (numeros == null || numeros.Length == 0)
            {
                throw new
                    ArgumentNullException("Não deixe espaços vazios ou com 0");
            }

            double soma = numeros.Sum();
            double media = soma / numeros.Length;
            return media;
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
