using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SistemaHotel.Conexão_BD
{
    public class ConnectionFactory
    {
        public MySqlConnection GetConnection()
        {
            try
            {
                // Substitua a string de conexão pelos detalhes corretos do seu banco de dados
                string connectionString = "Server=localhost;Port=3306;Database=db_sistemahotel;User=root;Password=.0Tu!>!8}~A6ig;";
                return new MySqlConnection(connectionString);
            }
            catch (MySqlException excecao)
            {
                throw new Exception("Erro ao conectar ao banco de dados.", excecao);
            }
        }
    }
}
