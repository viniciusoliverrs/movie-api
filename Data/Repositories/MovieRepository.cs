

using movie_api.Data.Repositories.Intefaces;
using movie_api.Data.Repositories.Mock;
using movie_api.Models;

namespace movie_api.Data.Repositories
{
    public class MovieRepository : IMovieRepository
    {

        public List<Movie> GetAll()
        {
            return MovieData.Content.ToList();
        }

        public Movie GetById(long id)         {
            return MovieData.Content.FirstOrDefault(x=>x.Id == id);
        }
    }
}