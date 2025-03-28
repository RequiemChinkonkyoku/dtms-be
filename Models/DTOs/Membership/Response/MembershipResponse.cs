﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Membership.Response
{
    public class MembershipResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int RequiredPoints { get; set; }
        public string Description { get; set; }
        public decimal DiscountAmount { get; set; }
        public DateTimeOffset CreatedTime { get; set; }
        public DateTimeOffset LastUpdatedTime { get; set; }
    }
}
