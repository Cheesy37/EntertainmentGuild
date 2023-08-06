using Microsoft.EntityFrameworkCore;

namespace INFT3050.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    MovieID = 1,
                    Name = "Casablanca",
                    Year = 1942,
                    Rating = 5,
                    GenreId = "D"
                },
                new Movie
                {
                    MovieID = 2,
                    Name = "Diary of a Whimpy Kid",
                    Year = 2010,
                    Rating = 1,
                    GenreId = "H"
                },
                new Movie
                {
                    MovieID = 3,
                    Name = "Pixels",
                    Year = 2014,
                    Rating = 3,
                    GenreId = "C"
                }
            );
            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId = "A", Name = "Action" },
                new Genre { GenreId = "C", Name = "Comedy" },
                new Genre { GenreId = "D", Name = "Drama" },
                new Genre { GenreId = "H", Name = "Horror" },
                new Genre { GenreId = "M", Name = "Musical" },
                new Genre { GenreId = "R", Name = "RomCom" },
                new Genre { GenreId = "S", Name = "SciFi" }
            );
        }
    }
}
