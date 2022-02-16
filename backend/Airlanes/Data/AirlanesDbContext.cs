using Airlanes.Models;
using Microsoft.EntityFrameworkCore;

namespace Airlanes.Data
{
    public class AirlanesDb : DbContext
    {
        public AirlanesDb (DbContextOptions<AirlanesDb> options) : base(options) { }
        public DbSet<Airport> Airports => Set<Airport>();
        public DbSet<City> Cities => Set<City>();
        public DbSet<Client> Clients => Set<Client>();
        public DbSet<Country> Countries => Set<Country>();
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<Flight> Flights => Set<Flight>();
        public DbSet<Hotel> Hotels => Set<Hotel>();
        public DbSet<Meal> Meals => Set<Meal>();
        public DbSet<Placement> Placements => Set<Placement>();
        public DbSet<Position> Positions => Set<Position>();
        public DbSet<Tour> Tours => Set<Tour>();
        public DbSet<TourType> TourTypes => Set<TourType>();
        public DbSet<Trip> Trips => Set<Trip>();
    }
}