using Airlanes.Models;

public class CityController : GenericController<City>
{
    public CityController(IRepository<City> repository) : base(repository) { }
}

public class ClientController : GenericController<Client>
{
    public ClientController(IRepository<Client> repository) : base(repository) { }
}

public class EmployeeController : GenericController<Employee>
{
    public EmployeeController(IRepository<Employee> repository) : base(repository) { }
}

public class FlightController : GenericController<Flight>
{
    public FlightController(IRepository<Flight> repository) : base(repository) { }
}

public class HotelController : GenericController<Hotel>
{
    public HotelController(IRepository<Hotel> repository) : base(repository) { }
}

public class MealController : GenericController<Meal>
{
    public MealController(IRepository<Meal> repository) : base(repository) { }
}

public class TourController : GenericController<Tour>
{
    public TourController(IRepository<Tour> repository) : base(repository) { }
}

public class TripController : GenericController<Trip>
{
    public TripController(IRepository<Trip> repository) : base(repository) { }
}