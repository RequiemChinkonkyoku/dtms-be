using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs
{
    public class CreateDogRequest
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Breed { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Gender { get; set; }
        public int Status { get; set; }
        public string CustomerProfileId { get; set; }
        public string DogBreedId { get; set; }
    }
}
