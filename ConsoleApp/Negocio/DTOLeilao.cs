using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Negocio
{
    public class DTOLeilao
    {
        public int IdLeilao { get; set; }

        public DTOUsuario DonoLeilao { get; set; }

        public DTOProduto ProdutoLeilao { get; set; }

        public IStatusLeilao Status { get; set; }

        public string NomeMaiorLance;

        public decimal MaiorLance;

        public override string ToString()
        {
            return $"Id leilão: {IdLeilao}\n" +
                   $"Produto: {ProdutoLeilao.Nome}\n" +
                   $"Status: {Status}\n" +
                   $"Maior lance: {MaiorLance}\n";
        }
    }
}
