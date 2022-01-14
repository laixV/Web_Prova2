using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Super_Market.Persistence.Contexts
{
    public class AppDbContextFactory: IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseNpgsql(
                @"Server=127.0.0.1; Port=5432; User Id=postgres; Password=reallyStrongPwd123; Database=supermarket;");
            return new AppDbContext(optionsBuilder.Options);
        }
    }
}