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
    public class DogService : IDogService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DogService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Dog>> GetAllDogs()
        {
            var result = await _unitOfWork.Dogs.GetAll();
            return result;
        }

        public async Task<Dog> GetDogById(string id)
        {
            var result = await _unitOfWork.Dogs.GetById(id);
            return result;
        }

        public async Task<Dog> CreateDogAsync(CreateDogRequest request)
        {
            var newDog = new Dog
            {
                Id = Guid.NewGuid().ToString(),
                Name = request.Name,
                ImageUrl = request.ImageUrl,
                Breed = request.Breed,
                DateOfBirth = request.DateOfBirth,
                Gender = request.Gender,
                Status = request.Status,
                RegistrationTime = DateTime.UtcNow,
                CustomerProfileId = request.CustomerProfileId,
                CreatedTime = DateTime.UtcNow,
                LastUpdatedTime = DateTime.UtcNow,
                DogBreedId = request.DogBreedId
            };

            await _unitOfWork.Dogs.Add(newDog);
            await _unitOfWork.SaveChanges();

            return newDog;
        }

    }
}
