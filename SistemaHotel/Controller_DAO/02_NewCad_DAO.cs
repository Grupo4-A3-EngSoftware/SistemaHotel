using SistemaHotel.Conexão_BD;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SistemaHotel.Controller_DAO
{
    public class _02_NewCad_DAO
    {
        private MySqlConnection conexao;

        public void AddAdm(string usuario, string senha)
        {
            try
            {
                // Obtendo a conexão com o banco de dados
                conexao = new ConnectionFactory().GetConnection();
                conexao.Open();

                // Preparando o comando SQL
                using (MySqlCommand comandoSql = new MySqlCommand("INSERT INTO tbl_login (usuario, senha) VALUES (@usuario, @senha)", conexao))
                {
                    // Substituindo os parâmetros
                    comandoSql.Parameters.AddWithValue("@usuario", usuario);
                    comandoSql.Parameters.AddWithValue("@senha", senha);

                    // Executando o comando
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Tratar exceções de forma apropriada
                Console.WriteLine($"Erro ao adicionar administrador: {ex.Message}");
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
