using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoFuncionario
{
    public interface IAutenticavel
    {
        bool Autentica(int senha);
    }
}
