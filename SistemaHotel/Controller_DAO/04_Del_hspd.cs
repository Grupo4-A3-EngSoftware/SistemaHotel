using MySql.Data.MySqlClient;
using SistemaHotel.Conexão_BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.Controller_DAO
{
    public class _04_Del_hspd
    {
        private MySqlConnection conexao;

        public void Del_hspd(string id)
        {
            try
            {
                // Obtendo a conexão com o banco de dados
                conexao = new ConnectionFactory().GetConnection();
                conexao.Open();

                // Preparando o comando SQL
                using (MySqlCommand comandoSql = new MySqlCommand("DELETE FROM tbl_hospede WHERE id_hospede = @Id", conexao))
                {
                    // Substituindo os parâmetros
                    comandoSql.Parameters.AddWithValue("@Id", id);
                    
                    // Executando o comando
                    comandoSql.ExecuteNonQuery();
                }
            }





            catch (Exception ex)
            {
                // Tratar exceções de forma apropriada
                Console.WriteLine($"Erro ao deletar {ex.Message}");
            }
            finally
            {
                // Garantindo que a conexão seja fechada
                if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
        }








    }
}
