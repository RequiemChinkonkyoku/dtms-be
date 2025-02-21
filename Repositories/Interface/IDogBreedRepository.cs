using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
    public interface IDogBreedRepository : IRepositoryBase<DogBreed>
    {
        Task<List<DogBreed>> GetAllDogBreeds();

        Task<DogBreed> GetDogBreedById(string dogBreedId);
    }
}
