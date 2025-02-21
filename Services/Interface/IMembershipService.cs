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
        Task<List<MembershipResponse>> GetAllMemberships();
        Task<MembershipResponse> GetMembershipById(string id);
        Task<MembershipResponse> CreateMembershipAsync(CreateMembershipRequest createMembershipRequest);
        Task<MembershipResponse> UpdateMembershipAsync(string id, CreateMembershipRequest request);
        Task<bool> DeleteMembershipAsync(string id);
    }
}
