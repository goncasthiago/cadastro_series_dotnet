using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cadastro_series_dotnet.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int Id);
        void Insere(T entidade);
        
        void Exclui(int id);

        void Atualiza(int Id, T entidade);
        
        int ProximoId();


    }
}