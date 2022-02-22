using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
public class GenericController<T> : Controller where T : class
{
    private IRepository<T> _repository;

    public GenericController(IRepository<T> repository) => _repository = repository;

    [HttpGet]
    public async Task<IEnumerable<T>> GetAllAsync() => await _repository.Get();

    [HttpGet("{id}")]
    public async Task<T> GetAsync(Guid id) => await _repository.GetById(id);

    [HttpPost]
    public async Task PostAsync([FromBody]T entity) => await _repository.Insert(entity);

    [HttpDelete("{id}")]
    public async Task DeleteAsync(Guid id)
    {
        T entity = await _repository.GetById(id);
        await _repository.Delete(entity);
    }
}