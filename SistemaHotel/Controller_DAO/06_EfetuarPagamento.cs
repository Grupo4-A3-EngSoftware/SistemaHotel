using MySql.Data.MySqlClient;
using Mysqlx.Connection;
using SistemaHotel.Conexão_BD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel.Controller_DAO
{
    public class _06_EfetuarPagamento
    {
        
        public void EfetuarPagamento(string id, double ValorPago)
        {
            //atualiza a linha escolhida adicionando "VALORPAGO" á coluna "PAGAMENTO"
            try
            {

                ConnectionFactory factory = new ConnectionFactory();
                using (MySqlConnection connection = factory.GetConnection())
                {
                    connection.Open();
                    string query = $"UPDATE tbl_checkin SET pagamento = @Value WHERE id_checkin = @Id";

                    // Mensagens de depuração
                    MessageBox.Show($"ID: {id}, Value: {ValorPago}");

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Value", ValorPago);
                        command.Parameters.AddWithValue("@Id", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar o registro: {ex.Message}");
            }
        }
    }
}
