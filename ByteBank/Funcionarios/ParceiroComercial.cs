using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; private set; }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
