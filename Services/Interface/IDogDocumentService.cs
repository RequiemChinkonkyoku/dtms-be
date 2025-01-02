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
    public interface IDogDocumentService
    {
        Task<List<DogDocument>> GetAllDogDocuments();
        Task<DogDocumentResponse> GetDogDocumentById(string id);
        Task<DogDocument> CreateDogDocumentAsync(CreateDogDocumentRequest request);
        Task<DogDocument> UpdateDogDocumentAsync(string id, UpdateDogDocumentRequest request);
        Task<DogDocument> DeleteDogDocumentAsync(string id);
    }
}
