using MySql.Data.MySqlClient;
using SistemaHotel.Conexão_BD;
using SistemaHotel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace SistemaHotel.Controller_DAO
{
    public class _01_Login_DAO
    {
        private MySqlConnection conexao;

       

        public bool LoginCheck(Login01 G)
        {
            bool check = false;

            try
            {
                // Obtendo a conexão com o banco de dados
                conexao = new ConnectionFactory().GetConnection();
                conexao.Open();

                // Preparando o comando SQL
                using (MySqlCommand comando_sql = new MySqlCommand("SELECT * FROM tbl_login WHERE usuario = @usuario AND senha = @senha", conexao))
                {
                    // Substituindo os parâmetros
                    comando_sql.Parameters.AddWithValue("@usuario", G.Usuario);
                    comando_sql.Parameters.AddWithValue("@senha", G.Senha);

                    // Executando o comando e obtendo o resultado
                    using (MySqlDataReader resultado = comando_sql.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            check = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Tratar exceções de forma apropriada
                Console.WriteLine($"Erro: {ex.Message}");
            }
            finally
            {
                // Garantindo que a conexão seja fechada
                if (conexao != null && conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }

            return check;
        }
    }
}
