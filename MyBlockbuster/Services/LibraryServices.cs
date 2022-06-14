using MyBlockbuster.Models;
using MyBlockbuster.Repository;
using MyBlockbuster.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlockbuster.Services
{
    public class LibraryServices
    {
        private Storage _context = new Storage();

        public Library RegisterLibrary(LibraryViewModels libraries)
        {
            Library library = new Library(libraries);

            library.Category = libraries.category;
            library.Price = libraries.price;
            library.Language = libraries.language;
            library.Genre = libraries.genre;

            _context.ListsLibrary.Add(library);
            _context.SaveChanges();

            return library;
        }

        public List<object> ListsItens()
        {
            List<object> nomes = new List<object>();

            nomes.AddRange((IEnumerable<object>)_context.ListsLibrary);
            
            return nomes;
        }
    }
}