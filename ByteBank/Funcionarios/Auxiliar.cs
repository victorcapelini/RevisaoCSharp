﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string nome, string cpf) : base(nome, cpf, 3564)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.2;
        }
    }
}