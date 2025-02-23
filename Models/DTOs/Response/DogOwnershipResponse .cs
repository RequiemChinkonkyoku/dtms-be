using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Response
{
    public class DogOwnershipResponse
    {
        public string Id { get; set; }
        public DateOnly FromDate { get; set; }
        public DateOnly? ToDate { get; set; }
        public string CustomerFullName { get; set; } 
        public string DogName { get; set; } 
    }
}
