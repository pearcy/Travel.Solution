using Microsoft.EntityFrameworkCore;

namespace Travel.Models
{
  public class TravelContext : DbContext
  {
    public TravelContext(DbContextOptions<TravelContext> options)
        : base(options)
    {
    }

    public DbSet<Destination> Destinations { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Destination>()
          .HasData(
              new Destination { DestinationId = 1, Country = "Japan", City = "Toyko", Rating = 5, Review = "Cherry Blossoms Galore!", Topspot = "Toyko Tower" },
              new Destination { DestinationId = 2, Country = "USA", City = "Portland", Rating = 4, Review = "Beer & Coffee Lovers Paradise", Topspot ="Voodoo Doughnuts" },
              new Destination { DestinationId = 3, Country = "Colombia", City = "Medellin", Rating = 4, Review = "Bachata music", Topspot = "Botero Plaza" }
          );
    }

 
  }
}
