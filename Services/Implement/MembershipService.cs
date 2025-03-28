using AutoMapper;
using Models.DTOs;
using Models.DTOs.Certification;
using Models.DTOs.Membership.Request;
using Models.DTOs.Membership.Response;
using Models.DTOs.TrainerReport;
using Models.Entities;
using Repositories.Interface;
using Repositories.Migrations;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implement
{
    public class MembershipService : IMembershipService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MembershipService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BaseResponseDTO<MembershipResponse>> GetAllMemberships()
        {
            var result = await _unitOfWork.Memberships.GetAll();
            var response = _mapper.Map<List<MembershipResponse>>(result);
            return new BaseResponseDTO<MembershipResponse> { Success = true, ObjectList = response };
        }

        public async Task<BaseResponseDTO<MembershipResponse>> GetMembershipById(string id)
        {
            var result = await _unitOfWork.Memberships.GetById(id);

            if (result == null)
            {
                return new BaseResponseDTO<MembershipResponse> { Success = false, Message = "Unable to find membership with id " + id };
            }

            var response = _mapper.Map<MembershipResponse>(result);
            return new BaseResponseDTO<MembershipResponse> { Success = true, Object = response };
        }

        public async Task<BaseResponseDTO<MembershipResponse>> CreateMembershipAsync(CreateMembershipRequest createMembershipRequest)
        {
            var membership = _mapper.Map<Membership>(createMembershipRequest);
            await _unitOfWork.Memberships.Add(membership);
            await _unitOfWork.SaveChanges();

            var response = _mapper.Map<MembershipResponse>(membership);
            return new BaseResponseDTO<MembershipResponse> { Success = true, Object = response };
        }

        public async Task<BaseResponseDTO<MembershipResponse>> UpdateMembershipAsync(string id, CreateMembershipRequest request)
        {
            var existingMembership = await _unitOfWork.Memberships.GetById(id);

            if (existingMembership == null)
            {
                throw new KeyNotFoundException($"Membership not found.");
            }

            _mapper.Map(request, existingMembership);

            existingMembership.LastUpdatedTime = DateTime.UtcNow;

            _unitOfWork.Memberships.Update(existingMembership);
            await _unitOfWork.SaveChanges();

            var response = _mapper.Map<MembershipResponse>(existingMembership);
            return new BaseResponseDTO<MembershipResponse> { Success = true, Object = response };
        }

        public async Task<bool> DeleteMembershipAsync(string id)
        {
            var existingMembership = await _unitOfWork.Memberships.GetById(id);

            if (existingMembership == null)
            {
                throw new KeyNotFoundException($"Membership not found.");
            }

            _unitOfWork.Memberships.Delete(existingMembership);
            await _unitOfWork.SaveChanges();

            return true;
        }

        public async Task<BaseResponseDTO<GetMembershipProgressResponse>> GetMembershipProgress(string customerId)
        {
            var customer = await _unitOfWork.Accounts.GetById(customerId);

            if (customer == null)
            {
                return new BaseResponseDTO<GetMembershipProgressResponse>
                {
                    Success = false,
                    Message = $"Unable to find customer with id {customerId}."
                };
            }

            var memberships = (await _unitOfWork.Memberships.GetAll())
                                            .OrderBy(m => m.RequiredPoints)
                                            .ToList();

            var currentMembership = memberships.FirstOrDefault(m => m.Id == customer.MembershipId);

            if (currentMembership == null)
            {
                return new BaseResponseDTO<GetMembershipProgressResponse>
                {
                    Success = false,
                    Message = "Unable to find current membership."
                };
            }

            var nextMembership = memberships.FirstOrDefault(m => m.RequiredPoints > currentMembership.RequiredPoints);
            var previousMembership = memberships.LastOrDefault(m => m.RequiredPoints < currentMembership.RequiredPoints);

            var membershipResponse = new GetMembershipProgressResponse
            {
                Point = customer.MembershipPoints,
                CurrentMembership = currentMembership,
                NextMembership = nextMembership,
                PreviousMembership = previousMembership
            };

            return new BaseResponseDTO<GetMembershipProgressResponse>
            {
                Success = true,
                Message = nextMembership != null ? "Next membership available" : "No futher membership available.",
                Object = membershipResponse
            };
        }
    }
}
