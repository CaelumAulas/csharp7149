using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoFuncionario
{
    public class SistemaInterno
    {

        public void Login(IAutenticavel a)
        {
            int senha = 0;// pega senha do teclado
            if(a.Autentica(senha))
            {
                // mostra tela do sistema
            }
        }
    }
}
