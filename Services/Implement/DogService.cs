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
            var customerProfile = await _unitOfWork.CustomerProfiles.GetById(request.CustomerProfileId);
            if (customerProfile == null)
            {
                throw new ArgumentException($"CustomerProfile with ID {request.CustomerProfileId} not found.");
            }
            var dogBreed = await _unitOfWork.DogBreeds.GetById(request.DogBreedId);
            if (dogBreed == null)
            {
                throw new ArgumentException($"DogBreed with ID {request.DogBreedId} not found.");
            }
            var newDog = new Dog
            {
                Id = Guid.NewGuid().ToString(),
                Name = request.Name,
                ImageUrl = request.ImageUrl,
                Breed = request.Breed,
                DateOfBirth = request.DateOfBirth,
                Gender = request.Gender,
                Status = 1,
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

        public async Task<Dog> UpdateDogAsync(string id, UpdateDogRequest request)
        {
            var existingDog = await _unitOfWork.Dogs.GetById(id);

            if (existingDog == null)
            {
                throw new KeyNotFoundException($"Dog not found.");
            }
            var customerProfile = await _unitOfWork.CustomerProfiles.GetById(request.CustomerProfileId);
            if (customerProfile == null)
            {
                throw new ArgumentException($"CustomerProfile with ID {request.CustomerProfileId} not found.");
            }
            var dogBreed = await _unitOfWork.DogBreeds.GetById(request.DogBreedId);
            if (dogBreed == null)
            {
                throw new ArgumentException($"DogBreed with ID {request.DogBreedId} not found.");
            }
            existingDog.Name = request.Name ?? existingDog.Name; 
            existingDog.ImageUrl = request.ImageUrl ?? existingDog.ImageUrl;
            existingDog.Breed = request.Breed ?? existingDog.Breed;
            existingDog.DateOfBirth = request.DateOfBirth != default ? request.DateOfBirth : existingDog.DateOfBirth;
            existingDog.Gender = request.Gender;
            existingDog.Status = request.Status;
            existingDog.DogBreedId = request.DogBreedId ?? existingDog.DogBreedId;
            existingDog.CustomerProfileId = request.CustomerProfileId ?? existingDog.CustomerProfileId;

            
            existingDog.LastUpdatedTime = DateTime.UtcNow;

            
            _unitOfWork.Dogs.Update(existingDog);
            await _unitOfWork.SaveChanges();

            return existingDog;
        }

        public async Task<Dog> DeleteDogAsync(string id)
        {
            var existingDog = await _unitOfWork.Dogs.GetById(id);

            if (existingDog == null)
            {
                throw new KeyNotFoundException($"Dog not found.");
            }

            existingDog.Status = 0;
            existingDog.LastUpdatedTime = DateTime.UtcNow;

            _unitOfWork.Dogs.Update(existingDog);
            await _unitOfWork.SaveChanges();

            return existingDog;
        }

    }
}
