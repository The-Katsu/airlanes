using Airlanes.Models;
using Microsoft.EntityFrameworkCore;

namespace Airlanes.Data
{
    public class AirlanesDb : DbContext
    {
        public AirlanesDb (DbContextOptions<AirlanesDb> options) : base(options) { }
        public DbSet<City> Cities => Set<City>();
        public DbSet<Client> Clients => Set<Client>();
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<Flight> Flights => Set<Flight>();
        public DbSet<Hotel> Hotels => Set<Hotel>();
        public DbSet<Meal> Meals => Set<Meal>();
        public DbSet<Tour> Tours => Set<Tour>();
        public DbSet<Trip> Trips => Set<Trip>();
    }
}