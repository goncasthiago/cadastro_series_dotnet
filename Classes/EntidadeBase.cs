using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cadastro_series_dotnet.Classes
{
    public abstract class EntidadeBase
    {
        protected EntidadeBase(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
        
    }
}