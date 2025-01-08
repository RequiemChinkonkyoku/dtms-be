using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs
{
    public class UpdateDogBreedRequest
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [StringLength(500, ErrorMessage = "Description must not exceed 500 characters.")]
        public string Description { get; set; }

        [Range(0, 1, ErrorMessage = "Status must be 0 or 1.")]
        public int Status { get; set; }
    }
}
