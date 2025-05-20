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
    public partial class FmPrincipal : Form
    {
        public FmPrincipal()
        {
            InitializeComponent();
        }

        private void btnHóspedes_Click(object sender, EventArgs e)
        {
            // abre a tela do cadastro de hospedes
            FmCadastroHodped cadastroHodped = new FmCadastroHodped();
            cadastroHodped.Show();
        }
    }
}
