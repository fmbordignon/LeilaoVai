using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Negocio
{
    public class DTOUsuario
    {
        List<DTOLeilao> leiloes;
        public DTOUsuario()
        {

        }

        public DTOUsuario(string cpf, string senha, string nome, int idade)
        {
            CPF = cpf;
            Senha = senha;
            Nome = nome;
            Idade = idade;
            leiloes = new List<DTOLeilao>();
        }

        public string CPF { get; set; }

        public string Senha { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }
        
        public void addLeilao(DTOLeilao leilao)
        {
            leiloes.Add(leilao);
        }

        public List<DTOLeilao> getLeiloes()
        {
            return leiloes;
        }
        
    }
}
