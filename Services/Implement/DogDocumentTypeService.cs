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
    public class DogDocumentTypeService : IDogDocumentTypeService
    {
        private readonly IUnitOfWork _unitOfWork ;
        public DogDocumentTypeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork ;
        }

        public async Task<List<DogDocumentType>> GetAllDocumentType()
        {
            var result = await _unitOfWork.DogDocumentTypes.GetAll();
            return result;
        }

        public async Task<DogDocumentType> GetDogDocumentTypeByIdAsync(string id)
        {
            var documentType = await _unitOfWork.DogDocumentTypes.GetById(id);
            return documentType;
        }

        public async Task<DogDocumentType> CreateDogDocumentTypeAsync(CreateDogDocumentTypeRequest request)
        {
            var dogDocumentType = new DogDocumentType
            {
                Name = request.Name,
                Description = request.Description,
                CreatedTime = DateTime.UtcNow,
                LastUpdatedTime = DateTime.UtcNow
            };

            await _unitOfWork.DogDocumentTypes.Add(dogDocumentType);
            await _unitOfWork.SaveChanges();

            return dogDocumentType;
        }

        public async Task<DogDocumentType> UpdateDogDocumentTypeAsync(string id, UpdateDogDocumentTypeRequest request)
        {
            var dogDocumentType = await _unitOfWork.DogDocumentTypes.GetById(id);
            if (dogDocumentType == null)
                throw new KeyNotFoundException($"DogDocumentType with Id {id} not found.");

            dogDocumentType.Name = request.Name;
            dogDocumentType.Description = request.Description;
            dogDocumentType.LastUpdatedTime = DateTime.UtcNow;

            _unitOfWork.DogDocumentTypes.Update(dogDocumentType);
            await _unitOfWork.SaveChanges();

            return dogDocumentType;
        }

    }
}
