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

                        LeilaoController.AdicionarLeilao(++id, UsuarioController.BuscarUsuarioPorCPF(cpf), nomeProduto);

                        break;

                    case 4:
                        Console.WriteLine("Digite o id do leilão que deseja dar o lance");

                        leiloes = LeilaoController.BuscarLeiloesAbertos();
                        Console.WriteLine(string.Join("----------\n", leiloes));

                        idLeilaoEscolhido = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o lance que deseja dar");

                        lance = Convert.ToDecimal(Console.ReadLine());

                        leilao = LeilaoController.BuscarLeilaoPorId(idLeilaoEscolhido);

                        LeilaoController.addLance(lance, leilao, cpf);
                        

                        break;
                        


                        break;
                    case 5:
                        Console.WriteLine("Leilões abertos");
                        leiloes = LeilaoController.BuscarLeiloesAbertosUsuario(cpf);
                        Console.WriteLine(string.Join("----------\n", leiloes));

                        Console.WriteLine("Digite ID do leilão que deseja fechar\n Digite 0 para voltar");
                        idLeilaoEscolhido = Convert.ToInt32(Console.ReadLine());
                        if (idLeilaoEscolhido == 0)
                        {
                            break;
                        }
                        else
                        {
                            leilao = LeilaoController.BuscarLeilaoPorId(idLeilaoEscolhido);
                            LeilaoController.fecharLeilao(leilao);
                            Console.WriteLine("Leilao Fechado");
                        }
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
                               "5 - Fechar Leilão\n" +
                               "0 - Voltar");
        }

    }
}
