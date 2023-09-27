using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace SweeftEntityFramoworkApp.Db
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Server=LocalHost;Database=School_db;Trusted_Connection=true;MultipleActiveResultSets=True;Encrypt=False;");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
