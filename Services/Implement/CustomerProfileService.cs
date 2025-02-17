using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Models.DTOs.Response;
using Models.Entities;
using Repositories.Interface;

namespace Services.Implement
{
    public class CustomerProfileService : ICustomerProfileService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CustomerProfileService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<CustomerProfileResponse> GetCustomerProfile(string accountId)
        {
            var account = await _unitOfWork.Accounts
                .GetById(accountId);

            if (account == null || account.ProfileType != 1) // Ensure it's a customer
            {
                return null; // Or throw an exception if needed
            }
            
            var customerProfiles = await _unitOfWork.CustomerProfiles.GetAll();
            var customerProfile = customerProfiles.FirstOrDefault(cp => cp.AccountId == accountId);

            if (customerProfile == null)
            {
                return null; // Or handle missing profile case
            }

            return new CustomerProfileResponse
            {
                Username = account.Username,
                Email = account.Email,
                Status = account.Status,
                ProfileType = account.ProfileType,
                FullName = customerProfile.FullName,
                PhoneNumber = customerProfile.PhoneNumber,
                Address = customerProfile.Address,
                DateOfBirth = customerProfile.DateOfBirth,
                Gender = customerProfile.Gender,
                MembershipPoints = customerProfile.MembershipPoints
            };
        }
    }
}
