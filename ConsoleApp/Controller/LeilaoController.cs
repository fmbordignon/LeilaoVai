using ConsoleApp.Negocio;
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
        public static List<DTOLeilao> BuscarLeiloesAbertos()
        {
            return DAOLeilao.GetLeiloesAbertos();
        }

        public static List<DTOLeilao> BuscarLeiloesFechados()
        {
            return DAOLeilao.GetLeiloesFechados();
        }

        public static List<DTOLeilao> BuscarLeiloesAbertosUsuario(string cpf)
        {
            return DAOLeilao.BuscarLeiloesAbertosUsuario(cpf);
        }

        public static List<DTOLeilao> BuscarLeiloesFechadosUsuario(string cpf)
        {
            return DAOLeilao.BuscarLeiloesFechadosUsuario(cpf);
        }

        public static DTOLeilao BuscarLeilaoPorId(int id)
        {
            return DAOLeilao.BuscarLeilaoPorId(id);
        }

        public static void AdicionarLeilao(DTOLeilao leilao)
        {
            DAOLeilao.Add(leilao);
        }
    }
}
