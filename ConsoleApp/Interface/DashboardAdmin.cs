using ConsoleApp.Controller;
using ConsoleApp.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Interface
{
    public static class DashboardAdmin
    {
        public static void Dashboard()
        {
            List<DTOLeilao> leiloes = new List<DTOLeilao>();
            int op = 0;

            do
            {
                ExibirMenu();

                try
                {
                    op = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Digite uma op��o num�rica");
                    continue;
                }

                Console.Clear();

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Leil�es abertos");
                        leiloes = LeilaoController.BuscarLeiloesAbertos();
                        Console.WriteLine(string.Join(", ", leiloes));
                        break;

                    case 2:
                        Console.WriteLine("Leil�es fechados");
                        leiloes = LeilaoController.BuscarLeiloesFechados();
                        Console.WriteLine(string.Join(", ", leiloes));
                        break;

                    case 0:
                        break;

                    default:
                        Console.WriteLine("Digite uma op��o v�lida");
                        break;
                }
            } while (op != 0);

            TelaInicial.MenuPrincipal();

        }

        private static void ExibirMenu()
        {
            Console.WriteLine("Sistema Administrador\n");
            Console.WriteLine("Informa��es do Leil�o\n" +
                               "1 - Leil�es abertos\n" +
                               "2 - Leil�es fechados\n" +
                               "0 - Voltar");
        }
    }
}
