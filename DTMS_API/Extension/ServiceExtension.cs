using Models.Entities;
using Repositories.Implement;
using Repositories.Interface;
using Services.Implement;
using Services.Interface;

namespace DTMS_API.Extension;

public static class ServiceExtension
{
    public static IServiceCollection AddServiceExtension(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
        
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        
        services.AddScoped<IAccountRepository, AccountRepository>();

        services.AddScoped<IAccountService, AccountService>();
        
        return services;
    }
}