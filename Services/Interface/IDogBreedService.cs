using Models.DTOs;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IDogBreedService
    {
        Task<List<DogBreed>> GetAllBreed();
        Task<DogBreed> CreateDogBreedAsync(CreateDogBreedRequest request);
        Task<DogBreed> UpdateDogBreedAsync(string id, UpdateDogBreedRequest request);
        Task<DogBreed> DeleteDogBreedAsync(string id);
    }
}
