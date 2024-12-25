using Microsoft.AspNetCore.Mvc;
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
    public class DogBreedService : IDogBreedService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DogBreedService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<DogBreed>> GetAllBreed()
        {
            var result = await _unitOfWork.DogBreeds.GetAll();
            return result;
        }

        public async Task<DogBreed> CreateDogBreedAsync(CreateDogBreedRequest request)
        {
            var dogBreed = new DogBreed
            {
                Id = Guid.NewGuid().ToString(),
                Name = request.Name,
                Description = request.Description,
                Status = 1,
                CreatedTime = DateTime.UtcNow,
                LastUpdatedTime = DateTime.UtcNow
            };

            await _unitOfWork.DogBreeds.Add(dogBreed);
            await _unitOfWork.SaveChanges();

            return dogBreed;
        }

        public async Task<DogBreed> UpdateDogBreedAsync(string id, UpdateDogBreedRequest request)
        {
            var dogBreed = await _unitOfWork.DogBreeds.GetById(id);
            
            dogBreed.Name = request.Name;
            dogBreed.Description = request.Description;
            dogBreed.Status = request.Status;
            dogBreed.LastUpdatedTime = DateTime.UtcNow;

            _unitOfWork.DogBreeds.Update(dogBreed);
            await _unitOfWork.SaveChanges();

            return dogBreed;
        }

        public async Task<DogBreed> DeleteDogBreedAsync(string id)
        {
            var dogBreed = await _unitOfWork.DogBreeds.GetById(id);

            dogBreed.Status = 0;
            dogBreed.LastUpdatedTime = DateTime.UtcNow;

            _unitOfWork.DogBreeds.Update(dogBreed);
            await _unitOfWork.SaveChanges();

            return dogBreed;
        }

    }
}
