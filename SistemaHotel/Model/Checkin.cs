using Org.BouncyCastle.Crypto.Digests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaHotel.Model
{
    public class Checkin : Hospede
    {  
        public string Entrada { get; set; }

        public Checkin(string nome, string entrada, string cpf, string endereço, string email, string quarto) : base(nome, cpf, endereço, email, quarto)
        {
            Entrada = entrada;
        }
    }
}
