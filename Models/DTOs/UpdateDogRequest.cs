﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Models.DTOs
{
    public class UpdateDogRequest
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Url(ErrorMessage = "The Image URL is not in a valid format.")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Date of Birth is required.")]
        public DateOnly DateOfBirth { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
        public int Gender { get; set; }

        [Required(ErrorMessage = "Status is required.")]
        [Range(0, 1, ErrorMessage = "Status must be either 0 (Inactive) or 1 (Active).")]
        public int Status { get; set; }
        [Required(ErrorMessage = "Dog Breed Id is required.")]
        public string DogBreedId { get; set; }
    }

}
