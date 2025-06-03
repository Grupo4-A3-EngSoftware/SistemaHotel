using MySql.Data.MySqlClient;
using SistemaHotel.Conexão_BD;
using SistemaHotel.Controller_DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void dtacheckin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtacheckout_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void but_Listar_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionFactory factory = new ConnectionFactory();
                using (MySqlConnection cn = factory.GetConnection())
                {
                    cn.Open();
                    MessageBox.Show("connectado");

                    var sqlquery = "SELECT c.id_checkin, c.entrada, c.saida, c.quarto, h.id_hospede, h.nome, h.cpf, h.endereço, h.email FROM tbl_checkin c JOIN tbl_hospede h ON c.id_hospede = h.id_hospede;";
                    
                    using (MySqlDataAdapter da = new MySqlDataAdapter(sqlquery, cn))
                    {
                        using(DataTable dt = new DataTable())
                        {   da.Fill(dt);
                            dtacheckin.DataSource = dt;
                        }
                    }
                }
            }
            catch 
            {
                MessageBox.Show("erro");
            }
        }

        private void butt_delete_Click(object sender, EventArgs e)
        {
            try
            {


                ConnectionFactory factory = new ConnectionFactory();
                if (dtacheckin.SelectedRows.Count > 0)
                {
                    // Obtém a linha selecionada
                    var rowIndex = dtacheckin.SelectedRows[0].Index;

                    // Obter o ID ou chave primária da linha selecionada e converte para string
                    var id = dtacheckin.Rows[rowIndex].Cells["id_hospede"].Value?.ToString();

                    if (id != null)
                    {
                        // Confirmar exclusão
                        var confirmResult = MessageBox.Show(
                            "Tem certeza que deseja excluir esta linha?",
                            "Confirmação",
                            MessageBoxButtons.YesNo
                        );

                        if (confirmResult == DialogResult.Yes)
                        {
                            // Excluir do banco de dados
                            {
                                _05_DelCheckin dell = new _05_DelCheckin();
                                dell.Del_checkin(id);
                            }

                            // Excluir do DataGridView
                            dtacheckin.Rows.RemoveAt(rowIndex);

                            MessageBox.Show("Linha excluída com sucesso!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ID não encontrado na linha selecionada.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecione uma linha para excluir.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir a linha: {ex.Message}");
            }
        }
    }
}

