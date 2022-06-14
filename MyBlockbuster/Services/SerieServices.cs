using MyBlockbuster.Models;
using MyBlockbuster.Repository;
using MyBlockbuster.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlockbuster.Services
{
    public class SerieServices
    {
        private Storage _context = new Storage();

        public Serie RegisterSeries(SerieViewModels series)
        {
            Serie serie = new Serie(series);

            serie.Title = series.title;
            serie.Description = series.description;
            serie.Launch = series.launch;
            serie.Seasons = series.seasons;

            _context.ListsSeries.Add(serie);
            _context.SaveChanges();

            return serie;
        }

        public List<object> ListsItens()
        {
            List<object> nomes = new List<object>();

            nomes.AddRange((IEnumerable<object>)_context.ListsSeries);

            return nomes;
        }
    }
}