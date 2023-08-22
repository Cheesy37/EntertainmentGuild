using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EntertainmentGuild.Models;

namespace EntertainmentGuild.Data
{
    public class EntertainmentGuildContext : DbContext
    {
        public EntertainmentGuildContext(DbContextOptions<EntertainmentGuildContext> options)
            : base(options)
        {
        }
        public DbSet<EntertainmentGuild.Models.Game> Game { get; set; } = default!;
        public DbSet<EntertainmentGuild.Models.Book> Book { get; set; } = default!;
        public DbSet<EntertainmentGuild.Models.Movie> Movie { get; set; } = default!;

        }
}
