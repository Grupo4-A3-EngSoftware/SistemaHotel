using MySql.Data.MySqlClient;
using SistemaHotel.Conexão_BD;
using SistemaHotel.Controller;
using SistemaHotel.Controller_DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel
{
    public partial class FmGestaopagamentos : Form
    {
        public FmGestaopagamentos()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionFactory factory = new ConnectionFactory();
                using (MySqlConnection cn = factory.GetConnection())
                {
                    cn.Open();
                    MessageBox.Show("connectado");

                    var sqlquery = "SELECT c.id_checkin, c.pagamento, c.entrada, c.saida, c.quarto, h.nome, h.cpf, h.endereço, h.email FROM tbl_checkin c JOIN tbl_hospede h ON c.id_hospede = h.id_hospede;";

                    using (MySqlDataAdapter da = new MySqlDataAdapter(sqlquery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("erro");
            }
        }

        private void btnpagamento_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(txt_diaria.Text);
            int tipodequarto = comboBox2.SelectedIndex + 1;
            double valorquarto = 0;
            switch(tipodequarto)
            {
                case 1:
                    valorquarto = 100; break;
                    case 2:
                    valorquarto = 170; break;
                    case 3:
                    valorquarto = 400; break;
            }
            var calPagamento = new CalPagamento();
            double valor = calPagamento.CalcPagamento(dia, valorquarto);
            try
            {
                ConnectionFactory factory = new ConnectionFactory();
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var rowIndex = dataGridView1.SelectedRows[0].Index;
                    var id = dataGridView1.Rows[rowIndex].Cells["id_checkin"].Value?.ToString();


                    _06_EfetuarPagamento pag = new _06_EfetuarPagamento();
                    pag.EfetuarPagamento(id, valor);
                }
                else
                {
                    MessageBox.Show("Por favor, selecione uma linha para excluir.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao efetuar pagamento: {ex.Message}");
            }
        }
        }
    }


