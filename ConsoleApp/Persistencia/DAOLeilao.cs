using ConsoleApp.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Persistencia
{
    public static class DAOLeilao
    {
        private static List<DTOLeilao> ListaLeiloes;

        public static List<DTOLeilao> GetInstance()
        {
            if (ListaLeiloes == null)
            {
                ListaLeiloes = new List<DTOLeilao>();
            }

            return ListaLeiloes;
        }

        public static void Add(DTOLeilao leilao)
        {
            try
            {
                GetInstance().Add(leilao);
            }
            catch (Exception ex)
            {
                throw new Exception($"Houve um erro ao criar o leilao! {ex.Message}");
            }
        }

        public static bool FecharLeilao(int id, string cpf)
        {
            var leilao = GetInstance().FirstOrDefault(x => x.IdLeilao == id);

            if (leilao == null)
            {
                return false;
            }

            if (leilao.DonoLeilao.CPF != cpf)
            {
                throw new Exception($"Ocorreu um erro, não é possível fechar um leilão que não é seu. CPF do dono é {leilao.DonoLeilao.CPF} e o que tentou fechar o leilão foi {cpf}.");
            }

            leilao.Status = IStatusLeilao.FECHADO;

            return true;
        }

        public static List<DTOLeilao> GetLeiloesAbertos()
        {
            return GetInstance().Where(x => x.Status == IStatusLeilao.ABERTO).ToList();
        }

        public static List<DTOLeilao> GetLeiloesFechados()
        {
            return GetInstance().Where(x => x.Status == IStatusLeilao.FECHADO).ToList();
        }

        public static List<DTOLeilao> BuscarLeiloesAbertosUsuario(string cpf)
        {
            return GetInstance().Where(x => x.DonoLeilao.CPF == cpf && x.Status == IStatusLeilao.ABERTO).ToList();
        }

        public static List<DTOLeilao> BuscarLeiloesFechadosUsuario(string cpf)
        {
            return GetInstance().Where(x => x.DonoLeilao.CPF == cpf && x.Status == IStatusLeilao.FECHADO).ToList();
        }

        public static DTOLeilao BuscarLeilaoPorId(int id)
        {
            return GetInstance().FirstOrDefault(x => x.IdLeilao == id);
        }

    }
}
