using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs
{
    public class UpdateDogRequest
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public string Breed { get; set; }

        [Required]
        public DateOnly DateOfBirth { get; set; } 

        [Required]
        public string Gender { get; set; }

        [Required]
        public int Status { get; set; }

        [Required]
        public string CustomerProfileId { get; set; }

        [Required]
        public string DogBreedId { get; set; }
    }

}
