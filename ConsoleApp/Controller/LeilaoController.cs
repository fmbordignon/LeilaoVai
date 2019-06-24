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
        public static void AdicionarLeilao(int id, DTOUsuario dono, string nomeProduto)
        {
            DTOLeilao leilao = new DTOLeilao(id, dono, nomeProduto);
            dono.addLeilao(leilao);
            DAOLeilao.Add(leilao);
        }

        public static void addLance(decimal lance, DTOLeilao leilao, string cpf)
        {
            if (lance > leilao.MaiorLance)
            {
                leilao.MaiorLance = lance;
                leilao.CPFMaiorLance = cpf;

                Console.WriteLine("Lance efetuado");

            }
            else
            {
                Console.WriteLine("Seu lance é menor que o maior lance do leilao, operação cancelada");
            }

        }

        public static void fecharLeilao( int id, string cpf)
        {
            DAOLeilao.FecharLeilao(id, cpf);
        }
    }
}
