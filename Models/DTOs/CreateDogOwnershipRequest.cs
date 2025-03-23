using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs
{
    public class CreateDogOwnershipRequest
    {
        public string DogId { get; set; }
        public string CustomerId { get; set; }
        public DateOnly FromDate { get; set; }

    }
}
