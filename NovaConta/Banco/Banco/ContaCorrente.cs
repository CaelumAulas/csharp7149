using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaCorrente : Conta
    {
        public override void Deposita(double valor)
        {
            base.Deposita(valor - 0.1);
        }

        public override void Saca(double valor)
        {
            base.Saca(valor + 0.05);
        }
    }
}
