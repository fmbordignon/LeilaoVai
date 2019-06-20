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
            Console.WriteLine("Sitema Administrador");
            Console.WriteLine(@"Informações do Leilão
                                 1 - Leilões Ativos
                                 2 - Leilões Finalizados");

            int op = Convert.ToInt32(Console.ReadLine());


            switch (op)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Leilões Ativos");

                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Leilões Finalizados");

                    break;

                default:
                    Console.WriteLine("Digite uma opção válida");
                    break;
            }



        }
    }
}
