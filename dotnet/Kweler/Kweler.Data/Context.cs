using Kweler.Domain.Models.Persons;
using Kweler.Domain.Models.Songs;
using Microsoft.EntityFrameworkCore;
using System;

namespace Kweler.Data
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options)
            :base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<SongArtist> SongArtists { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }
    }
}
