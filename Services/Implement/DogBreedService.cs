using AutoMapper;
using Microsoft.AspNetCore.Mvc;
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
    public class DogBreedService : IDogBreedService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DogBreedService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<DogBreedResponse>> GetAllBreed()
        {
            var dogBreeds = await _unitOfWork.DogBreeds.GetAllDogBreeds();
            return _mapper.Map<List<DogBreedResponse>>(dogBreeds);
        }

        public async Task<DogBreedResponse> GetDogBreedByIdAsync(string id)
        {
            var dogBreed = await _unitOfWork.DogBreeds.GetDogBreedById(id);
            return _mapper.Map<DogBreedResponse>(dogBreed);
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
            if (dogBreed == null)
            {
                throw new KeyNotFoundException($"DogBreed with ID '{id}' not found.");
            }
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
            if (dogBreed == null)
            {
                throw new KeyNotFoundException($"DogBreed with ID '{id}' not found.");
            }
            dogBreed.Status = 0;
            dogBreed.LastUpdatedTime = DateTime.UtcNow;

            _unitOfWork.DogBreeds.Update(dogBreed);
            await _unitOfWork.SaveChanges();

            return dogBreed;
        }

    }
}
