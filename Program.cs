using System.Globalization;
using System.Runtime.Serialization;
using ProjetoFilmesRepo;
using ProjetoFilmesRepo.DataBase;
using ProjetoFilmesRepo.Exceptions;
using ProjetoFilmesRepo.Model;
using ProjetoFilmesRepo.Repository;

try
{
    bool finalizado = false;
    FilmeSet filmeDB = new();
    FilmesRepository repository = new(filmeDB);
    while (!finalizado)
    {
        View.ExibicaoInicial();
        int valorCapturado = int.Parse(Console.ReadLine());
        switch (valorCapturado)
        {
            case 1:
                Filme filme = ColetarDados();
                repository.Adicionar(filme);
                System.Console.WriteLine("Filme Adicionado!");
                break;
            case 2:
                repository.Listar();
                Console.ReadLine();
                break;
            case 3:
                System.Console.WriteLine("Digite o titulo a ser buscado: ");
                string titulo = Console.ReadLine();
                Filme pesquisado = repository.PesquisarPorTitulo(titulo);
                System.Console.WriteLine(pesquisado.ToString());
                break;
            case 4:
                System.Console.WriteLine("valor 4 selecionado");
                break;
            case 5:
                System.Console.WriteLine("Saindo...");
                finalizado = true;
                break;
            default:
                throw new SelecaoException("Valor incorreto!");
        }
    }
}
catch (SelecaoException e)
{
    System.Console.WriteLine(e.Message);
}

static Filme ColetarDados()
{
    System.Console.WriteLine("Digite o Nome do Filme: ");
    string nome = Console.ReadLine();
    System.Console.WriteLine("Digite a data no formato dd/MM/yyyy");
    DateTime data = DateTime.Parse(Console.ReadLine());
    System.Console.WriteLine("Digite o gênero do filme");
    string genero = Console.ReadLine();
    System.Console.WriteLine("Digite a Avaliação do filme (0 - 10)");
    double avaliacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if (avaliacao < 0 || avaliacao > 10)
    {
        throw new SelecaoException("Valor de Avaliação inválido!");
    }
    return new Filme(nome, data, genero, avaliacao);
}
