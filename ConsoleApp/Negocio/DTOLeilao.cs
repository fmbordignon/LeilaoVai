using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Negocio
{
    public class DTOLeilao
    {
        public DTOUsuario DonoLeilao { get; set; }

        public DTOProduto ProdutoLeilao { get; set; }

        public IStatusLeilao Status { get; set; }

        public decimal LanceMinimo { get; set; }

        public decimal MaiorLance { get; set; }

        public bool Ativo { get; set; }

        public List<DTOUsuario> Participantes { get; set; }
    }
}
