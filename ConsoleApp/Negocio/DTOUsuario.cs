using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Negocio
{
    public class DTOUsuario
    {
        public DTOUsuario()
        {

        }

        public DTOUsuario(string cpf, string senha, string nome, int idade)
        {
            CPF = cpf;
            Senha = senha;
            Nome = nome;
            Idade = idade;
        }

        public string CPF { get; set; }

        public string Senha { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }
    }
}
