using Airlanes.Data;
using Airlanes.Models;

public class UnitOfWork : IUnitOfWork
{
    private AirlanesDb _context;
    private Repository<City> _cities;
    private Repository<Client> _clients;
    private Repository<Employee> _employees;
    private Repository<Flight> _flights;
    private Repository<Hotel> _hotels;
    private Repository<Meal> _meals;
    private Repository<Tour> _tours;
    private Repository<Trip> _trips;
    
    public IRepository<City> Cities {
        get {
            return _cities ??
            (_cities = new Repository<City>(_context));
        }
    }

    public IRepository<Client> Clients {
        get {
            return _clients ??
            (_clients = new Repository<Client>(_context));
        }
    }

    public IRepository<Employee> Employees {
        get {
            return _employees ??
            (_employees = new Repository<Employee>(_context));
        }
    }

    public IRepository<Flight> Flights {
        get {
            return _flights ??
            (_flights = new Repository<Flight>(_context));
        }
    }

    public IRepository<Hotel> Hotels {
        get {
            return _hotels ??
            (_hotels = new Repository<Hotel>(_context));
        }
    }

    public IRepository<Meal> Meals {
        get {
            return _meals ??
            (_meals = new Repository<Meal>(_context));
        }
    }

    public IRepository<Tour> Tours {
        get {
            return _tours ??
            (_tours = new Repository<Tour>(_context));
        }
    }

    public IRepository<Trip> Trips {
        get {
            return _trips ??
            (_trips = new Repository<Trip>(_context));
        }
    }

    public async Task Commit() => await _context.SaveChangesAsync();
}