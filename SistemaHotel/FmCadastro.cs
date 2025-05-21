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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
        }

        private void ComboBox1(object sender, EventArgs e)
        {
            // Aqui você pode adicionar a lógica para lidar com a seleção do ComboBox
            string tipoUsuario = comboBox1.SelectedItem.ToString();
            MessageBox.Show("Tipo de usuário selecionado: " + tipoUsuario);
        }
    }
}
