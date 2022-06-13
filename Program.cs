using static System.Console;
using cadastro_series_dotnet.Classes;
namespace cadastro_series_dotnet
{

    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {

            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                    ListarSeries();
                    break;

                    case "2":
                    //InserirSerie();
                    //TODO Implementar inserir serie

                    break;

                    case "3":
                    //AtualizarSerie();
                    //TODO Implementar atualizar serie
                    break;

                    case "4":
                    //ExcluirSerie();
                    //TODO Implementar excluir serie
                    break;

                    case "5":
                    //  VisualizarSerie();
                    //TODO Implementar visualizar serie
                    break;

                    default:
                    throw new ArgumentOutOfRangeException();
                    
                    
                }

             opcaoUsuario = ObterOpcaoUsuario();
                
            }
            WriteLine("Obrigado por utilizar nossos serviços");
            ReadLine();

        }

        private static void ListarSeries()
        {
            WriteLine("Listar Séries");
            var lista = repositorio.Lista();
            
            if (lista.Count == 0 )
            {
                WriteLine("Nenhuma série cadastrada!");
                return;
            }
            foreach (var serie in lista)
            {
                WriteLine($"ID-{serie.retornaId()} - {serie.RetornaTitulo()}"); 
                
            }

        }

        private static string ObterOpcaoUsuario()
        {
            WriteLine();
            WriteLine("Informe a opção desejada");
            //TODO construir as opcoes
            string opcaoUsuario = ReadLine().ToUpper();
            return opcaoUsuario;
        }

    }

}

