using ConsoleApp.Controller;
using ConsoleApp.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Interface
{
    public class TelaInicial
    {
        public static void MenuPrincipal()
        {
            string CPF;
            string senha;
            string nome;
            int idade;

            int op = 0;

            while (true)
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
                        Console.WriteLine("Digite o CPF:");

                        CPF = Console.ReadLine();

                        Console.WriteLine("Digite a senha:");

                        senha = Console.ReadLine();

                        Console.WriteLine("Digite o nome:");

                        nome = Console.ReadLine();

                        Console.WriteLine("Digite a idade:");

                        idade = Convert.ToInt32(Console.ReadLine());

                        UsuarioController.CadastraUsuario(CPF, senha, nome, idade);
                        break;

                    case 2:
                        Console.WriteLine("Digite o login:");

                        cpf = Console.ReadLine();

                        Console.WriteLine("Digite a senha:");

                        senha = Console.ReadLine();

                        Console.Clear();
                        if (cpf == "admin" && senha == "admin")
                        {
                            Console.WriteLine("Bem-Vindo ao Sistema de Leilão");

                            DashboardAdmin.Dashboard();
                        }

                        if (UsuarioController.Login(login, senha))
                        {
                            Console.WriteLine("Bem-Vindo ao Sistema de Leilão");
                            DashboardCliente.Dashboard(cpf);
                        }

                        Console.WriteLine("Login ou senha inválido");

                        break;

                    default:
                        Console.WriteLine("Digite uma opção válida");
                        break;
                }
            }
        }

        private static void ExibirMenu()
        {
            Console.WriteLine("Selecione a operação\n" +
                  "1 - Cadastrar\n" +
                  "2 - Login");
        }
    }
}
