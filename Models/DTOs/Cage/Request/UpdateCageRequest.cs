using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Cage.Request
{
    public class UpdateCageRequest
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public int Status { get; set; }
        public string CageCategoryId { get; set; }
    }
}
