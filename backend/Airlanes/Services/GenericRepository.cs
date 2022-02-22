using Airlanes.Data;
using Microsoft.EntityFrameworkCore;

class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
{
    private AirlanesDb _context;
    private DbSet<TEntity> dbSet;

    public GenericRepository(AirlanesDb context)
    {
        _context = context;
        dbSet = context.Set<TEntity>();
    }

    public async Task<IEnumerable<TEntity>> Get() => await dbSet.ToListAsync();

    public async Task<TEntity> GetById(Guid id) => await dbSet.FindAsync(id);

    public async Task Insert(TEntity entity) => await dbSet.AddAsync(entity);

    public void Delete(TEntity entity) => dbSet.Remove(entity);
}