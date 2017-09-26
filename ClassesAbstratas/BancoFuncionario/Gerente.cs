using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoFuncionario
{
    public class Gerente : Funcionario
    {
        public int Senha { get; set; }

        public bool Autentica(int senha)
        {
            if (senha == Senha)
            {
                return true;
            }

            return false;
        }

        public override double Bonificacao()
        {
            return 2000;
        }
    }
}
