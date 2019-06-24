using ConsoleApp.Interface;
using ConsoleApp.Negocio;
using ConsoleApp.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Controller
{
    public static class UsuarioController
    {
        public static int id = 0;

        public static void CadastraUsuario(string cpf, string senha, string nome, int idade)
        {
            var CPFUsuarios = DAOUsuario.BuscarTodosCPF();

            if (CPFUsuarios.Contains(cpf))
            {
                throw new Exception($"CPF já encontrado na base de dados: {cpf}");
            }

            DTOUsuario novoUsuario = new DTOUsuario(cpf, senha, nome, idade);

            DAOUsuario.Add(novoUsuario);
        }

        public static void Login(string cpf, string senha, tipoUsuario tipo)
        {
            switch (tipo) {
                case tipoUsuario.ADMIN:
                    Console.WriteLine("Bem-Vindo ao Sistema de Leilão");
                    DashboardAdmin.Dashboard();
                    break;

                case tipoUsuario.NORMAL:
                    var listaUsuarios = DAOUsuario.BuscarTodosUsuarios();

                    var usuarioEncontrado = listaUsuarios.Exists(x => x.CPF == cpf && x.Senha == senha);

                    if (usuarioEncontrado)
                    {
                        Console.WriteLine("Bem-Vindo ao Sistema de Leilão");
                        DashboardCliente.Dashboard(cpf);
                    }
                    else
                    {
                        Console.WriteLine("Senha inválida");
                    }
                    break;

            }
        }

        public static DTOUsuario BuscarUsuarioPorCPF(string cpf)
        {
            return DAOUsuario.BuscarPorCPF(cpf);
        }

        public static void BuscarTodosUsuarios()
        {
            List<DTOUsuario> usuarios = DAOUsuario.BuscarTodosUsuarios();
            foreach(DTOUsuario u in usuarios)
            {
                Console.WriteLine("Cliente: " + u.Nome + "\ncpf: " + u.CPF + "\n--------\n");
            }
        }

    }





}
