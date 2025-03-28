using Models.DTOs;
using Models.DTOs.Response;
using Models.Entities;

namespace Repositories.Interface;

public interface IAccountRepository : IRepositoryBase<Account>
{
    Task<List<Account>> GetAvailableTrainersAsync(TrainerAvailabilityRequest request);
}