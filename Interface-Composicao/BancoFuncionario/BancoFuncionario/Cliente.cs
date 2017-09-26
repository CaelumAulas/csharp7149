using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoFuncionario
{
    class Cliente : IAutenticavel
    {
        private LogicaSenha logica = new LogicaSenha();

        public string Nome { get; set; }

        public int Senha
        {
            get => logica.Senha;
            set => logica.Senha = value;
        }

        public bool Autentica(int senha)
        {
            // delegate
            return logica.Autentica(senha);
        }
    }
}
