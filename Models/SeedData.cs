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
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Rating = "R",
                    Genre = "Romantic Comedy",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Rating = "PG",
                    Genre = "Comedy",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Rating = "PG",
                    Genre = "Comedy",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Rating = "PG-13",
                    Genre = "Western",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "Groundhog Day",
                    ReleaseDate = DateTime.Parse("1993-2-12"),
                    Rating = "PG",
                    Genre = "Comedy",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Inception",
                    ReleaseDate = DateTime.Parse("2010-7-16"),
                    Rating = "PG-13",
                    Genre = "Science Fiction",
                    Price = 10.99M
                },
                new Movie
                {
                    Title = "The Dark Knight",
                    ReleaseDate = DateTime.Parse("2008-7-18"),
                    Rating = "PG-13",
                    Genre = "Action",
                    Price = 9.99M
                }
            );
            context.SaveChanges();
        }
    }
}