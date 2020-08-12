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

            modelBuilder.Entity<GamePlatform>().HasKey(t => new { t.GameId, t.PlatformId });

            modelBuilder.Entity<GamePlatform>()
                .HasOne(gaGe => gaGe.Game)
                .WithMany(g => g.GamePlatforms)
                .HasForeignKey(gaGe => gaGe.GameId);

            modelBuilder.Entity<GamePlatform>()
                .HasOne(gaGe => gaGe.Platform)
                .WithMany(g => g.GamesPlatforms)
                .HasForeignKey(gaGe => gaGe.PlatformId);

        }


        #region DbSets

        #region ApprovedEntities
        public DbSet<Game> Games { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<GameGenre> GameGenres { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<Photos> Photos { get; set; }
        #endregion

        #region ProposedEntities

        public DbSet<ProposedChanges.ProposedChanges> ProposedChanges { get; set; }

        #endregion

        #endregion
    }
}