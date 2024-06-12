using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        private const string
            Placeholder2Text = "Nome";
        private const string
            PlaceholderText = "Digite sua Senha";
        private const string
            senhaCorreta = "12345";
      
        public Form3()
        {
            InitializeComponent();
            InitializePlaceholder();
            InitializePlaceholder2();
        }

        private void
            InitializePlaceholder2()
        {
            nome.Text = Placeholder2Text;
            nome.ForeColor = Color.Gray;

            nome.GotFocus += RemovePlaceholder2;
            nome.LostFocus += SetPlaceholder2;
        }

        private void
             InitializePlaceholder()
        {
            senha.Text = PlaceholderText;
            senha.ForeColor = Color.Gray;

            senha.GotFocus += RemovePlaceholder;
            senha.LostFocus += SetPlaceholder;
        }

        private void RemovePlaceholder2(object sender, EventArgs e)
        {
            if (nome.Text == Placeholder2Text)
            {
                nome.Text = "";
                nome.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholder2(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nome.Text))
            {
                nome.PasswordChar = '\0';
                nome.Text = Placeholder2Text;
                nome.ForeColor = Color.Gray;
            }
        }
        private void RemovePlaceholder(object sender, EventArgs e) 
        {
            if (senha.Text == PlaceholderText)
            {
                senha.Text = "";
                senha.ForeColor = Color.Black;
                this.senha.PasswordChar = '*';
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(senha.Text))
            {
                senha.PasswordChar = '\0';
                senha.Text = PlaceholderText;
                senha.ForeColor = Color.Gray;
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void nome_TextChanged(object sender, EventArgs e)
        {
           
        }
        
        private void senha_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string senhaT = senha.Text;
            if (senhaT == senhaCorreta)
            {
                Form1 form1 = new Form1();
                this.Hide();
                form1.Show();
            }

            else
            {
                label1.Text = "Senha Incorreta";
                label1.ForeColor = Color.Red;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
