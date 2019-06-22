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

        public static bool Login(string cpf, string senha)
        {
            var listaUsuarios = DAOUsuario.BuscarTodosUsuarios();

            var usuarioEncontrado = listaUsuarios.Exists(x => x.CPF == cpf && x.Senha == senha);

            return usuarioEncontrado;
        }

        public static DTOUsuario BuscarUsuarioPorCPF(string cpf)
        {
            return DAOUsuario.BuscarPorCPF(cpf);
        }

    }





}
