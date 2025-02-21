using Models.DTOs;
using Models.DTOs.Response;
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
        Task<List<DogBreedResponse>> GetAllBreed();
        Task<DogBreedResponse> GetDogBreedByIdAsync(string id);
        Task<DogBreed> CreateDogBreedAsync(CreateDogBreedRequest request);
        Task<DogBreed> UpdateDogBreedAsync(string id, UpdateDogBreedRequest request);
        Task<DogBreed> DeleteDogBreedAsync(string id);
    }
}
