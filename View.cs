using System.Security.Cryptography.X509Certificates;
using ProjetoFilmesRepo.Model;

namespace ProjetoFilmesRepo
{
    public class View
    {
        public static void ExibicaoInicial()
        {
            System.Console.WriteLine("Bem Vindo ao Repositório de filmes!");
            System.Console.WriteLine("1 - Inserir Filme");
            System.Console.WriteLine("2 - Listar Filmes");
            System.Console.WriteLine("3 - Pesquisar por Titulo");
            System.Console.WriteLine("4 - Excluir Filmes");
            System.Console.WriteLine("5 - Sair");
        }
    }
}
