using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;
using Models.DomainEntities;

namespace Models
{
    public class GameDbContext : DbContext
    {
        public GameDbContext(DbContextOptions<GameDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameGenre>().HasKey(t => new {t.GameId, t.GenreId});

            modelBuilder.Entity<GameGenre>()
                .HasOne(gaGe => gaGe.Game)
                .WithMany(g => g.GameGenres)
                .HasForeignKey(gaGe => gaGe.GameId);

            modelBuilder.Entity<GameGenre>()
                .HasOne(gaGe => gaGe.Genre)
                .WithMany(g => g.GameGenres)
                .HasForeignKey(gaGe => gaGe.GenreId);
        }


        #region DbSets
        
        
        public DbSet<Game> Games { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<GameGenre> GameGenres { get; set; }
        
        #endregion
    }
}