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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
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
            }
            else
            {
                MessageBox.Show("As senhas não coincidem. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
