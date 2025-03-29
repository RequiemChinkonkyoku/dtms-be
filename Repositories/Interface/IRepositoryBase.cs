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
    Task<IEnumerable<T>> Get(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");

}