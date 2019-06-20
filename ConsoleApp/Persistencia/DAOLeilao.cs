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
         public static List<DTOLeilao> ListaLeiloesAtivo;
        public static List<DTOLeilao> ListaLeiloesFinalizados;

         public static void Add(DTOLeilao leilao)
        {
            try
            {
                if (ListaLeiloesAtivo == null)
                {
                    ListaLeiloesAtivo = new List<DTOLeilao>();
                }

                ListaLeiloesAtivo.Add(leilao);
            }
            catch (Exception ex)
            {
                throw new Exception($"Houve um erro ao criar o leilao! {ex.Message}");
            }            
        }

        public static void fecharLeilao(DTOLeilao leilao){
            try{
                DTOLeilao leilaoFechado = ListaLeiloesAtivo.Remove(leilao);
                ListaLeiloesFinalizados.Add(leilaoFechado);
            }catch (Exception e){
                throw new Exception($"Erro ao cancelar Leilão! {e.Message}");
            }
        }

        public static List<DTOLeilao> getLeiloesAtivos(){
            return ListaLeiloesAtivo;
        }

          public static List<DTOLeilao> getLeiloesFechados(){
            return ListaLeiloesFinalizados;
        }



    }
}
