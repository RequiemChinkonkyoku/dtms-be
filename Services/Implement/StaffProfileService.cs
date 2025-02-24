using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Models.DTOs.Response;
using Repositories.Interface;

namespace Services.Implement
{
    public class StaffProfileService : IStaffProfileService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public StaffProfileService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        
        public async Task<StaffProfileResponse> GetStaffProfile(string accountId)
        {
            var account = await _unitOfWork.Accounts
                .GetById(accountId);

            if (account == null || account.ProfileType != 3) // Ensure it's a staff account
            {
                return null; // Or throw an exception if needed
            }
    
            var staffProfiles = await _unitOfWork.StaffProfiles.GetAll();
            var staffProfile = staffProfiles.FirstOrDefault(sp => sp.AccountId == accountId);

            if (staffProfile == null)
            {
                return null; // Handle missing profile case
            }

            return new StaffProfileResponse
            {
                Username = account.Username,
                Email = account.Email,
                Status = account.Status,
                ProfileType = account.ProfileType,
                FullName = staffProfile.FullName,
                PhoneNumber = staffProfile.PhoneNumber,
                Address = staffProfile.Address,
                DateOfBirth = staffProfile.DateOfBirth,
                Gender = staffProfile.Gender,
                EmploymentType = staffProfile.EmploymentType,
                DateOfHire = staffProfile.DateOfHire
            };
        }

    }
}
