using Airlanes.Models;

public class CityController : GenericController<City>
{
    public CityController(IRepository<City> repository) : base(repository) { }
}

public class ClientController : GenericController<Client>
{
    public ClientController(IRepository<Client> repository) : base(repository) { }
}