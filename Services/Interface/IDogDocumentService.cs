using Models.DTOs;
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
        Task<DogDocument> GetDogDocumentById(string id);
        Task<DogDocument> CreateDogDocumentAsync(CreateDogDocumentRequest request);
    }
}
