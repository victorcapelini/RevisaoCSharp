using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string Nome, string CPF) : base(Nome, CPF, 5000)
        {
        }

        public override double GetBonificacao()
        {
            return Salario * 0.3;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.3;
        }

    }
}
