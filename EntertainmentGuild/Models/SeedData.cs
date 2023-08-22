using EntertainmentGuild.Data;
using EntertainmentGuild.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace EntertainmentGuild.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new EntertainmentGuildContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<EntertainmentGuildContext>>()))
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
                    Genre = "Romantic Comedy",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Price = 3.99M
                }
            );

            // Look for any Games.
            if (context.Game.Any())
            {
                return;
            }
            context.Game.AddRange(
                new Game
                {
                    Title = "The Legend of Zelda: Tears of the Kingdom",
                    ReleaseDate = DateTime.Parse("2023-5-13"),
                    Genre = "Open World",
                    Price = 89.99M
                },
                new Game
                {
                    Title = "Yakuza 0",
                    ReleaseDate = DateTime.Parse("2015-3-12"),
                    Genre = "Action",
                    Price = 59.99M
                },
                new Game
                {
                    Title = "Sekiro: Shadows Die Twice",
                    ReleaseDate = DateTime.Parse("2019-3-22"),
                    Genre = "Action-Adventure",
                    Price = 99.99M
                },
                new Game
                {
                    Title = "Final Fantasy XVI",
                    ReleaseDate = DateTime.Parse("2023-06-22"),
                    Genre = "Action",
                    Price = 109.99M
                }
                );

            // Look for any Books.
            if (context.Book.Any())
            {
                return;
            }
            context.Book.AddRange(
                new Book
                {
                    Title = "Berserk Deluxe Volume 1",
                    ReleaseDate = DateTime.Parse("2019-2-27"),
                    Genre = "Action",
                    Price = 55.99M
                },
                new Book
                {
                    Title = "20th Century Boys Volume 1",
                    ReleaseDate = DateTime.Parse("2000-1-29"),
                    Genre = "Mystery",
                    Price = 19.99M
                },
                new Book
                {
                    Title = "One Piece Volume 103",
                    ReleaseDate = DateTime.Parse("2022-8-4"),
                    Genre = "Action-Adventure",
                    Price = 17.99M
                },
                new Book
                {
                    Title = "Goodnight Punpun Volume 1",
                    ReleaseDate = DateTime.Parse("2007-8-3"),
                    Genre = "Drama",
                    Price = 21.99M
                }
                );
            context.SaveChanges();
        }
    }
}