using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Response
{
    public class DogResponse
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string DateOfBirth { get; set; }
        public int Gender { get; set; }
        public int Status { get; set; }
        public string RegistrationTime { get; set; }
        public string DogOwnershipId { get; set; }
        public string CustomerProfileId { get; set; }
        public string DogBreedName { get; set; } 
        public string Id { get; set; }
        public string CreatedTime { get; set; }
        public string LastUpdatedTime { get; set; }

    }
}
