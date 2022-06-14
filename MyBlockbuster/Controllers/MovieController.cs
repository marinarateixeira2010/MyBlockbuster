using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBlockbuster.Services;
using MyBlockbuster.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaLocadora.Controllers
{
    [Route("movie")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        public MovieServices _service = new MovieServices();

        [HttpPost]
        public IActionResult RegistersMovie(MovieViewModels movies)
        {
            if (movies == null)
            {
                return BadRequest("Please! Register a movie.");
            }

            MovieViewModels movie = _service.RegisterMovies(movies);

            return Created("movies", movie);
        }
    }
}
