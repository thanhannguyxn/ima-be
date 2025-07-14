using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ima_be.Infrastructure.Persistence
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            // Trỏ về đúng nơi chứa appsettings.json
            var basePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "ima-be"));
            var config = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var connStr = config.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseMySql(
                connStr,
                new MySqlServerVersion(new Version(8, 0, 36))
            );

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}

