using SistemaHotel.Conexão_BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SistemaHotel.Model;

namespace SistemaHotel.Controller_DAO
{
    public class _03_NewHospd
    {
        private MySqlConnection conexao;
        public void AddHospd(string nome, string cpf, string endereço, string email)
        {

            try
            {
                conexao = new ConnectionFactory().GetConnection();
                conexao.Open();

                using (MySqlCommand comandoSql = new MySqlCommand("INSERT INTO tbl_hospede (nome, cpf, endereço, email) VALUES (@nome, @cpf, @endereço, @email)", conexao))
                {
                    // Substituindo os parâmetros
                    comandoSql.Parameters.AddWithValue("@nome", nome);
                    comandoSql.Parameters.AddWithValue("@cpf", cpf);
                    comandoSql.Parameters.AddWithValue("@endereço", endereço);
                    comandoSql.Parameters.AddWithValue("@email", email);

                    // Executando o comando
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Tratar exceções de forma apropriada
                Console.WriteLine($"Erro ao adicionar hospede: {ex.Message}");
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
