using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Designer("Design", "111.111.111-58");
            FuncionarioAutenticavel diretor = new Diretor("Diretor", "549.884.444-57");

            diretor.Senha = "123";

            SistemaInterno sistemaInterno = new SistemaInterno();

            sistemaInterno.Logar(diretor,"123");

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
