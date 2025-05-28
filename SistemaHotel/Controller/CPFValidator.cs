using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel
{
    public class CPFValidator
    {
        public static bool ValidarCPF(string cpf)
        {
            // Remove caracteres não numéricos
            cpf = new string(cpf.Where(char.IsDigit).ToArray());
            // Verifica se o CPF tem 11 dígitos
            if (cpf.Length != 11)
                return false;
            // Verifica se todos os dígitos são iguais (ex: 111.111.111-11)
            if (cpf.Distinct().Count() == 1)
                return false;
            // Valida o primeiro dígito verificador
            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(cpf[i].ToString()) * (10 - i);
            int resto = soma % 11;
            int digito1 = resto < 2 ? 0 : 11 - resto;
            if (digito1 != int.Parse(cpf[9].ToString()))
                return false;
            // Valida o segundo dígito verificador
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(cpf[i].ToString()) * (11 - i);
            resto = soma % 11;
            int digito2 = resto < 2 ? 0 : 11 - resto;
            if (digito2 != int.Parse(cpf[10].ToString()))
                return false;
            return true;
        }
    }
}
