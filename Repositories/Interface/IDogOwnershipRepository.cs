using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
    public interface IDogOwnershipRepository : IRepositoryBase<DogOwnership>
    {
        Task<List<DogOwnership>> GetAllDogOwnerships();
        Task<DogOwnership> GetDogOwnershipByIdAsync(string id);
        Task AddDogOwnershipAsync(DogOwnership dogOwnership);
        Task UpdateDogOwnershipAsync(DogOwnership dogOwnership);
    }
}
