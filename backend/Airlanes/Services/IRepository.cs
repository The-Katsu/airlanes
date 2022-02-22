public interface IRepository<TEntity> where TEntity : class
{
    void Delete(TEntity entity);
    Task<IEnumerable<TEntity>> Get();
    Task<TEntity> GetById (Guid id);
    Task Insert(TEntity entity);
}