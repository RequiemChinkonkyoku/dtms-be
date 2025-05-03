using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Wishlist.Request
{
    public class CreateWishListRequest
    {
        public string CustomerAccountId { get; set; }
        public string CourseId { get; set; }
    }
}
