using Microsoft.EntityFrameworkCore;

namespace HotelListingNEW.api.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Sweden",
                    ShortName = "SWE"
                },
                new Country
                {
                    Id = 2,
                    Name = "Finland",
                    ShortName = "FIN"
                },
                new Country
                {
                    Id = 3,
                    Name = "Norway",
                    ShortName = "NOR"
                }

            );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel 
                { 
                    Id = 1, 
                    Name = "Scandic Hotel", 
                    Adress ="Gothenburg", 
                    CountryId = 1, 
                    Rating = 4.5
                },
                 new Hotel
                 {
                     Id = 2,
                     Name = "Comfort Hotel",
                     Adress = "Oslo",
                     CountryId = 3,
                     Rating = 3.5
                 },
                  new Hotel
                  {
                      Id = 3,
                      Name = "Grand Hotel",
                      Adress = "Helsinfors",
                      CountryId = 2,
                      Rating = 4.2
                  }
            );
        }
    }
}
