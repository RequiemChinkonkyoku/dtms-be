namespace Repositories.Interface;

public interface IRepositoryBase<T> where T : class
{
    Task<List<T>> GetAll();
    Task Add(T item);
    Task Update(T item);
    Task Delete(T item);
    Task<T> FindById(int id);
}