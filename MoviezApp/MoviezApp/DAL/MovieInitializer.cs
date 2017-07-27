using MoviezApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviezApp.DAL
{
    public class MovieInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MovieContext>
    {
        protected override void Seed(MovieContext context)
        {
            var movies = new List<Movie>
            {
            new Movie{MovieName="Pulp Fiction", RelaseYear=1994},
            new Movie{MovieName="The Dark Night Rises", RelaseYear=2008},

            };
            movies.ForEach(s => context.Movies.Add(s));
            context.SaveChanges();

        }
    }
}