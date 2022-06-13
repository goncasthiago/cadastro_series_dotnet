using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cadastro_series_dotnet.Interfaces;

namespace cadastro_series_dotnet.Classes
{
    public class SerieRepositorio : IRepositorio<Series>
    {

    private List<Series> listaSerie = new List<Series>();

        public void Atualiza(int Id, Series entidade)
        {
            listaSerie[Id] = entidade;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Exclui();
        }

        public void Insere(Series entidade)
        {
            listaSerie.Add(entidade);
        }

        public List<Series> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Series RetornaPorId(int Id)
        {
            return listaSerie[Id];
        }
    }
}