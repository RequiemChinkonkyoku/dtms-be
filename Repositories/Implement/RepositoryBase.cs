using System.Linq.Expressions;
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
        await _context.SaveChangesAsync();
    }

    public async Task Update(T item)
    {
        _dbSet.Update(item);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(T item)
    {
        _dbSet.Remove(item);
        await _context.SaveChangesAsync();
    }

    public async Task<T> GetById(string id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task<T> GetSingle(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
    {
        IQueryable<T> query = _dbSet;

        // Include related entities
        foreach (var includeProperty in includeProperties)
        {
            query = query.Include(includeProperty);
        }

        return await query.SingleOrDefaultAsync(predicate);
    }

    public async Task<IEnumerable<T>> Get(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
    {
        IQueryable<T> query = _dbSet;

        // Apply the filter if provided
        if (predicate != null)
        {
            query = query.Where(predicate);
        }

        // Include related entities if provided
        foreach (var includeProperty in includeProperties.Split(
                     new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
        {
            query = query.Include(includeProperty);
        }

        // Apply ordering if specified
        if (orderBy != null)
        {
            return await Task.FromResult(orderBy(query).ToList());
        }

        return await Task.FromResult(query.ToList());
    }

}