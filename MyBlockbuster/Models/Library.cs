using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlockbuster.Models
{
    public class Library : LibraryViewModels
    {
        public Library()
        {

        }

        public Library(LibraryViewModels _library)
        {
            Category = _library.category;
            Price = _library.price;
            Language = _library.language;
            Genre = _library.genre;
        }

        public Guid Id { get; set; }
        public String Category { get; set; }
        public float Price { get; set; }
        public String Language { get; set; }
        public String Genre { get; set; }
    }
}
