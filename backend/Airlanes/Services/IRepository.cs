public interface IRepository<TEntity> where TEntity : class
{
    public Task Delete(TEntity entity);
    public Task<IEnumerable<TEntity>> Get();
    public Task<TEntity> GetById (Guid id);
    public Task Insert(TEntity entity);
}