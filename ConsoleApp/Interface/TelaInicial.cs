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
        public void MenuPrincipal()
        {
            Console.WriteLine(@"Selecione a operação
                                 1 - Cadastrar
                                 2 - Login");

            int op = Convert.ToInt32(Console.ReadLine());

            string login;
            string senha;
            string nome;
            int idade;
            string CPF;

            switch (op)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Digite o login:");

                    login = Console.ReadLine();

                    Console.WriteLine("Digite a senha:");

                    senha = Console.ReadLine();

                    Console.WriteLine("Digite o nome:");

                    nome = Console.ReadLine();

                    Console.WriteLine("Digite a idade:");

                    idade = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite o CPF:");

                    CPF = Console.ReadLine();

                    UsuarioController.CadastraUsuario(login, senha, nome, idade, CPF);
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Digite o login:");

                    login = Console.ReadLine();

                    Console.WriteLine("Digite a senha:");

                    senha = Console.ReadLine();

                    Console.Clear();
                    if(UsuarioController.Login(login, senha) == 0){
                        Console.WriteLine("Bem-Vindo ao Sistema de Leilão");
                    }else if(UsuarioController.Login(login, senha) == 1){
                       DashboardAdmin.Dashboard();
                    }else{
                        Console.WriteLine("inválido");    
                    }



                    break;

                default:
                    Console.WriteLine("Digite uma opção válida");
                    break;
            }



        }
    }
}
