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
        private static List<DTOUsuario> ListaUsuarios;

        public static List<DTOUsuario> GetInstance()
        {
            if (ListaUsuarios == null)
            {
                ListaUsuarios = new List<DTOUsuario>();
            }

            return ListaUsuarios;
        }

        public static void Add(DTOUsuario usuario)
        {
            try
            {
                GetInstance().Add(usuario);
            }
            catch (Exception ex)
            {
                throw new Exception($"Houve um erro ao cadastrar o usuário! {ex.Message}");
            }
        }

        public static List<string> BuscarTodosCPF()
        {
            var listaCPF = GetInstance().Select(x => x.CPF).ToList() ?? new List<string>();

            return listaCPF;
        }

        public static List<DTOUsuario> BuscarTodosUsuarios()
        {
            return GetInstance();
        }

        public static DTOUsuario BuscarPorCPF(string cpf)
        {
            return GetInstance().FirstOrDefault(x => x.CPF == cpf) ?? new DTOUsuario();
        }

    }
}
