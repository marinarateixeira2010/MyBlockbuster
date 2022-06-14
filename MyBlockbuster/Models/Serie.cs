using MyBlockbuster.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlockbuster.Models
{
    public class Serie : SerieViewModels
    {

        public Serie()
        {

        }

        public Serie(SerieViewModels _serie)
        {
            Title = _serie.title;
            Description = _serie.description;
            Launch = _serie.launch;
            Seasons = _serie.seasons;
        }

        public Guid Id { get; set; }
        public String Title { get; set; }
        public DateTime Launch { get; set; }
        public String Description { get; set; }
        public String Seasons { get; set; }
    }
}
