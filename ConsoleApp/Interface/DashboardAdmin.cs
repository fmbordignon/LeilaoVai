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
            Console.WriteLine(@"Informa��es do Leil�o
                                 1 - Leil�es Ativos
                                 2 - Leil�es Finalizados");

            int op = Convert.ToInt32(Console.ReadLine());


            switch (op)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Leil�es Ativos");

                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Leil�es Finalizados");

                    break;

                default:
                    Console.WriteLine("Digite uma op��o v�lida");
                    break;
            }



        }
    }
}
