using ConsoleApp.Controller;
using ConsoleApp.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Interface
{
    public class DashboardCliente
    {
        public static void Dashboard(string cpf)
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
                    Console.WriteLine("Digite uma opção numérica");
                    continue;
                }

                Console.Clear();

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Leilões abertos");
                        leiloes = LeilaoController.BuscarLeiloesAbertosUsuario(cpf);
                        Console.WriteLine(string.Join(", ", leiloes));
                        break;

                    case 2:
                        Console.WriteLine("Leilões fechados");
                        leiloes = LeilaoController.BuscarLeiloesFechadosUsuario(cpf);
                        Console.WriteLine(string.Join(", ", leiloes));
                        break;

                    case 0:
                        break;

                    default:
                        Console.WriteLine("Digite uma opção válida");
                        break;
                }

                
            } while (op != 0);

            TelaInicial.MenuPrincipal();
        }

        private static void ExibirMenu()
        {
            Console.WriteLine("Sistema usuário\n");
            Console.WriteLine("Informações do Leilão\n" +
                               "1 - Leilões abertos\n" +
                               "2 - Leilões fechados\n" +
                               "0 - Voltar");
        }

    }
}
