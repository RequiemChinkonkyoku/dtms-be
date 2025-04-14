using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Cage.Request
{
    public class CreateCageRequest
    {
        public string Location { get; set; }
        public string CageCategoryId { get; set; }
    }
}
