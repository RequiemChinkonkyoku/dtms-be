using AutoMapper;
using Models.DTOs;
using Models.DTOs.Response;
using Models.Entities;
using Repositories.Implement;
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

        public async Task<List<DogDocumentResponse>> GetAllDogDocuments()
        {
            var result = await _unitOfWork.DogDocuments.GetAllDocument();
            return _mapper.Map<List<DogDocumentResponse>>(result);
        }

        public async Task<DogDocumentResponse> GetDogDocumentById(string id)
        {
            //var result = await _unitOfWork.DogDocuments.GetById(id);

            var  result = await _unitOfWork.DogDocuments.GetDocumentById(id);
            return _mapper.Map<DogDocumentResponse>(result);
        }

        public async Task<List<DogDocumentResponse>> GetDocumentsByDogId(string dogId)
        {
            var result = await _unitOfWork.DogDocuments.GetDocumentsByDogId(dogId);
            return _mapper.Map<List<DogDocumentResponse>>(result);
        }


        public async Task<DogDocumentResponse> CreateDogDocumentAsync(CreateDogDocumentRequest request)
        {
            var dog = await _unitOfWork.Dogs.GetById(request.DogId);
            if (dog == null)
            {
                throw new KeyNotFoundException("Dog with the specified ID was not found.");
            }
            var documentType = await _unitOfWork.DogDocumentTypes.GetById(request.DogDocumentTypeId);
            if (documentType == null)
            {
                throw new KeyNotFoundException("Document Type with the specified ID was not found.");
            }
            var newDogDocument = new DogDocument
            {
                Id = Guid.NewGuid().ToString(),
                Name = request.Name,
                ImageUrl = request.ImageUrl,
                Description = request.Description,
                Status = 1,
                IssueDate = request.IssueDate,
                UploadTime = DateTime.UtcNow,
                DogId = request.DogId,
                DogDocumentTypeId = request.DogDocumentTypeId,
                CreatedTime = DateTime.UtcNow,
                LastUpdatedTime = DateTime.UtcNow
            };

            await _unitOfWork.DogDocuments.Add(newDogDocument);
            await _unitOfWork.SaveChanges();

            return _mapper.Map<DogDocumentResponse>(newDogDocument);
        }

        public async Task<DogDocument> UpdateDogDocumentAsync(string id, UpdateDogDocumentRequest request)
        {
            var existingDogDocument = await _unitOfWork.DogDocuments.GetById(id);

            if (existingDogDocument == null)
            {
                throw new Exception($"Dog document not found.");
            }
            var dog = await _unitOfWork.Dogs.GetById(request.DogId);
            if (dog == null)
            {
                throw new KeyNotFoundException("Dog with the specified ID was not found.");
            }
            var documentType = await _unitOfWork.DogDocumentTypes.GetById(request.DogDocumentTypeId);
            if (documentType == null)
            {
                throw new KeyNotFoundException("Document Type with the specified ID was not found.");
            }
            existingDogDocument.Name = request.Name ?? existingDogDocument.Name;
            existingDogDocument.ImageUrl = request.ImageUrl ?? existingDogDocument.ImageUrl;
            existingDogDocument.Description = request.Description ?? existingDogDocument.Description;
            existingDogDocument.Status = request.Status != 0 ? request.Status : existingDogDocument.Status;
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
