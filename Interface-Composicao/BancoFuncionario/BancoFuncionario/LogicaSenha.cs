using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoFuncionario
{
    public class LogicaSenha
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
    }
}
