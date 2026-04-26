using Gallery.Entities;
using Microsoft.EntityFrameworkCore;

namespace Gallery.DataAccess;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

    public DbSet<Brand> Brands { get; set; }
    public DbSet<Logo> Logos { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<Cover> Covers { get; set; }
    public DbSet<Image> Images { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Brand>()
            .HasOne(b => b.Logo)
            .WithOne(l => l.Brand)
            .HasForeignKey<Logo>(l => l.BrandId);

        modelBuilder.Entity<Car>()
            .HasOne(c => c.Cover)
            .WithOne(cv => cv.Car)
            .HasForeignKey<Cover>(cv => cv.CarId);

        base.OnModelCreating(modelBuilder);
    }
}