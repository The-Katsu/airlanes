using Airlanes.Models;

public interface IUnitOfWork
{
    IRepository<City> Cities {get;}
    IRepository<Client> Clients {get;}
    IRepository<Employee> Employees {get;}
    IRepository<Flight> Flights {get;}
    IRepository<Hotel> Hotels {get;}
    IRepository<Meal> Meals {get;}
    IRepository<Tour> Tours {get;}
    IRepository<Trip> Trips {get;}
    Task Commit();
}