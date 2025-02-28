using Models.DTOs;
using Models.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IDogOwnershipsService
    {
        Task<List<DogOwnershipResponse>> GetAllDogOwnerships();
        Task<DogOwnershipResponse> GetDogOwnershipById(string id);
        Task<DogOwnershipResponse> CreateDogOwnershipAsync(CreateDogOwnershipRequest request);
        Task<DogOwnershipResponse> UpdateDogOwnershipAsync(string id, UpdateDogOwnershipRequest request);
    }
}
