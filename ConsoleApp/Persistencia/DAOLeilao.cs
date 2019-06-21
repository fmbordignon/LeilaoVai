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
        public static List<DTOLeilao> ListaLeiloes;

        public static void Add(DTOLeilao leilao)
        {
            try
            {
                if (ListaLeiloes == null)
                {
                    ListaLeiloes = new List<DTOLeilao>();
                }

                ListaLeiloes.Add(leilao);
            }
            catch (Exception ex)
            {
                throw new Exception($"Houve um erro ao criar o leilao! {ex.Message}");
            }
        }

        public static void FecharLeilao(DTOLeilao leilao)
        {
            try
            {
                if (leilao.Status == IStatusLeilao.ABERTO)
                {
                    leilao.Status = IStatusLeilao.FECHADO;
                }
                else
                {
                    leilao.Status = IStatusLeilao.ABERTO;
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao cancelar Leilão! {e.Message}");
            }
        }

        public static List<DTOLeilao> GetLeiloesAbertos()
        {
            return ListaLeiloes?.Where(x => x.Status == IStatusLeilao.ABERTO).ToList() ?? new List<DTOLeilao>();
        }

        public static List<DTOLeilao> GetLeiloesFechados()
        {
            return ListaLeiloes?.Where(x => x.Status == IStatusLeilao.FECHADO).ToList() ?? new List<DTOLeilao>();
        }

        public static List<DTOLeilao> BuscarLeiloesAbertosUsuario(string cpf)
        {
            return ListaLeiloes?.Where(x => x.DonoLeilao.CPF == cpf && x.Status == IStatusLeilao.ABERTO).ToList() ?? new List<DTOLeilao>();
        }

        public static List<DTOLeilao> BuscarLeiloesFechadosUsuario(string cpf)
        {
            return ListaLeiloes?.Where(x => x.DonoLeilao.CPF == cpf && x.Status == IStatusLeilao.FECHADO).ToList() ?? new List<DTOLeilao>();
        }

    }
}
