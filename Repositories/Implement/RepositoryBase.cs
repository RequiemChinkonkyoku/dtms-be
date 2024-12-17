using Microsoft.EntityFrameworkCore;
using Repositories.Interface;

namespace Repositories.Implement;

public class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    protected DtmsDbContext _context;
    private DbSet<T> _dbSet;

    public RepositoryBase()
    {
        _context = new DtmsDbContext();
        _dbSet = _context.Set<T>();
    }
    
    public async Task<List<T>> GetAll()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task Add(T item)
    {
        await _dbSet.AddAsync(item);
    }

    public async Task Update(T item)
    {
        _dbSet.Update(item);
    }

    public async Task Delete(T item)
    {
        _dbSet.Remove(item);
    }

    public async Task<T> FindById(int id)
    {
        return await _dbSet.FindAsync(id);
    }
}