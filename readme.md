## C# Generic repository and controller
---
## Welcome to my pet project  
Here I'm talking about generic repository pattern with ASP.NET 6 web API and Entity Framework.  
It is a good way when working with a large number of classes with similar functionality.   
### Interface
Here we describe the methods that will have to be implemented.
```csharp
public interface IRepository<TEntity> 
where TEntity : class
{
    public Task Insert(TEntity entity);
    public Task<TEntity> GetById (Guid id);
    public Task<IEnumerable<TEntity>> Get();
    public Task Delete(TEntity entity);
}
```
TEntity is a generic class, that will represent the class we choose.
### Repository
Now implement it.
```csharp
public class Repository<TEntity> : IRepository<TEntity> 
where TEntity : class
{
    private DbContext _context;
    private DbSet<TEntity> dbSet;

    public Repository(AirlanesDb context)
    {
        _context = context;
        dbSet = context.Set<TEntity>();
    }

    public async Task<IEnumerable<TEntity>> Get() 
    => await dbSet.ToListAsync();

    public async Task<TEntity> GetById(Guid id) 
    => await dbSet.FindAsync(id);

    public async Task Insert(TEntity entity) 
    {
        await dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
    }    

    public async Task Delete(TEntity entity) 
    {
        dbSet.Remove(entity);
        await _context.SaveChangesAsync();    
    }
}
```
To work with unknown types, TEntity in our case, use DbSet that will handle any class we transfer.  
### Controller
In Program.cs register our Interface and Implementation.
```csharp
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
```
In Controllers folder add new class.
```csharp
[Route("api/[controller]")]
public class GenericController<T> : Controller 
where T : class
{
    private IRepository<T> _repository;

    public GenericController(IRepository<T> repository) 
    => _repository = repository;

    [HttpGet]
    public async Task<IEnumerable<T>> GetAllAsync() 
    => await _repository.Get();

    [HttpGet("{id}")]
    public async Task<T> GetAsync(Guid id) 
    => await _repository.GetById(id);

    [HttpPost]
    public async Task PostAsync([FromBody]T entity) 
    => await _repository.Insert(entity);

    [HttpDelete("{id}")]
    public async Task DeleteAsync(Guid id)
    {
        T entity = await _repository.GetById(id);
        await _repository.Delete(entity);
    }
}
```
Define our methods with IRepository and call them.  
To use ur controller with defined classes write this.
```csharp
public class YourController : GenericController<YourClass>
{
    public YourController(IRepository<YourClass> repository) 
    : base(repository) { }
}
```
### Add swagger
Try requests with swagger, add this to Program.cs.
```csharp
builder.Services.AddSwaggerGen();

app.UseSwagger();
app.UseSwaggerUI();
```
Run it with IDE or console command.
```Powershell
dotnet run

Building...
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: https://localhost:7114
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5271
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
info: Microsoft.Hosting.Lifetime[0]
```
To see result of your work add /swagger/index.html to one of listening ports.  
