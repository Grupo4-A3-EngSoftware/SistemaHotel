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
    public partial class FmCadastroHodped : Form
    {
        public FmCadastroHodped()
        {
            InitializeComponent();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            // Habilita os campos de texto para o usuário preencher
            txtnome.Enabled = true;
            txtendereco.Enabled = true;
            txtemail.Enabled = true;

            // Limpa os campos de texto
            txtnome.Text = "";
            txtendereco.Text = "";
            txtemail.Text = "";
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastro salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Aqui você pode adicionar a lógica para salvar os dados do hóspede no banco de dados ou em um arquivo
            // Por enquanto, apenas desabilitamos os campos de texto
            txtnome.Enabled = false;
            txtendereco.Enabled = false;
            txtemail.Enabled = false;
        }
    }
}
