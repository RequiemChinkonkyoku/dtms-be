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
    public class DogOwnershipsService : IDogOwnershipsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DogOwnershipsService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<DogOwnershipResponse>> GetAllDogOwnerships()
        {
            var result = await _unitOfWork.DogOwnerships.GetAllDogOwnerships();
            return _mapper.Map<List<DogOwnershipResponse>>(result);
        }

        public async Task<DogOwnershipResponse> GetDogOwnershipById(string id)
        {
            var result = await _unitOfWork.DogOwnerships.GetDogOwnershipByIdAsync(id);
            return _mapper.Map<DogOwnershipResponse>(result);
        }

        public async Task<DogOwnershipResponse> CreateDogOwnershipAsync(CreateDogOwnershipRequest request)
        {


            var newOwnership = new DogOwnership
            {
                Id = Guid.NewGuid().ToString(),
                DogId = request.DogId,
                CustomerProfileId = request.CustomerProfileId,
                FromDate = request.FromDate,
                ToDate = null 
            };

            await _unitOfWork.DogOwnerships.Add(newOwnership);
            await _unitOfWork.SaveChanges();

            return _mapper.Map<DogOwnershipResponse>(newOwnership);
        }

        public async Task<DogOwnershipResponse> UpdateDogOwnershipAsync(string id, UpdateDogOwnershipRequest request)
        {

            var existingOwnership = await _unitOfWork.DogOwnerships.GetDogOwnershipByIdAsync(id);


            existingOwnership.DogId = request.DogId;
            existingOwnership.CustomerProfileId = request.CustomerProfileId;
            existingOwnership.FromDate = request.FromDate;
            existingOwnership.ToDate = DateOnly.FromDateTime(DateTime.UtcNow);

            await _unitOfWork.DogOwnerships.Update(existingOwnership);
            await _unitOfWork.SaveChanges();

            return _mapper.Map<DogOwnershipResponse>(existingOwnership);
        }

    }
}
