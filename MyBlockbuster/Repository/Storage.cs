using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyBlockbuster.Views;
using MyBlockbuster.Models;

namespace MyBlockbuster.Repository
{
    public class Storage : DbContext
    {
        public DbSet<Library> ListsLibrary { get; set; }
        public DbSet<Movie> ListsMovies { get; set; }
        public DbSet<Serie> ListsSeries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder construtor)
         {
         
            //string conexao = "Server=localhost\\SQLEXPRESS;Database=Locadora;Integrated Security=SSPI"; construtor.UseSqlServer(conexao);

        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }

    public class DbContextOptionsBuilder
    {
    }

    public class DbSet<T>
    {
        internal void Add(Library library)
        {
            throw new NotImplementedException();
        }

        internal void Add(Movie movie)
        {
            throw new NotImplementedException();
        }

        internal void Add(Serie serie)
        {
            throw new NotImplementedException();
        }
    }

    public class DbContext
    {
    }
}
