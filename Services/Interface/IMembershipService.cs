using Models.DTOs;
using Models.DTOs.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IMembershipService
    {
        Task<BaseResponseDTO<MembershipResponse>> GetAllMemberships();
        Task<BaseResponseDTO<MembershipResponse>> GetMembershipById(string id);
        Task<BaseResponseDTO<MembershipResponse>> CreateMembershipAsync(CreateMembershipRequest createMembershipRequest);
        Task<BaseResponseDTO<MembershipResponse>> UpdateMembershipAsync(string id, CreateMembershipRequest request);
        Task<bool> DeleteMembershipAsync(string id);
    }
}
