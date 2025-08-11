namespace ProjetoFilmesRepo.Model
{
    public class Filme
    {
        public string? Titulo { get; set; }
        public DateTime DataLancamento { get; set; }
        public string Genero { get; set; }
        public double Avaliacao { get; set; }

        public Filme(string titulo, DateTime datalancamento, string genero, double avaliacao)
        {
            Titulo = titulo;
            DataLancamento = datalancamento;
            Genero = genero;
            Avaliacao = avaliacao;
        }

        public override string ToString()
        {
            return $"Titulo: {Titulo}, Data de Lancamento: {DataLancamento.ToShortDateString()}, Genero: {Genero}, Avaliacao: {Avaliacao}";
        }
    }
}