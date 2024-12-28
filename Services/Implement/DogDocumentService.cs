using AutoMapper;
using Models.DTOs;
using Models.DTOs.Response;
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
        private readonly IMapper _mapper;
        
        public DogDocumentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<DogDocument>> GetAllDogDocuments()
        {
            var result = await _unitOfWork.DogDocuments.GetAll();
            return result;
        }

        public async Task<DogDocumentResponse> GetDogDocumentById(string id)
        {
            //var result = await _unitOfWork.DogDocuments.GetById(id);

            var  result = await _unitOfWork.DogDocuments.GetDocumentById(id);
            return _mapper.Map<DogDocumentResponse>(result);
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

        public async Task<DogDocument> UpdateDogDocumentAsync(string id, UpdateDogDocumentRequest request)
        {
            var existingDogDocument = await _unitOfWork.DogDocuments.GetById(id);

            if (existingDogDocument == null)
            {
                throw new Exception($"Dog document not found.");
            }

            existingDogDocument.Name = request.Name ?? existingDogDocument.Name;
            existingDogDocument.ImageUrl = request.ImageUrl ?? existingDogDocument.ImageUrl;
            existingDogDocument.Description = request.Description ?? existingDogDocument.Description;
            existingDogDocument.Status = request.Status != 0 ? request.Status : existingDogDocument.Status;
            existingDogDocument.IssuingAuthority = request.IssuingAuthority ?? existingDogDocument.IssuingAuthority;
            existingDogDocument.IssueDate = request.IssueDate != default ? request.IssueDate : existingDogDocument.IssueDate;
            existingDogDocument.DogId = request.DogId ?? existingDogDocument.DogId;
            existingDogDocument.DogDocumentTypeId = request.DogDocumentTypeId ?? existingDogDocument.DogDocumentTypeId;
            existingDogDocument.LastUpdatedTime = DateTime.UtcNow; 

            await _unitOfWork.DogDocuments.Update(existingDogDocument);
            await _unitOfWork.SaveChanges();

            return existingDogDocument;
        }

        public async Task<DogDocument> DeleteDogDocumentAsync(string id)
        {
            var existingDogDocument = await _unitOfWork.DogDocuments.GetById(id);

            if (existingDogDocument == null)
            {
                throw new Exception($"Dog document not found.");
            }

            existingDogDocument.Status = 0;
            existingDogDocument.LastUpdatedTime = DateTime.UtcNow;

            await _unitOfWork.DogDocuments.Update(existingDogDocument);
            await _unitOfWork.SaveChanges();

            return existingDogDocument;
        }


    }
}
