using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedMovieData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new DataContext(serviceProvider
            .GetRequiredService<DbContextOptions<DataContext>>()))
            {
                //Check if Movie already exists
                if (context.Movie.Any())
                    return;

                context.Movie.AddRange(
                    new Movie{
                        Title = "The Recruit",
                        ReleaseDate = DateTime.Parse("2004-02-15"),
                        Genre = "Thriller",
                        Price = 9.99M
                    },
                    new Movie{
                        Title = "Behind Enemy Lines",
                        ReleaseDate = DateTime.Parse("2003-08-23"),
                        Genre = "Action",
                        Price = 8.99M
                    }
                );

                context.SaveChanges();
            }
        }
    }
}