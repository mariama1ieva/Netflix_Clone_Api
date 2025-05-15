using Domain.Configuration;
using Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Netflix.Domain.Models.Entities;

namespace Netflix.Repository.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Content> Contents { get; set; }
        public DbSet<ContentGenre> ContentGenres { get; set; }
        public DbSet<ContentPerson> ContentPeople { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<ViewingHistory> ViewingHistories { get; set; }
        public DbSet<WatchlistItem> WatchlistItems { get; set; }
        public DbSet<Plan> Plans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PlanConfiguration).Assembly);
        }


    }
}
