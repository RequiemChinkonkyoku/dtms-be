using System.Linq.Expressions;

namespace Repositories.Interface;

public interface IRepositoryBase<T> where T : class
{
    Task<List<T>> GetAll();
    Task Add(T item);
    Task Update(T item);
    Task Delete(T item);
    Task<T> GetById(string id);
    Task<T> GetSingle(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
    Task<IQueryable<T>> Get(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties);
}