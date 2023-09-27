using Microsoft.EntityFrameworkCore;
using SweeftEntityFramoworkApp.Models;

namespace SweeftEntityFramoworkApp.Db
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Teachers> Teachers { get; set; }
        public DbSet<Pupils> Pupils { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teachers>()
                .HasMany(t => t.Pupils)
                .WithMany(s => s.Teachers);
        }
    }
}
