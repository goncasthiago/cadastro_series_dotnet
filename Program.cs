using static System.Console;
using cadastro_series_dotnet.Classes;
using cadastro_series_dotnet.Enum;
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
                        InserirSerie();
                        //TODO Implementar inserir serie

                        break;

                    case "3":
                        AtualizarSerie();
                        //TODO Implementar atualizar serie
                        break;

                    case "4":
                        ExcluirSerie();
                        //TODO Implementar excluir serie
                        break;

                    case "5":
                        VisualizarSerie();
                        //TODO Implementar visualizar serie
                        break;

                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();


                }

                opcaoUsuario = ObterOpcaoUsuario();

            }
            WriteLine("Obrigado por utilizar nossos serviços");
            ReadLine();

        }

        private static void VisualizarSerie()
        {
            WriteLine("Digite o id da série: ");
            int indiceSerie = int.Parse(ReadLine());
            var serie = repositorio.RetornaPorId(indiceSerie);
            WriteLine(serie);

        }

        private static void ExcluirSerie()
        {
            WriteLine("Digite o id da série: ");
            int indiceSerie = int.Parse(ReadLine());

            repositorio.Exclui(indiceSerie);
        }

        private static void AtualizarSerie()
        {
            WriteLine("Digite o id da Série:");
            int indiceSerie = int.Parse(ReadLine());

            for (int i = 0; i < Genero.GetNames(typeof(Genero)).Length; i++)
            {
                
                 WriteLine($"{i}-{Genero.GetName(typeof(Genero), i)}");
            }

            WriteLine("Digite o Gênero entre as opções acima: ");
            int entradaGenero = int.Parse(ReadLine());

            WriteLine("Digite o Título da Série: ");
            string? entradaTitulo = ReadLine();

            WriteLine("Digite o Ano de início da Série: ");
            int entradaAno = int.Parse(ReadLine());

            WriteLine("Digite uma descrição da Série: ");
            string? entradaDescricao = ReadLine();

            Series atualizaSerie = new Series
            (
                Id: indiceSerie,
                genero: (Genero)entradaGenero,
                titulo: entradaTitulo,
                descricao: entradaDescricao,
                ano: entradaAno
            );

            repositorio.Atualiza(indiceSerie, atualizaSerie );

        }
        private static void ListarSeries()
        {
            WriteLine("Listar Séries");
            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                WriteLine("Nenhuma série cadastrada!");
                return;
            }
            foreach (var serie in lista)
            {
                var excluido = serie.retornaExcluido();
                if (!excluido)
                WriteLine($"ID-{serie.retornaId()} - {serie.RetornaTitulo()}");

            }

        }

        private static void InserirSerie()
        {
            WriteLine("Inserir nova Série");

            // foreach (var i in Genero.GetValues(typeof(Genero)))
            // {
            //     WriteLine($"{i}-{Genero.GetName(typeof(Genero), i)}");

            // }

            for (int i = 0; i < Genero.GetNames(typeof(Genero)).Length; i++)
            {
                
                 WriteLine($"{i}-{Genero.GetName(typeof(Genero), i)}");
            }
            WriteLine("Digite o Gênero entre as opções acima: ");
            int entradaGenero = int.Parse(ReadLine());

            WriteLine("Digite o Título da Série: ");
            string? entradaTitulo = ReadLine();

            WriteLine("Digite o Ano de início da Série: ");
            int entradaAno = int.Parse(ReadLine());

            WriteLine("Digite uma descrição da Série: ");
            string? entradaDescricao = ReadLine();

            Series novaSerie = new Series
            (
                Id: repositorio.ProximoId(),
                genero: (Genero)entradaGenero,
                titulo: entradaTitulo,
                descricao: entradaDescricao,
                ano: entradaAno
            );

            repositorio.Insere(novaSerie);

        }

        private static string ObterOpcaoUsuario()
        {
            WriteLine();
            WriteLine("DIO Séries a seu dispor");
            WriteLine("Informe a opção desejada");
            //TODO construir as opcoes
            WriteLine("1- Listar as séries");
            WriteLine("2- Inserir nova série");
            WriteLine("3- Atualizar série");
            WriteLine("4- Excluir série");
            WriteLine("5- Visualizar série");
            WriteLine("C- Limpar a tela");
            WriteLine("X- Sair");
            WriteLine();
            string opcaoUsuario = ReadLine().ToUpper();
            return opcaoUsuario;
        }

    }

}

