using AutoMapper;
using Models.DTOs.Response;
using Repositories.Interface;
using Services.Interface;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Implement
{
    public class TrainerProfileService : ITrainerProfileService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TrainerProfileService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<TrainerProfileResponse> GetTrainerProfile(string accountId)
        {
            var account = await _unitOfWork.Accounts.GetById(accountId);

            if (account == null || account.ProfileType != 2) // Ensure it's a trainer account
            {
                return null; // Or throw an exception if needed
            }

            var trainerProfiles = await _unitOfWork.TrainerProfiles.GetAll();
            var trainerProfile = trainerProfiles.FirstOrDefault(tp => tp.AccountId == accountId);

            if (trainerProfile == null)
            {
                return null; // Handle missing profile case
            }

            return new TrainerProfileResponse
            {
                Id = trainerProfile.Id,
                Username = account.Username,
                Email = account.Email,
                Status = account.Status,
                ProfileType = account.ProfileType,
                FullName = trainerProfile.FullName,
                PhoneNumber = trainerProfile.PhoneNumber,
                Address = trainerProfile.Address,
                DateOfBirth = trainerProfile.DateOfBirth,
                Gender = trainerProfile.Gender,
                EmploymentType = trainerProfile.EmploymentType,
                DateOfHire = trainerProfile.DateOfHire
            };
        }
    }
}