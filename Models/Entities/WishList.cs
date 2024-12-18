using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class WishList : BaseEntity
    {
        public string CustomerProfileId { get; set; }
        public CustomerProfile CustomerProfile { get; set; }

        public string CourseId { get; set; }
        public Course Course { get; set; }
    }
}
