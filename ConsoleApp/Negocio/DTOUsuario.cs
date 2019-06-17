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

        public DTOUsuario(string login, string senha, string nome, int idade, string cpf)
        {
            Login = login;
            Senha = senha;
            Nome = nome;
            Idade = idade;
            cpf = CPF;
        }

        public string Login { get; set; }

        public string Senha { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }

        public string CPF { get; set; }
    }
}
