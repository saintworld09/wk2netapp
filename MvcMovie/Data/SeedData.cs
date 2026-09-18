using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>());

        var seedMovies = new List<Movie>
        {
            new Movie
            {
                Title = "The Pursuit of Happyness",
                ReleaseDate = new DateTime(2006, 12, 15),
                Genre = "Drama",
                Price = 120,
                Rating = "PG-13"
            },

            new Movie
            {
                Title = "Black Panther",
                ReleaseDate = new DateTime(2018, 2, 16),
                Genre = "Action",
                Price = 150,
                Rating = "PG-13"
            },

            new Movie
            {
                Title = "Spider-Man: No Way Home",
                ReleaseDate = new DateTime(2021, 12, 17),
                Genre = "Action",
                Price = 180,
                Rating = "PG-13"
            }
        };

        foreach (var movie in seedMovies)
        {
            if (!context.Movie.Any(m => m.Title == movie.Title))
            {
                context.Movie.Add(movie);
            }
        }

        context.SaveChanges();
    }
}