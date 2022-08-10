using Microsoft.AspNetCore.Mvc;
using movie_api.Data.Repositories.Intefaces;
using movie_api.Models;
using movie_api.ViewModel.Responses;

namespace movie_api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class MovieController : ControllerBase
{
    private readonly IMovieRepository _movieRepository;
    public MovieController(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    [HttpGet]
    public ActionResult<List<Movie>> GetAll()
    {
        var movies = _movieRepository.GetAll();
        return Ok(new BaseResponse("Successfully retrieved movie.", movies));
    }

    [HttpGet("{id:long}")]
    public ActionResult<Movie> GetById(int id)
    {
        var movie = _movieRepository.GetById(id);
        if(movie is null) return NoContent();
        return Ok(new BaseResponse("Successfully retrieved movie.", movie));
    }
}
