using Models.DTOs;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IDogDocumentTypeService
    {
        Task<List<DogDocumentType>> GetAllDocumentType();
        Task<DogDocumentType> GetDogDocumentTypeByIdAsync(string id);
        Task<DogDocumentType> CreateDogDocumentTypeAsync(CreateDogDocumentTypeRequest request);
        Task<DogDocumentType> UpdateDogDocumentTypeAsync(string id, UpdateDogDocumentTypeRequest request);
        Task<string> DeleteDogDocumentTypeAsync(string id);

    }
}
