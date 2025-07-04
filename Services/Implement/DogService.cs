﻿using AutoMapper;
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
            var customerProfile = await _unitOfWork.Accounts.GetById(request.CustomerId);
            if (customerProfile == null)
            {
                throw new ArgumentException($"CustomerProfile with ID {request.CustomerId} not found.");
            }
            var dogBreed = await _unitOfWork.DogBreeds.GetById(request.DogBreedId);
            if (dogBreed == null)
            {
                throw new ArgumentException($"DogBreed with ID {request.DogBreedId} not found.");
            }

            var dogCode = await GenerateDogCode(dogBreed);

            var newDog = new Dog
            {
                Id = Guid.NewGuid().ToString(),
                DogCode = dogCode,
                Name = request.Name,
                ImageUrl = request.ImageUrl,
                DateOfBirth = request.DateOfBirth,
                Gender = request.Gender,
                Status = 1,
                RegistrationTime = DateTime.UtcNow,
                CreatedTime = DateTime.UtcNow,
                LastUpdatedTime = DateTime.UtcNow,
                DogBreedId = request.DogBreedId
            };

            await _unitOfWork.Dogs.Add(newDog);
            await _unitOfWork.SaveChanges();

            var newDogOwnership = new DogOwnership
            {
                Id = Guid.NewGuid().ToString(),
                FromDate = DateOnly.FromDateTime(DateTime.UtcNow),
                CustomerId = request.CustomerId,
                DogId = newDog.Id
            };

            await _unitOfWork.DogOwnerships.Add(newDogOwnership);
            await _unitOfWork.SaveChanges();

            return newDog;
        }

        private async Task<string> GenerateDogCode(DogBreed dogBreed)
        {
            var dogCount = (await _unitOfWork.Dogs.GetAll())
                                    .Where(d => d.DogBreedId == dogBreed.Id)
                                    .Count();

            var breedPrefix = dogBreed.Name.Substring(0, 3).ToUpper();
            var numberSuffix = (dogCount + 1).ToString("D3");

            return breedPrefix + numberSuffix;
        }

        public async Task<DogResponse> UpdateDogAsync(string id, UpdateDogRequest request)
        {
            var existingDog = await _unitOfWork.Dogs.GetById(id);

            if (existingDog == null)
            {
                throw new KeyNotFoundException($"Dog not found.");
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

            existingDog.LastUpdatedTime = DateTime.UtcNow;

            _unitOfWork.Dogs.Update(existingDog);
            await _unitOfWork.SaveChanges();

            return _mapper.Map<DogResponse>(existingDog);
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

        public async Task<List<DogResponse>> GetDogsByCustomerProfileId(string customerProfileId)
        {
            var result = await _unitOfWork.Dogs.GetCustomerDog(customerProfileId);

            return _mapper.Map<List<DogResponse>>(result);
        }
    }
}
