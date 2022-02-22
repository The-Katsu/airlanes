using Airlanes.Data;
using Microsoft.EntityFrameworkCore;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    private AirlanesDb _context;
    private DbSet<TEntity> dbSet;

    public Repository(AirlanesDb context)
    {
        _context = context;
        dbSet = context.Set<TEntity>();
    }

    public async Task<IEnumerable<TEntity>> Get() => await dbSet.ToListAsync();

    public async Task<TEntity> GetById(Guid id) => await dbSet.FindAsync(id);

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