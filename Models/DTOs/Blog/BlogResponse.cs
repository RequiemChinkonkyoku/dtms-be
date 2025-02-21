using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Blog
{
    public class BlogResponse
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public int Status { get; set; }
        public DateTime TimePublished { get; set; }

        public string StaffProfileId { get; set; }
        public DateTimeOffset CreatedTime { get; set; }
        public DateTimeOffset LastUpdatedTime { get; set; }
    }
}
