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
        public static void CadastraUsuario(string login, string senha, string nome, int idade, string cpf)
        {
            var CPFUsuarios = DAOUsuario.BuscarTodosCPF();

            if (CPFUsuarios.Contains(cpf))
            {
                throw new Exception($"CPF já encontrado na base de dados: {cpf}");
            }

            DTOUsuario novoUsuario = new DTOUsuario(login, senha, nome, idade, cpf);

            DAOUsuario.Add(novoUsuario);
        }

        public static int Login(string login, string senha)
        {
            var listaUsuarios = DAOUsuario.BuscarTodosUsuarios();

            var usuarioEncontrado = listaUsuarios.Exists(x => x.Login == login && x.Senha == senha);

            if (usuarioEncontrado)
            {
                return 0;
            }
            else if (login.Equals("admin") && senha.Equals("admin"))
            {
                return 1;
            }
                throw new Exception($"Login ou Senha incorretos");
            }
           
        }




    
}
