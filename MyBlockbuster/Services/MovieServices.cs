using MyBlockbuster.Models;
using MyBlockbuster.Repository;
using MyBlockbuster.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlockbuster.Services
{
    public class MovieServices
    {
        private Storage _context = new Storage();
        
        public Movie RegisterMovies(MovieViewModels movies)
        {
            Movie movie = new Movie(movies);

            movie.Description = movies.description;
            movie.Launch = movie.launch;
            movie.Title = movies.title;

            _context.ListsMovies.Add(movie);
            _context.SaveChanges();

            return movie;
        }

        public List<object> ListsItens()
        {
            List<object> nomes = new List<object>();

            nomes.AddRange((IEnumerable<object>)_context.ListsMovies);

            return nomes;
        }
    }
}
