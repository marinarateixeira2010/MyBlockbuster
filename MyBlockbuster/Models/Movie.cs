using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyBlockbuster.Views;

namespace MyBlockbuster.Models
{
    public class Movie : MovieViewModels
    {
        public Movie()
        {

        }

        public Movie(MovieViewModels _movie)
        {
            Description = _movie.description;
            Launch = _movie.launch;
            Title = _movie.title;
        }

        public Guid Id { get; set; }
        public String Description { get; set; }
        public DateTime Launch { get; set; }
        public String Title { get; set; }

    }
}
