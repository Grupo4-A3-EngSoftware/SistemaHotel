using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.Model
{
    public class Login01
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }


        public Login01(string usuario, string senha)
        {
            Usuario = usuario;
            Senha = senha;
        }
    }
}
