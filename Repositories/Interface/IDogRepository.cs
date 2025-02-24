using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
    public interface IDogRepository : IRepositoryBase<Dog>
    {
        Task<List<Dog>> GetAllDogs();

        Task<Dog> GetDogById(string dogId);

        Task<List<Dog>> GetCustomerDog(string customerProfileId);
    }
}
