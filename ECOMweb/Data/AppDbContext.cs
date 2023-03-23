using ECOMweb.Models;
using Microsoft.EntityFrameworkCore;

namespace ECOMweb.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {

        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}


        public DbSet<Category> Categories { get; set; }
        public DbSet<Series> Serieses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductConfig> ProductConfigs { get; set; }
        public DbSet<ConfigItem> ConfigItems { get; set; }

    }
}
