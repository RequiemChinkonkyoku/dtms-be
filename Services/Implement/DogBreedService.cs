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

    }
}
