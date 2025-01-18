using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs
{
    public class CreateDogRequest
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }
        [Url(ErrorMessage = "Invalid URL format.")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Breed is required.")]
        public string Breed { get; set; }
        [Required(ErrorMessage = "Date of Birth is required.")]
        public DateOnly DateOfBirth { get; set; }
        [Required(ErrorMessage = "Gender is required.")]
        public int Gender { get; set; }
        
        [Required(ErrorMessage = "Customer Profile Id is required.")]
        public string CustomerProfileId { get; set; }
        [Required(ErrorMessage = "Dog Breed Id is required.")]
        public string DogBreedId { get; set; }
    }
}
