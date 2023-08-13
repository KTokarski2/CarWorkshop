using Microsoft.EntityFrameworkCore;

namespace CarWorkshop.Infrastructure.Persistence;

public class CarWorkshopDbContext : DbContext
{
    public DbSet<Domain.Entities.CarWorkshop> CarWorkshops { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=CarWorkshopDb;Encrypt=false;TrustServerCertificate=True;Integrated Security=False;User Id=SA;Password=H0m0$apien$123$$$;MultipleActiveResultSets=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Domain.Entities.CarWorkshop>()
            .OwnsOne(c => c.ContactDetails);
    }
}