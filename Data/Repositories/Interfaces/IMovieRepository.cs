using movie_api.Models;

namespace movie_api.Data.Repositories.Intefaces
{
public interface IMovieRepository
{
    List<Movie> GetAll();
    Movie GetById(long id);
}    
}