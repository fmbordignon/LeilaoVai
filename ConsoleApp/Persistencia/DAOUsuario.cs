using ConsoleApp.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Persistencia
{
    public static class DAOUsuario
    {
        public static List<DTOUsuario> ListaUsuarios;

        public static void Add(DTOUsuario usuario)
        {
            try
            {
                if (ListaUsuarios == null)
                {
                    ListaUsuarios = new List<DTOUsuario>();
                }

                ListaUsuarios.Add(usuario);
            }
            catch (Exception ex)
            {
                throw new Exception($"Houve um erro ao cadastrar o usuário! {ex.Message}");
            }
        }

        public static List<string> BuscarTodosCPF()
        {
            var listaCPF = ListaUsuarios.Select(x => x.CPF).ToList();

            return listaCPF;
        }

        public static List<DTOUsuario> BuscarTodosUsuarios()
        {
            return ListaUsuarios;
        }

    }
}
