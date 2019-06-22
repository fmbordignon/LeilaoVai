using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Negocio
{
    public class DTOLeilao
    {
        public DTOLeilao()
        {

        }

        public DTOLeilao(int id, DTOUsuario dono, string produto)
        {
            IdLeilao = id;
            DonoLeilao = dono;
            ProdutoLeilao = produto;

            Status = IStatusLeilao.ABERTO;
        }

        public int IdLeilao { get; set; }

        public DTOUsuario DonoLeilao { get; set; }

        public string ProdutoLeilao { get; set; }

        public IStatusLeilao Status { get; set; }

        public string CPFMaiorLance;

        public decimal MaiorLance;

        public override string ToString()
        {
            return $"Id leilão: {IdLeilao}\n" +
                   $"Produto: {ProdutoLeilao}\n" +
                   $"Status: {Status}\n" +
                   $"Maior lance: {MaiorLance}\n";
        }
    }
}
