using ProjetoFilmesRepo.Model;

namespace ProjetoFilmesRepo.Repository
{
    public interface IProjetoFilmeRepository
    {
        public void Adicionar(Filme filme);
        public void Listar();
        public Filme Excluir(string titulo);
        
    }
}