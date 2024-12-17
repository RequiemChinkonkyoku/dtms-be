namespace Repositories.Interface;

public interface IUnitOfWork : IDisposable
{
    IAccountRepository Accounts { get; }
    
    Task SaveChanges();
}