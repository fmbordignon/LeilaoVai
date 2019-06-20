using ConsoleApp.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Controller
{
    public class LeilaoController
    {
        public void getListaLeiloesAtivos()
        {
            List<DTOLeilao> leiloes = DAOLeilao.getLeiloesAtivos();

            foreach (DTOLeilao e in leiloes)
            {
                Console.WriteLine(e.ToString());

            }
        }

        
    }
}
