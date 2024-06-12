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
    public partial class Form2 : Form
    {
        private const string
                senhaCorreta = "12345";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string senhaT = senha.Text;
            if (senhaT == senhaCorreta)
            {
                label1.Text = "Senha Correta";
            }
        }

        private void nome_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void senha_TextChanged(object sender, EventArgs e)
        {
            this.senha.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
