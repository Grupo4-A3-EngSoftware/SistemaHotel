using MySql.Data.MySqlClient;
using SistemaHotel.Conexão_BD;
using SistemaHotel.Controller_DAO;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
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

            // Limpa os campos de texto
            txtnomehospede.Text = "";
            txtendereco.Text = "";
            txtemail.Text = "";
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {

            string nome = txtnomehospede.Text;
            string email = txtemail.Text;
            string endereço = txtendereco.Text;
            string cpf = maskedTextBoxCPF.Text;

            // Valida o CPF
            if (!CPFValidator.ValidarCPF(cpf))
            {
                MessageBox.Show("CPF inválido. Por favor, verifique e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _03_NewHospd cadastro = new _03_NewHospd();
            cadastro.AddHospd(nome, cpf, endereço, email);

            MessageBox.Show("Cadastro salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void maskedTextBoxCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void buttListar_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionFactory factory = new ConnectionFactory();
                using (MySqlConnection cn = factory.GetConnection())
                {
                    cn.Open();
                    
                    var sqlquery = "select * from tbl_hospede;";

                    using (MySqlDataAdapter da = new MySqlDataAdapter(sqlquery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            DGV_hpds.DataSource = dt;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("erro");
            }
        }

        private void FmCadastroHodped_Load(object sender, EventArgs e)
        {

        }

        private void butt_del_Click(object sender, EventArgs e)
        {

            try
            {


                ConnectionFactory factory = new ConnectionFactory();
                if (DGV_hpds.SelectedRows.Count > 0)
                {
                    // Obtém a linha selecionada
                    var rowIndex = DGV_hpds.SelectedRows[0].Index;

                    // Obter o ID ou chave primária da linha selecionada e converte para string
                    int id = Convert.ToInt32(DGV_hpds.Rows[rowIndex].Cells["id_hospede"].Value);

                    if (id != 0)
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
                                _04_Del_hspd dell = new _04_Del_hspd();
                                dell.Del_hspd(id);
                            }

                            // Excluir do DataGridView
                            DGV_hpds.Rows.RemoveAt(rowIndex);

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

        private void butt_checkin_Click(object sender, EventArgs e)
        {
            if (DGV_hpds.SelectedCells.Count > 0) // Certifica-se de que a linha seja válida
            {
                var selectedCell = DGV_hpds.SelectedCells[0];
                var rowIndex = selectedCell.RowIndex; // Obter índice da linha selecionada
                try
                {
                    // Obter os valores atualizados
                    var row = DGV_hpds.Rows[rowIndex];
                    var id = row.Cells["id_hospede"].Value?.ToString();
                    
                    // Atualizar o banco de dados
                    if (!string.IsNullOrEmpty(id))
                    {
                        ConnectionFactory factory = new ConnectionFactory();
                        using (MySqlConnection connection = factory.GetConnection())
                        {
                            connection.Open();
                            string query = "INSERT INTO tbl_checkin (id_hospede) VALUES (@Id)"; 

                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@Id", id);
                                command.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("tabela relacionada");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao fundir tabela: {ex.Message}");
                }

            }
        }
    }
}

