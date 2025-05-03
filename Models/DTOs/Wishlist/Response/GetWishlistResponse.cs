using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Wishlist.Response
{
    public class GetWishlistResponse
    {
        public string Id { get; set; }

        public string CustomerAccountId { get; set; }
        public string CustomerName { get; set; }
        public string RoleName { get; set; }

        public string CourseId { get; set; }
        public string CourseName { get; set; }
        public bool OpenClass { get; set; }
    }
}
