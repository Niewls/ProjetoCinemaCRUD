using ProjetoFilmesRepo.DataBase;
using ProjetoFilmesRepo.Exceptions;
using ProjetoFilmesRepo.Model;

namespace ProjetoFilmesRepo.Repository
{
    public class FilmesRepository : IProjetoFilmeRepository
    {
        private readonly FilmeSet _filmeSet;

        public FilmesRepository(FilmeSet filmeSet)
        {
            _filmeSet = filmeSet;
        }

        public void Adicionar(Filme filme)
        {
            _filmeSet.AdicionarFilmes(filme);
        }

        public Filme Excluir(string titulo)
        {
            var filmeExcluido = _filmeSet.Filmes.FirstOrDefault(p => p.Titulo.ToUpper() == titulo.ToUpper());
            if (filmeExcluido == null)
            {
                throw new SelecaoException("Filme Inexistente!");
            }
                _filmeSet.Filmes.Remove(filmeExcluido);
                return filmeExcluido;
        }

        public void Listar()
        {
            foreach (Filme filme in _filmeSet.Filmes)
            {
                System.Console.WriteLine(filme.ToString());
            }
        }

        public Filme PesquisarPorTitulo(string titulo)
        {
            var filmePesquisado = _filmeSet.Filmes.FirstOrDefault(p => p.Titulo.ToUpper() == titulo.ToUpper());
            if (filmePesquisado == null)
            {
                throw new SelecaoException("Filme Inexistente!");
            }
                return filmePesquisado;
            
        }
    }
}