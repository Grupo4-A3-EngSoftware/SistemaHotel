using SistemaHotel.Controller_DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.test
{
    internal class NewHospdTests
    {
        /*public class NewHospdTests
        {
            private readonly string _connectionString = "server=127.0.0.1;database=db_sistemahoteltest;user=root;password=.0Tu!>!8}~A6ig;";

            [Fact]
            public void AddHospd_ShouldInsertRecordIntoDatabase()
            {
                // Arrange
                var newHospd = new _03_NewHospd();
                var nome = "Test User";
                var cpf = "12345678900";
                var endereço = "Rua Teste, 123";
                var email = "testuser@example.com";

                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            
                            newHospd.GetType()
                                    .GetField("conexao", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                                    ?.SetValue(newHospd, connection);

                            
                            newHospd.AddHospd(nome, cpf, endereço, email);

                            
                            var query = "SELECT COUNT(*) FROM tbl_hospede WHERE nome = @nome AND cpf = @cpf";
                            using (var command = new MySqlCommand(query, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@nome", nome);
                                command.Parameters.AddWithValue("@cpf", cpf);
                                var count = Convert.ToInt32(command.ExecuteScalar());
                                Assert.Equal(1, count);
                            }

                            
                            transaction.Rollback();
                        }
                        catch
                        {
                            
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
        } */
    }
}
