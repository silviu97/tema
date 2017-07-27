namespace MoviezApp.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MoviezApp.DAL.MovieContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MoviezApp.DAL.MovieContext";
        }

        protected override void Seed(MoviezApp.DAL.MovieContext context)
        {
            var movies = new List<Movie>
            {
            new Movie{MovieName="Pulp Fiction", RelaseYear=1994},
            new Movie{MovieName="The Dark Night Rises", RelaseYear=2008},
            new Movie{MovieName="The Godfather", RelaseYear=1972},

            };
            movies.ForEach(s => context.Movies.AddOrUpdate(p => p.MovieName, s));
            context.SaveChanges();
        }


    }
}

