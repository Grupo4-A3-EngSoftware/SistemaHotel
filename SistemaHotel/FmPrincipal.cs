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
    public partial class FmPrincipal : Form
    {
        public FmPrincipal()
        {
            InitializeComponent();
        }

        private void btnHóspedes_Click(object sender, EventArgs e)
        {
            // abre a tela do cadastro de hospedes
            FmCadastroHodped cadastroHodped = new FmCadastroHodped();
            cadastroHodped.Show();
        }

        private void CarregaReservasDoDia()
        {
            // Aqui você pode adicionar a lógica para carregar as reservas do dia
            dtacheckin.Rows.Clear(); // Limpa as linhas existentes no DataGridView
            // simula a adição de dados ao DataGridView
            dtacheckin.Rows.Add("João", "quarto 101", "134265198709", "12/10/2023", "joão@gmail.com");

        }

        private void FmPrincipal_Load(object sender, EventArgs e)
        {
            CarregaReservasDoDia(); // Carrega as reservas do dia ao abrir o formulário
        }

        private void btngestaopagamentos_Click(object sender, EventArgs e)
        {
            FmGestaopagamentos gestaopagamento = new FmGestaopagamentos();
            gestaopagamento.ShowDialog(); // Abre o formulário de gestão de pagamentos como um diálogo modal
        }
    }
}
