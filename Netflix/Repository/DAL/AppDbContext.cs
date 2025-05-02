using Microsoft.EntityFrameworkCore;
using Netflix.Domain.Configuration;
using Netflix.Domain.Models.Entities;

namespace Netflix.Repository.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Plan> Plans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PlanConfiguration).Assembly);
        }


    }
}
