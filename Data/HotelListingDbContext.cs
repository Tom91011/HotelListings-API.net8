using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options) 
        {
            
        }

    //This is adding it to the DB set
        public DbSet<Hotel> Hotels {  get; set; }

        public DbSet<Country>  Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "United Kingdom",
                    ShortName = "UK",
                }, new Country
                {
                    Id = 2,
                    Name = "France",
                    ShortName = "Fr"
                }
            );

            modelBuilder.Entity<Hotel>().HasData(

                new Hotel
                {
                    Id = 1,
                    Name = "Hilton",
                    CountryId = 1,
                    Address = "1 Long Lane, London, UK",
                    Rating = 5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Travel lodge",
                    CountryId = 2,
                    Address = "1 Short Road, Nottingham, UK",
                    Rating = 6
                }
            );
        }

    }
}
