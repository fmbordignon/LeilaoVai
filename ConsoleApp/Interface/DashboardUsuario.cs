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
        public static int id = 0;

        public static void Dashboard(string cpf)
        {
            List<DTOLeilao> leiloes = new List<DTOLeilao>();
            int op = 0;

            string nomeProduto;
            decimal lance;
            int idLeilaoEscolhido;
            DTOLeilao leilao;
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
                        Console.WriteLine(string.Join("----------\n", leiloes));
                        break;

                    case 2:
                        Console.WriteLine("Leilões fechados");
                        leiloes = LeilaoController.BuscarLeiloesFechadosUsuario(cpf);
                        Console.WriteLine(string.Join("----------\n", leiloes));
                        break;

                    case 3:
                        Console.WriteLine("Criar leilão");
                        Console.WriteLine("Qual o produto leiloado?");
                        nomeProduto = Console.ReadLine();

                        leilao = new DTOLeilao(++id, UsuarioController.BuscarUsuarioPorCPF(cpf), nomeProduto);

                        LeilaoController.AdicionarLeilao(leilao);

                        break;

                    case 4:
                        Console.WriteLine("Digite o id do leilão que deseja dar o lance");

                        leiloes = LeilaoController.BuscarLeiloesAbertos();
                        Console.WriteLine(string.Join("----------\n", leiloes));

                        idLeilaoEscolhido = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o lance que deseja dar");

                        lance = Convert.ToDecimal(Console.ReadLine());

                        leilao = LeilaoController.BuscarLeilaoPorId(idLeilaoEscolhido);

                        if (lance > leilao.MaiorLance)
                        {
                            leilao.MaiorLance = lance;
                            leilao.CPFMaiorLance = cpf;

                            break;
                        }

                        Console.WriteLine("Seu lance é menor que o maior lance do leilao, operação cancelada");

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
                               "3 - Criar leilão\n" +
                               "4 - Dar lance\n" +
                               "0 - Voltar");
        }

    }
}
