using ProjetoFilmesRepo.Exceptions;
using ProjetoFilmesRepo.Model;
using System.Linq;

namespace ProjetoFilmesRepo.DataBase
{
    public class FilmeSet
    {
        public List<Filme> Filmes;

        public FilmeSet()
        {
            Filmes = [];
        }

        public void AdicionarFilmes(Filme filme)
        {
            var filmeExistente = Filmes.FirstOrDefault(p => p.Titulo == filme.Titulo);
            if (filmeExistente != null)
            {
                throw new SelecaoException("Filme Existente!");
            }
            else
            {
                Filmes.Add(filme);
            }
        }

    }
}