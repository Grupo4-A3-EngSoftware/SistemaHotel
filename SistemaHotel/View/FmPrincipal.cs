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
                    
                    var sqlquery = "SELECT c.id_checkin, c.pagamento, c.entrada, c.saida, c.quarto, h.nome, h.cpf, h.endereço, h.email FROM tbl_checkin c JOIN tbl_hospede h ON c.id_hospede = h.id_hospede;";

                    using (MySqlDataAdapter da = new MySqlDataAdapter(sqlquery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
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
                    var id = dtacheckin.Rows[rowIndex].Cells["id_checkin"].Value?.ToString();

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
               
        private void butt_alterar_Click(object sender, EventArgs e)
        {

            if (dtacheckin.SelectedCells.Count > 0) // Certifique-se de que há uma célula selecionada
            {
                var selectedCell = dtacheckin.SelectedCells[0]; // Obter a primeira célula selecionada
                var rowIndex = selectedCell.RowIndex; // Índice da linha selecionada
                var columnIndex = selectedCell.ColumnIndex; // Índice da coluna selecionada

                try
                {
                    // Obter os valores atualizados
                    var row = dtacheckin.Rows[rowIndex];
                    var id = row.Cells["id_checkin"].Value?.ToString(); // Substitua "id_checkin" pela chave primária da tabela
                    var columnName = dtacheckin.Columns[columnIndex].Name; // Nome da coluna
                    var newValue = row.Cells[columnIndex].Value?.ToString(); // Novo valor

                    // Se a coluna for uma data, converta para o formato MySQL
                    string formattedValue = null;
                    if ((columnName == "entrada" || columnName == "saida") && DateTime.TryParse(newValue, out DateTime parsedDate))
                    {
                        formattedValue = parsedDate.ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        formattedValue = newValue;
                    }

                    // Atualizar o banco de dados
                    if (!string.IsNullOrEmpty(id) && !string.IsNullOrEmpty(formattedValue))
                    {
                        ConnectionFactory factory = new ConnectionFactory();
                        using (MySqlConnection connection = factory.GetConnection())
                        {
                            connection.Open();
                            string query = $"UPDATE tbl_checkin SET {columnName} = @Value WHERE id_checkin = @Id";                                                   
                           

                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@Value", formattedValue);
                                command.Parameters.AddWithValue("@Id", id);
                                command.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Registro atualizado com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao atualizar o registro: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma célula antes de clicar no botão.");
            }
        }
    }
}




