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
    public class DogService : IDogService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DogService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<DogResponse>> GetAllDogs()
        {
            var result = await _unitOfWork.Dogs.GetAllDogs();
            return _mapper.Map<List<DogResponse>>(result);

        }

        public async Task<DogResponse> GetDogById(string id)
        {
            var result = await _unitOfWork.Dogs.GetDogById(id);
            return _mapper.Map<DogResponse>(result);
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
