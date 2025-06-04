using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.Controller
{
    public class CalPagamento
    {
        public static double CalcPagamento(int dia,double valorQuarto)
        {            
            return dia * valorQuarto;
        }
    }
}
