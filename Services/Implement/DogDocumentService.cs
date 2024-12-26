using Models.DTOs;
using Models.Entities;
using Repositories.Interface;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implement
{
    public class DogDocumentService : IDogDocumentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DogDocumentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<DogDocument>> GetAllDogDocuments()
        {
            var result = await _unitOfWork.DogDocuments.GetAll();
            return result;
        }

        public async Task<DogDocument> GetDogDocumentById(string id)
        {
            var result = await _unitOfWork.DogDocuments.GetById(id);
            return result;
        }

        public async Task<DogDocument> CreateDogDocumentAsync(CreateDogDocumentRequest request)
        {
            var newDogDocument = new DogDocument
            {
                Id = Guid.NewGuid().ToString(), 
                Name = request.Name,
                ImageUrl = request.ImageUrl,
                Description = request.Description,
                Status = 1,
                IssuingAuthority = request.IssuingAuthority,
                IssueDate = request.IssueDate,
                UploadTime = DateTime.UtcNow, 
                DogId = request.DogId, 
                DogDocumentTypeId = request.DogDocumentTypeId, 
                CreatedTime = DateTime.UtcNow, 
                LastUpdatedTime = DateTime.UtcNow 
            };

            await _unitOfWork.DogDocuments.Add(newDogDocument);
            await _unitOfWork.SaveChanges();

            return newDogDocument; 
        }
    }
}
