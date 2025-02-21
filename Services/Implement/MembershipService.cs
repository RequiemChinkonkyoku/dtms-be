using AutoMapper;
using Models.DTOs.Membership;
using Models.DTOs.TrainerReport;
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
    public class MembershipService : IMembershipService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MembershipService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<MembershipResponse>> GetAllMemberships()
        {
            var result = await _unitOfWork.Memberships.GetAll();
            return _mapper.Map<List<MembershipResponse>>(result);
        }

        public async Task<MembershipResponse> GetMembershipById(string id)
        {
            var result = await _unitOfWork.Memberships.GetById(id);
            return _mapper.Map<MembershipResponse>(result);
        }

        public async Task<MembershipResponse> CreateMembershipAsync(CreateMembershipRequest createMembershipRequest)
        {
            var membership = _mapper.Map<Membership>(createMembershipRequest);
            await _unitOfWork.Memberships.Add(membership);
            await _unitOfWork.SaveChanges();

            return _mapper.Map<MembershipResponse>(membership);
        }

        public async Task<MembershipResponse> UpdateMembershipAsync(string id, CreateMembershipRequest request)
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

            return _mapper.Map<MembershipResponse>(existingMembership);
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

    }
}
