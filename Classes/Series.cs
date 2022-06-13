using static System.Console;
using cadastro_series_dotnet.Enum;

namespace cadastro_series_dotnet.Classes
{
    public class Series : EntidadeBase
    {
        private Genero genero {get; set;}
        private string Titulo {get; set;}
        private string Descricao {get; set;}
        private int Ano {get; set;}

        private bool Excluido {get; set;}
        
        public Series(int Id, Genero genero, string titulo, string descricao, int ano) : base(Id)
        {
            this.genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            this.Excluido = false;   
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Exluído: " + this.Excluido;
            return retorno;

        }

        public string RetornaTitulo()
        {
            return this.Titulo;
        }
        internal int retornaId()
        {
            return this.Id;
        }
        internal bool retornaExcluido()
        {
            return this.Excluido;
        }

        public void Exclui()
        {
            this.Excluido = true;
        }


        
    }
}