using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Conta
    {
        
        public Cliente Titular { get; set; }
        public double Saldo { get; private set; }
        public int Numero { get; set; }

        public void Deposita(double valor)
        {
            Saldo += valor;
        }

        public void Saca(double valor)
        {
            Saldo -= valor;
        }
    }
}
