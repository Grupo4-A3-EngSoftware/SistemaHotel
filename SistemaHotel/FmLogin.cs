using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable; // Permite que o usuário redimensione manualmente
            user.BackColor = Color.Transparent; // Torna o fundo do label transparente
            senha.BackColor = Color.Transparent;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = "admin";
            string senha = "admin";

            if(txtusuario.Text == usuario && txtsenha.Text == senha)
            {
                MessageBox.Show("Login bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Aqui você pode abrir o formulário principal do sistema
                Form1 formPrincipal = new Form1();
                formPrincipal.Show();
                this.Hide(); // Esconde o formulário de login
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // chamado quando o botão de cadastro é clicado
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Cadastro Cadastro = new Cadastro(); // cria uma nova instancia do formulario de cdastro
            Cadastro.Show(); // abre o formulário de cadastro
            this.Hide();
        }
    }
}
