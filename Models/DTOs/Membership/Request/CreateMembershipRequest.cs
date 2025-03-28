using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Membership.Request
{
    public class CreateMembershipRequest
    {
        public string Name { get; set; }
        public int RequiredPoints { get; set; }
        public string Description { get; set; }
        public decimal DiscountAmount { get; set; }
    }
}
