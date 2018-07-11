﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(string Nome, string CPF, double Salario)
        {
            this.Nome = Nome;
            this.CPF = CPF;
            this.Salario = Salario;
            TotalDeFuncionarios++;
        }

        public abstract double GetBonificacao();

        public abstract void AumentarSalario();
    }
}
