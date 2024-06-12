namespace calculadora
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.senha = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.senhaincorreta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // senha
            // 
            this.senha.Location = new System.Drawing.Point(285, 210);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(100, 20);
            this.senha.TabIndex = 5;
            this.senha.TextChanged += new System.EventHandler(this.senha_TextChanged);
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(412, 210);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(100, 20);
            this.nome.TabIndex = 4;
            this.nome.TextChanged += new System.EventHandler(this.nome_TextChanged);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(412, 311);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 2;
            this.login.Text = "button1";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(300, 311);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 3;
            this.Cancelar.Text = "button2";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // senhaincorreta
            // 
            this.senhaincorreta.AutoSize = true;
            this.senhaincorreta.Location = new System.Drawing.Point(372, 250);
            this.senhaincorreta.Name = "senhaincorreta";
            this.senhaincorreta.Size = new System.Drawing.Size(0, 13);
            this.senhaincorreta.TabIndex = 6;
            this.senhaincorreta.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.senhaincorreta);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.login);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.senha);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Label senhaincorreta;
    }
}