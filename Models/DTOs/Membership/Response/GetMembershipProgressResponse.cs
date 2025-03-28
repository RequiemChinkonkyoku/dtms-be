using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Membership.Response
{
    public class GetMembershipProgressResponse
    {
        public int Point { get; set; }

        public Entities.Membership? CurrentMembership { get; set; }

        public Entities.Membership? NextMembership { get; set; }

        public Entities.Membership? PreviousMembership { get; set; }
    }
}
