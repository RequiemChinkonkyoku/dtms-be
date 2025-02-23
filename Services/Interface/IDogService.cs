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
    public interface IDogService
    {
        Task<List<DogResponse>> GetAllDogs();
        Task<DogResponse> GetDogById(string id);
        Task<Dog> CreateDogAsync(CreateDogRequest createDogRequest);
        Task<DogResponse> UpdateDogAsync(string id, UpdateDogRequest request);
        Task<Dog> DeleteDogAsync(string id);
    }
}
