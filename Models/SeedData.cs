using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "Tarzan",
                    ReleaseDate = DateTime.Parse("1999-06-18"),
                    Genre = "Animation",
                    Rating = "G",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "The Lion King",
                    ReleaseDate = DateTime.Parse("1994-06-24"),
                    Genre = "Animation",
                    Rating = "G",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Pocahontas",
                    ReleaseDate = DateTime.Parse("1995-06-23"),
                    Genre = "Animation",
                    Rating = "G",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "The Iron Giant",
                    ReleaseDate = DateTime.Parse("1999-08-06"),
                    Genre = "Animation",
                    Rating = "PG",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Iron Man",
                    ReleaseDate = DateTime.Parse("2008-05-02"),
                    Genre = "Action",
                    Rating = "PG-13",
                    Price = 12.99M
                },
                new Movie
                {
                    Title = "The Avengers",
                    ReleaseDate = DateTime.Parse("2012-05-04"),
                    Genre = "Action",
                    Rating = "PG-13",
                    Price = 14.99M
                },
                new Movie
                {
                    Title = "The Road to El Dorado",
                    ReleaseDate = DateTime.Parse("2000-03-31"),
                    Genre = "Animation",
                    Rating = "PG",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Spirit: Stallion of the Cimarron",
                    ReleaseDate = DateTime.Parse("2002-05-24"),
                    Genre = "Animation",
                    Rating = "G",
                    Price = 8.99M
                }
            );
            context.SaveChanges();
        }
    }
}