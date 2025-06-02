using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.Model
{
    public class Hospede
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereço { get; set; }
        public string Email { get; set; }
    
        public Hospede(string nome, string cpf, string endereço, string email, string quarto)
        {
            Nome = nome;
            Cpf = cpf;
            Endereço = endereço;
            Email = email;  
        }
    }
}
