using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography; // Para usar o SHA256
using SistemaHotel.Controller_DAO;



namespace SistemaHotel
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            this.WindowState = FormWindowState.Maximized;
        }

        private void ComboBox1(object sender, EventArgs e)
        {
            // Aqui você pode adicionar a lógica para lidar com a seleção do ComboBox
            string tipoUsuario = comboBox1.SelectedItem.ToString();
            MessageBox.Show("Tipo de usuário selecionado: " + tipoUsuario);
        }

        private void btnconta_Click(object sender, EventArgs e)
        {
            if (txtsenhaCadastro.Text == txtconfirmaSenha.Text)
            {
                MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Aqui você pode adicionar a lógica para salvar os dados do usuário no banco de dados ou em um arquivo
                
                string senha = txtsenhaCadastro.Text;
                string usuario = txtusuarioCadastro.Text;
                _02_NewCad_DAO cadastro = new _02_NewCad_DAO();
                cadastro.AddAdm(usuario,senha);


            }

            else
            {
                MessageBox.Show("As senhas não coincidem. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtnome_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnome.Text))
            {
                string senhaCriptografada = GerarHashSHA256(txtsenhaCadastro.Text); // Criptografa a senha
                txtnome.Focus();
            }
            else
            {
                errorProvider1.SetError(txtnome, ""); // Limpa o erro se o campo estiver preenchido corretamente
            }
        }

        private void txtusuarioCadastro_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtusuarioCadastro.Text))
            {
                MessageBox.Show("O campo Usuário é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtusuarioCadastro.Focus();
            }
            else
            {
                errorProvider1.SetError(txtusuarioCadastro, ""); // Limpa o erro se o campo estiver preenchido corretamente
            }
        }

        private string GerarHashSHA256(string senha)
        {
            // Cria uma instância do SHA256 para criptografar a senha
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void txtusuarioCadastro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
