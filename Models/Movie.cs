namespace movie_api.Models
{
    public class Movie
    {
        public long Id { get; private set; }
        public string Nome { get; private set; }
        public string Sinopse { get; private set; }
        public string Foto { get; private set; }
    
        public Movie(long id, string nome, string sinopse, string foto)
        {
            this.Id = id;
            this.Nome = nome;
            this.Sinopse = sinopse;
            this.Foto = foto;
        }
    }
}