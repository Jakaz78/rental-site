using Microsoft.EntityFrameworkCore;
using RentalSite.Components.Classes;

namespace RentalSite.Components.Data
{
    public class AppDbContext : DbContext
    {

        protected readonly IConfiguration Configuration;

        public AppDbContext(IConfiguration configuration)
        {

            Configuration = configuration;
        }









        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DbConnectionString"));
        }

        public DbSet<Person> Guests { get; set; }
        public DbSet<Reservation> NewReservations { get; set; }





    }
}
