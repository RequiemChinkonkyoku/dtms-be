using Repositories.Interface;

namespace Repositories.Implement;

public class UnitOfWork : IUnitOfWork
{
    private readonly DtmsDbContext _dbContext;
    
    public IAccountRepository Accounts { get; }
    
    public UnitOfWork(IAccountRepository accountRepository)
    {
        _dbContext = new DtmsDbContext();
        Accounts = accountRepository;
    }
    
    public async Task SaveChanges()
    {
        await _dbContext.SaveChangesAsync();
    }
    
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    
    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            _dbContext.Dispose();
        }
    }
}